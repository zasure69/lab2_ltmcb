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
            DirectoryInfo di = new DirectoryInfo("D:\\code");
            FileInfo[] fi = di.GetFiles();
            ColumnHeader colHead;
            
            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            listView1.Columns.Add(colHead);
      
            colHead = new ColumnHeader();
            colHead.Text = "Size";
            listView1.Columns.Add(colHead); 
      
            colHead = new ColumnHeader();
            colHead.Text = "Last accessed";
            listView1.Columns.Add(colHead);
            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            foreach (FileInfo fi2 in fi) {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                lvi = new ListViewItem();
                lvi.Text = fi2.Name;
                lvi.ImageIndex = 1;
                lvi.Tag = fi2.FullName;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = fi2.Length.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = fi2.LastAccessTime.ToString();
                lvi.SubItems.Add(lvsi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
