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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            DirectoryInfo di = new DirectoryInfo("C:\\TLHT\\HK2_2023-2024\\LapTrinhMangCanBan\\Slide");
            FileInfo[] fi = di.GetFiles();
            listView1.View = View.Details;
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            colHead.Width = 120;
            listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Size";
            colHead.Width = 100;
            listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Extention";
            colHead.Width = 100;
            listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Time";
            colHead.Width = 200;
            listView1.Columns.Add(colHead);
            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            foreach (FileInfo fi2 in fi)
            {
                ListViewItem lvi = new ListViewItem();
                /*ListViewItem.ListViewSubItem lvsi;
                lvi = new ListViewItem();
                lvi.Text = fi2.Name;
                lvi.ImageIndex = 1;
                lvi.Tag = fi2.FullName;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = fi2.Length.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = fi2.LastAccessTime.ToString();
                lvi.SubItems.Add(lvsi);*/
                lvi.Text = fi2.Name;
                lvi.SubItems.Add(fi2.Length.ToString());
                lvi.SubItems.Add(fi2.Extension);
                lvi.SubItems.Add(fi2.CreationTime.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
