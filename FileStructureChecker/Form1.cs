using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileStructureChecker
{


    public partial class Form1 : Form
    {
        List<String> Folder1 { get; set; } = new List<string>();
        List<String> Folder2 { get; set; } = new List<string>();
        string FolderPath1 { get; set; }
        string FolderPath2 { get; set; }
        Dictionary<string, string> AbsolutePathAndFileName1 { get; set; } = new Dictionary<string, string>();
        Dictionary<string, string> AbsolutePathAndFileName2 { get; set; } = new Dictionary<string, string>();
        Dictionary<string, string> MissedFiles { get; set; } = new Dictionary<string, string>();
        Dictionary<string, string> AddedFiles { get; set; } = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowDiff_Click(object sender, EventArgs e)
        {
            richTextBoxDiff.Clear();
            MissedFiles.Clear();
            AddedFiles.Clear();
            List<string> pathsToShow = new List<string>();
            FolderPath1 = textBoxFolder1.Text.Replace('"', ' ').Trim();
            FolderPath2 = textBoxFolder2.Text.Replace('"', ' ').Trim(); ;
            Folder1 = GetAllFilesFromDirRecursively(FolderPath1);
            Folder2 = GetAllFilesFromDirRecursively(FolderPath2);
            AbsolutePathAndFileName1 = Folder1.ToDictionary(x => x, x => GetFileNameFromAbsolutePath(x));
            AbsolutePathAndFileName2 = Folder2.ToDictionary(x => x, x => GetFileNameFromAbsolutePath(x));
            foreach (KeyValuePair<string, string> filePath in AbsolutePathAndFileName1)
            {
                if (!AbsolutePathAndFileName2.Any(x => x.Value.Equals(filePath.Value)))
                {
                    AddedFiles.Add(filePath.Key, filePath.Value);
                    //pathsToShow.Add(filePath.Key);
                }
            }
            //foreach (string file in pathsToShow)
            //    richTextBoxDiff.AppendText($"+ {file}\n", Color.Green);
            foreach (KeyValuePair<string, string> file in AddedFiles)
                richTextBoxDiff.AppendText($"+ {file.Key}\n", Color.Green);

                pathsToShow = new List<string>();
            foreach (KeyValuePair<string, string> filePath in AbsolutePathAndFileName2)
            {
                if (!AbsolutePathAndFileName1.Any(x => x.Value.Equals(filePath.Value)))
                {
                    //pathsToShow.Add(filePath.Key);
                    MissedFiles.Add(filePath.Key, filePath.Value);
                }
            }
            //richTextBoxDiff.SelectionColor = Color.Red;
            //foreach (string file in pathsToShow)
            //    richTextBoxDiff.AppendText($"- {file}\n", Color.Red);
            foreach (KeyValuePair<string, string> file in MissedFiles)
                richTextBoxDiff.AppendText($"- {file.Key}\n", Color.Red);

        }

        public static List<string> GetAllFilesFromDirRecursively(string FolderPath)
        {
            List<string> files = new List<string>();
            try
            {
                foreach(string f in Directory.GetFiles(FolderPath))
                {
                    files.Add(f);
                }
                foreach (string d in Directory.GetDirectories(FolderPath))
                {
                    files.AddRange(GetAllFilesFromDirRecursively(d));
                }
            }
            catch(Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            return files;
        }
        
        public static string GetFileNameFromAbsolutePath(string absolutePath)
        {
            int lastOccurenceOfBackSlash = absolutePath.LastIndexOf(@"\");
            return absolutePath.Substring(lastOccurenceOfBackSlash + 1);
        }

        public static List<string> GetFilesNameFromAbsolutePaths(List<String> absolutePaths)
        {
            List<string> filePaths = new List<string>();
            foreach (string absolutePath in absolutePaths)
            {
                filePaths.Add(GetFileNameFromAbsolutePath(absolutePath));
            }
            return absolutePaths;
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            if (MissedFiles.Count == 0)
                return;
            //string  MissedFiles.First().Key.Substring(textBoxFolder2.Text.Length);
            foreach(KeyValuePair<string, string> keyValuePair in MissedFiles)
            {
                string barePath = keyValuePair.Key.Substring(FolderPath2.Length + 1);
                string destinationPath = Path.Combine(FolderPath1, barePath);
                Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                File.Copy(keyValuePair.Key, destinationPath);
            }

        }

        private void buttonReverseFolderPath_Click(object sender, EventArgs e)
        {
            string tempString = textBoxFolder1.Text;
            textBoxFolder1.Text = textBoxFolder2.Text;
            textBoxFolder2.Text = tempString;
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            box.SelectionLength = 0; // clear
        }
    }
}
