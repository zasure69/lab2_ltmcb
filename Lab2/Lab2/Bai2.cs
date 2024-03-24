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

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void readfileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(ofd.FileName))
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string content = sr.ReadToEnd();
                            richTextBox1.Text = content;
                            filename.Text = ofd.SafeFileName.ToString();
                            url.Text = fs.Name.ToString();
                        }
                    }
                }
            }
        }
    }
}
