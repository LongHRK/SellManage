using System;


using System.Windows.Forms;

namespace StudentManage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát","Thông báo",
                MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
                txtuser.Text = "";
                txtpass.Text = "";
                Home fh = new Home();
                this.Hide();
                fh.ShowDialog();
                this.Show();
        }
    }
}
