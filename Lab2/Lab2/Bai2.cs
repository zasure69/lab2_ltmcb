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

        private void button1_Click(object sender, EventArgs e)
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
                            int charCount = content.Length;
                            content = content.Replace("\r\n","\r");
                            int lineCount = richTextBox1.Lines.Count();
                            content = content.Replace('\r',' ');
                            string[] source = content.Split(new char[] {'\r','\n','\t', '.','?','!',' ',',',';',':'},StringSplitOptions.RemoveEmptyEntries);
                            int wordCount = source.Count();
                            for (int i = 0;i < source.Count();i++)
                            {
                                char[] test = source[i].ToCharArray();
                                for (int j = 0; j < test.Length;j++)
                                {
                                    switch (test[j])
                                    {
                                        case '@':
                                        case '#':
                                        case '>':
                                        case '<':
                                        case '&':
                                        case '~':
                                            {
                                                wordCount--;
                                                break;
                                            }
                                        default: continue;
                                    }
                                }
                                  
                            }    
                            textBox1.Text = ofd.SafeFileName.ToString();
                            textBox2.Text = ofd.FileName.ToString();
                            textBox3.Text = lineCount.ToString();
                            textBox4.Text = wordCount.ToString();
                            textBox5.Text = charCount.ToString();
                        }
                    }
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static string SwitchChar(char input)
        {
            switch (input)
            {
                case 'a':
                    {
                        return "Area";
                    }
                case 'b':
                    {
                        return "Box";
                    }
                case 'c':
                    {
                        return "Cat";
                    }
                case 'S':
                case 's':
                    {
                        return "Spot";
                    }
                case 'T':
                case 't':
                    {
                        return "Test";
                    }
                case 'U':
                case 'u':
                    {
                        return "Under";
                    }
                default:
                    {
                        return "Deal";
                    }
            }
        }
    }
}
