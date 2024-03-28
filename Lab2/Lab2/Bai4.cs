using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        [Serializable]
        internal class HocVien
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string DienThoai { get; set; }
            public float DiemToan { get; set; }
            public float DiemVan { get; set; }
            public float DTB { get; set; }
        }
        List<HocVien> hocVienarray = new List<HocVien>();
        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("C:\\TLHT\\HK2_2023-2024\\LapTrinhMangCanBan\\TH\\LAB2\\Lab2\\inputb4.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (fileStream.Length != 0)
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    hocVienarray = (List<HocVien>)binaryFormatter.Deserialize(fileStream);
                }
            }

            if (HoTen.Text.Length == 0 || MSSV.Text.Length == 0 || DienThoai.Text.Length == 0 || DiemToan.Text.Length == 0 || DiemVan.Text.Length == 0)
            {
                MessageBox.Show("Hãy điền đủ thông tin!");
                return;
            }

            char[] invalid_hoten = new char[] {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '=', '[', ']', 
                '{', '}', '|', '?', '/', '\\', ',', ';', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '>', '<'};

            char[] invalid_sdt = new char[] {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '=', '[', ']',
                '{', '}', '|', '?', '/', '\\', ',', ';', '>', '<'};

            foreach (var x in invalid_hoten)
            {
                if (HoTen.Text.Contains(x))
                {
                    MessageBox.Show("Họ tên không hợp lệ!");
                    return;
                }
            }

            foreach (var x in invalid_sdt)
            {
                if (DienThoai.Text.Contains(x))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    return;
                }
            }

            if (DienThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số!");
                return;
            }

            if (DienThoai.Text[0] != '0')
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            foreach (char x in DienThoai.Text)
            {
                if (char.IsLetter(x))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    return;
                }
            }

            float test = 0;
            if (!float.TryParse(DiemToan.Text.Trim(), out test))
            {
                MessageBox.Show("Điểm Toán không hợp lệ!");
                return;
            }
            else if (test < 0 || test > 10)
            {
                MessageBox.Show("Điểm Toán nằm trong khoảng [0;10]");
                return;
            }

            if (!float.TryParse(DiemVan.Text.Trim(), out test))
            {
                MessageBox.Show("Điểm Văn không hợp lệ!");
                return;
            }
            else if (test < 0 || test > 10)
            {
                MessageBox.Show("Điểm Văn nằm trong khoảng [0;10]");
                return;
            }

            

            HocVien hocVien = new HocVien
            {
                MSSV = MSSV.Text,
                HoTen = HoTen.Text,
                DienThoai = DienThoai.Text,
                DiemToan = float.Parse(DiemToan.Text),
                DiemVan = float.Parse(DiemVan.Text)
            };

            hocVienarray.Add(hocVien);
           
            using (FileStream fileStream = new FileStream("C:\\TLHT\\HK2_2023-2024\\LapTrinhMangCanBan\\TH\\LAB2\\Lab2\\inputb4.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fileStream, hocVienarray);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<HocVien> hocVienarrayout = new List<HocVien>();
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("C:\\TLHT\\HK2_2023-2024\\LapTrinhMangCanBan\\TH\\LAB2\\Lab2\\inputb4.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fs = new FileStream("C:\\TLHT\\HK2_2023-2024\\LapTrinhMangCanBan\\TH\\LAB2\\Lab2\\outputb4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {

                    hocVienarrayout = (List<HocVien>)bf.Deserialize(fileStream);
                    for (int i = 0; i < hocVienarrayout.Count; i++)
                    {
                        hocVienarrayout[i].DTB = (float)(hocVienarrayout[i].DiemToan + hocVienarrayout[i].DiemVan) / 2;
                    }
                    bf.Serialize(fs, hocVienarrayout);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<HocVien> hocVienarrayout = new List<HocVien>();
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\TLHT\\HK2_2023-2024\\LapTrinhMangCanBan\\TH\\LAB2\\Lab2\\outputb4.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                richTextBox1.Text = "";
                hocVienarrayout = (List<HocVien>)bf.Deserialize(fs);
                for (int i = 0; i < hocVienarrayout.Count; i++)
                {
                    richTextBox1.AppendText(hocVienarrayout[i].MSSV);
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText(hocVienarrayout[i].HoTen);
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText(hocVienarrayout[i].DienThoai);
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText(hocVienarrayout[i].DiemToan.ToString());
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText(hocVienarrayout[i].DiemVan.ToString());
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText(hocVienarrayout[i].DTB.ToString());
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText("\n");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
