namespace Lab2
{
    partial class Bai2
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
            this.readFilebutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.filename = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.linenum = new System.Windows.Forms.TextBox();
            this.wordnum = new System.Windows.Forms.TextBox();
            this.charnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readFilebutton
            // 
            this.readFilebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readFilebutton.Location = new System.Drawing.Point(28, 21);
            this.readFilebutton.Name = "readFilebutton";
            this.readFilebutton.Size = new System.Drawing.Size(260, 94);
            this.readFilebutton.TabIndex = 0;
            this.readFilebutton.Text = "Đọc File";
            this.readFilebutton.UseVisualStyleBackColor = true;
            this.readFilebutton.Click += new System.EventHandler(this.readFilebutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(347, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(488, 459);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(149, 152);
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            this.filename.Size = new System.Drawing.Size(139, 22);
            this.filename.TabIndex = 2;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(149, 200);
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Size = new System.Drawing.Size(139, 22);
            this.url.TabIndex = 3;
            // 
            // linenum
            // 
            this.linenum.Location = new System.Drawing.Point(149, 259);
            this.linenum.Name = "linenum";
            this.linenum.ReadOnly = true;
            this.linenum.Size = new System.Drawing.Size(139, 22);
            this.linenum.TabIndex = 4;
            // 
            // wordnum
            // 
            this.wordnum.Location = new System.Drawing.Point(149, 316);
            this.wordnum.Name = "wordnum";
            this.wordnum.ReadOnly = true;
            this.wordnum.Size = new System.Drawing.Size(139, 22);
            this.wordnum.TabIndex = 5;
            // 
            // charnum
            // 
            this.charnum.Location = new System.Drawing.Point(149, 371);
            this.charnum.Name = "charnum";
            this.charnum.ReadOnly = true;
            this.charnum.Size = new System.Drawing.Size(139, 22);
            this.charnum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số ký tự";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(72, 414);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(166, 66);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 506);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charnum);
            this.Controls.Add(this.wordnum);
            this.Controls.Add(this.linenum);
            this.Controls.Add(this.url);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.readFilebutton);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFilebutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox linenum;
        private System.Windows.Forms.TextBox wordnum;
        private System.Windows.Forms.TextBox charnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Exit;
    }
}