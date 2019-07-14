namespace FileStructureChecker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelFolder1 = new System.Windows.Forms.Label();
            this.labelFolder2 = new System.Windows.Forms.Label();
            this.textBoxFolder1 = new System.Windows.Forms.TextBox();
            this.textBoxFolder2 = new System.Windows.Forms.TextBox();
            this.richTextBoxDiff = new System.Windows.Forms.RichTextBox();
            this.buttonShowDiff = new System.Windows.Forms.Button();
            this.buttonSync = new System.Windows.Forms.Button();
            this.buttonReverseFolderPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFolder1
            // 
            this.labelFolder1.AutoSize = true;
            this.labelFolder1.Location = new System.Drawing.Point(21, 42);
            this.labelFolder1.Name = "labelFolder1";
            this.labelFolder1.Size = new System.Drawing.Size(45, 13);
            this.labelFolder1.TabIndex = 0;
            this.labelFolder1.Text = "Folder1:";
            // 
            // labelFolder2
            // 
            this.labelFolder2.AutoSize = true;
            this.labelFolder2.Location = new System.Drawing.Point(21, 89);
            this.labelFolder2.Name = "labelFolder2";
            this.labelFolder2.Size = new System.Drawing.Size(45, 13);
            this.labelFolder2.TabIndex = 1;
            this.labelFolder2.Text = "Folder2:";
            // 
            // textBoxFolder1
            // 
            this.textBoxFolder1.Location = new System.Drawing.Point(72, 39);
            this.textBoxFolder1.Name = "textBoxFolder1";
            this.textBoxFolder1.Size = new System.Drawing.Size(511, 20);
            this.textBoxFolder1.TabIndex = 2;
            // 
            // textBoxFolder2
            // 
            this.textBoxFolder2.Location = new System.Drawing.Point(72, 86);
            this.textBoxFolder2.Name = "textBoxFolder2";
            this.textBoxFolder2.Size = new System.Drawing.Size(511, 20);
            this.textBoxFolder2.TabIndex = 3;
            // 
            // richTextBoxDiff
            // 
            this.richTextBoxDiff.Location = new System.Drawing.Point(72, 129);
            this.richTextBoxDiff.Name = "richTextBoxDiff";
            this.richTextBoxDiff.Size = new System.Drawing.Size(511, 279);
            this.richTextBoxDiff.TabIndex = 4;
            this.richTextBoxDiff.Text = "";
            // 
            // buttonShowDiff
            // 
            this.buttonShowDiff.Location = new System.Drawing.Point(672, 42);
            this.buttonShowDiff.Name = "buttonShowDiff";
            this.buttonShowDiff.Size = new System.Drawing.Size(75, 23);
            this.buttonShowDiff.TabIndex = 5;
            this.buttonShowDiff.Text = "ShowDiff";
            this.buttonShowDiff.UseVisualStyleBackColor = true;
            this.buttonShowDiff.Click += new System.EventHandler(this.buttonShowDiff_Click);
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(672, 89);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(75, 23);
            this.buttonSync.TabIndex = 6;
            this.buttonSync.Text = "Sync";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // buttonReverseFolderPath
            // 
            this.buttonReverseFolderPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReverseFolderPath.BackgroundImage")));
            this.buttonReverseFolderPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReverseFolderPath.Location = new System.Drawing.Point(589, 39);
            this.buttonReverseFolderPath.Name = "buttonReverseFolderPath";
            this.buttonReverseFolderPath.Size = new System.Drawing.Size(37, 67);
            this.buttonReverseFolderPath.TabIndex = 7;
            this.buttonReverseFolderPath.UseVisualStyleBackColor = true;
            this.buttonReverseFolderPath.Click += new System.EventHandler(this.buttonReverseFolderPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReverseFolderPath);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.buttonShowDiff);
            this.Controls.Add(this.richTextBoxDiff);
            this.Controls.Add(this.textBoxFolder2);
            this.Controls.Add(this.textBoxFolder1);
            this.Controls.Add(this.labelFolder2);
            this.Controls.Add(this.labelFolder1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFolder1;
        private System.Windows.Forms.Label labelFolder2;
        private System.Windows.Forms.TextBox textBoxFolder1;
        private System.Windows.Forms.TextBox textBoxFolder2;
        private System.Windows.Forms.RichTextBox richTextBoxDiff;
        private System.Windows.Forms.Button buttonShowDiff;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.Button buttonReverseFolderPath;
    }
}

