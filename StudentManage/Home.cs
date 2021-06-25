using StudentManage.Bill;
using StudentManage.Category;
using StudentManage.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StudentManage
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff fs = new Staff();
            this.Hide();
            fs.ShowDialog();
            this.Show();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Material fm = new Material();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer fc = new Customer();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items fi = new Items();
            this.Hide();
            fi.ShowDialog();
            this.Show();
        }

        private void đắngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billofsale fb = new Billofsale();
            this.Hide();
            fb.ShowDialog();
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchBill fsb = new SearchBill();
            this.Hide();
            fsb.ShowDialog();
            this.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Class_General.General.Connect();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Class_General.General.Disconnect();
        }
    }
}
