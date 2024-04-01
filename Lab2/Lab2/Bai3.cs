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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        List<string> output = new List<string>();
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
                            string content = sr.ReadToEnd().Trim();
                            if (content.Contains(','))
                            {
                                MessageBox.Show("Format không hợp lệ!");
                                return;
                            }
                            string[] source = content.Split(new string[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
                            output.Clear();
                            for (int i = 0; i < source.Length; i++)
                            {
                                if (source[i].Contains('+'))
                                {
                                    string[] calc = source[i].Split(new char[] { ' ', '+' }, StringSplitOptions.RemoveEmptyEntries);
                                    double res = 0;
                                    int cnt = 0;
                                    foreach (var j in source[i])
                                    {
                                        if (j == '+') cnt++;
                                    }
                                    if (cnt != calc.Length - 1)
                                    {
                                        MessageBox.Show("Format không hợp lệ!");
                                        return;
                                    }
                                    for (int j = 0; j < calc.Length; j++) 
                                    {
                                        double test = 0;
                                        if (!double.TryParse(calc[j], out test))
                                        {
                                            MessageBox.Show("Format không hợp lệ!");
                                            return;
                                        }
                                        res += Convert.ToDouble(calc[j]);
                                        if (j != 0)
                                        {
                                            output.Add("+ ");
                                        }
                                        output.Add(calc[j]);
                                        output.Add(" ");
                                    }
                                    output.Add("= ");
                                    output.Add(res.ToString());
                                    output.Add("\r\n");
                                }
                                else if (source[i].Contains('-'))
                                {
                                    string[] calc = source[i].Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                                    double test = 0;
                                    int cnt = 0;
                                    foreach (var j in source[i])
                                    {
                                        if (j == '-') cnt++;
                                    }
                                    if (cnt != calc.Length - 1)
                                    {
                                        MessageBox.Show("Format không hợp lệ!");
                                        return;
                                    }
                                    foreach (string x in calc)
                                    {
                                        if (!double.TryParse(x, out test))
                                        {
                                            MessageBox.Show("Format không hợp lệ!");
                                            return;
                                        }
                                    }
                                    double res = Convert.ToDouble(calc[0]);
                                    output.Add(calc[0]);
                                    output.Add(" ");
                                    for (int j = 1; j < calc.Length; j++)
                                    {
                                        res -= Convert.ToDouble(calc[j]);
                                        output.Add("- ");
                                        output.Add(calc[j]);
                                        output.Add(" ");
                                    }
                                    output.Add("= ");
                                    output.Add(res.ToString());
                                    output.Add("\r\n");
                                }
                                else if (source[i].Contains('*'))
                                {
                                    string[] calc = source[i].Split(new char[] { ' ', '*' }, StringSplitOptions.RemoveEmptyEntries);
                                    double test = 0;
                                    int cnt = 0;
                                    foreach (var j in source[i])
                                    {
                                        if (j == '*') cnt++;
                                    }
                                    if (cnt != calc.Length - 1)
                                    {
                                        MessageBox.Show("Format không hợp lệ!");
                                        return;
                                    }
                                    foreach (string x in calc)
                                    {
                                        if (!double.TryParse(x, out test))
                                        {
                                            MessageBox.Show("Format không hợp lệ!");
                                            return;
                                        }
                                    }
                                    double res = Convert.ToDouble(calc[0]);
                                    output.Add(calc[0]);
                                    output.Add(" ");
                                    for (int j = 1; j < calc.Length; j++)
                                    {
                                        res *= Convert.ToDouble(calc[j]);
                                        output.Add("* ");
                                        output.Add(calc[j]);
                                        output.Add(" ");
                                    }
                                    output.Add("= ");
                                    output.Add(res.ToString());
                                    output.Add("\r\n");
                                }
                                else if (source[i].Contains('/'))
                                {
                                    string[] calc = source[i].Split(new char[] { ' ', '/' }, StringSplitOptions.RemoveEmptyEntries);
                                    double test = 0;
                                    int cnt = 0;
                                    foreach (var j in source[i])
                                    {
                                        if (j == '/') cnt++;
                                    }
                                    if (cnt != calc.Length - 1)
                                    {
                                        MessageBox.Show("Format không hợp lệ!");
                                        return;
                                    }
                                    foreach (string x in calc)
                                    {
                                        if (!double.TryParse(x, out test))
                                        {
                                            MessageBox.Show("Format không hợp lệ!");
                                            return;
                                        }
                                        
                                    }
                                    double res = Convert.ToDouble(calc[0]);
                                    output.Add(calc[0]);
                                    output.Add(" ");
                                    for (int j = 1; j < calc.Length; j++)
                                    {
                                        if (calc[j] == "0")
                                        {
                                            MessageBox.Show("Không thể chia cho 0!");
                                        }
                                        res /= Convert.ToDouble(calc[j]);
                                        output.Add("/");
                                        output.Add(" ");
                                        output.Add(calc[j]);
                                        output.Add(" ");
                                    }
                                    output.Add("= ");
                                    output.Add(res.ToString());
                                    output.Add("\r\n");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(ofd.FileName))
                {
                    using (FileStream fs1 = new FileStream(ofd.FileName, FileMode.Truncate)) {}
                    using (FileStream fs2 = new FileStream(ofd.FileName, FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(fs2))
                        {
                            sw.Write(string.Join("",output));
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("C:\\TLHT\\HK2_2023-2024\\LapTrinhMangCanBan\\TH\\LAB2\\Lab2\\outputb3.txt", FileMode.OpenOrCreate))
            {
                StreamReader streamReader = new StreamReader(fileStream);
                richTextBox1.Text = streamReader.ReadToEnd();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
