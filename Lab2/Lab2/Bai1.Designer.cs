namespace Lab2
{
    partial class Bai1
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
            this.Content = new System.Windows.Forms.RichTextBox();
            this.ReadFile = new System.Windows.Forms.Button();
            this.WriteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(222, 31);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(544, 397);
            this.Content.TabIndex = 0;
            this.Content.Text = "";
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(52, 56);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(114, 59);
            this.ReadFile.TabIndex = 1;
            this.ReadFile.Text = "Đọc File";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // WriteFile
            // 
            this.WriteFile.Location = new System.Drawing.Point(52, 146);
            this.WriteFile.Name = "WriteFile";
            this.WriteFile.Size = new System.Drawing.Size(114, 56);
            this.WriteFile.TabIndex = 2;
            this.WriteFile.Text = "Ghi File";
            this.WriteFile.UseVisualStyleBackColor = true;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WriteFile);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.Content);
            this.Name = "Bai1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Button WriteFile;
    }
}

