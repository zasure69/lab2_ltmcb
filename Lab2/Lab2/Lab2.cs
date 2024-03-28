using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.ShowDialog();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.ShowDialog();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Bai4 b4 = new Bai4();
            b4.ShowDialog();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Bai5 b5 = new Bai5();
            b5.ShowDialog();
        }
    }
}
