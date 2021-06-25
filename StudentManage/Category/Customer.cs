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

namespace StudentManage.Category
{
    public partial class Customer : Form
    {
        DataTable table;
        public Customer()
        {
            InitializeComponent();
        }
        private void bntclosecustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            txtidcustomer.Enabled = false;
            bntskipcustomer.Enabled = false;
            bntsavecustomer.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql = @"Select * from tblCustomer";
            table = Class_General.General.GetDataToDatatable(sql);
            dgvshowcustomer.DataSource = table;
            dgvshowcustomer.Columns[0].HeaderText = "Mã khách hàng";
            dgvshowcustomer.Columns[1].HeaderText = "Tên khách hàng";
            dgvshowcustomer.Columns[2].HeaderText = "Địa chỉ";
            dgvshowcustomer.Columns[3].HeaderText = "Điện thoại";
            dgvshowcustomer.AllowUserToAddRows = false;
            dgvshowcustomer.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvshowcustomer_Click(object sender, EventArgs e)
        {
            if (bntaddcustomer.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidcustomer.Focus();
                return;
            }
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtidcustomer.Text = dgvshowcustomer.CurrentRow.Cells[0].Value.ToString();
            txtnamecustomer.Text = dgvshowcustomer.CurrentRow.Cells[1].Value.ToString();
            txtaddresscustomer.Text = dgvshowcustomer.CurrentRow.Cells[2].Value.ToString();
            txtphonecustomer.Text = dgvshowcustomer.CurrentRow.Cells[3].Value.ToString();
            bntupdatecustomer.Enabled = true;
            bntderelecustomer.Enabled = true;
            bntskipcustomer.Enabled = true;
        }

        private void bntaddcustomer_Click(object sender, EventArgs e)
        {
            bntupdatecustomer.Enabled = false;
            bntderelecustomer.Enabled = false;
            bntskipcustomer.Enabled = true;
            bntsavecustomer.Enabled = true;
            bntaddcustomer.Enabled = false;
            ResetValues();
            txtidcustomer.Enabled = true;
            txtidcustomer.Focus();
        }

        private void ResetValues()
        {
            txtidcustomer.Text = "";
            txtnamecustomer.Text = "";
            txtaddresscustomer.Text = "";
            txtphonecustomer.Text = "";
        }

        private void bntsavecustomer_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtidcustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidcustomer.Focus();
                return;
            }
            if (txtnamecustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnamecustomer.Focus();
                return;
            }
            if (txtaddresscustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtaddresscustomer.Focus();
                return;
            }
            if (txtphonecustomer.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtphonecustomer.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "SELECT IDCustomer FROM tblCustomer WHERE IDCustomer=N'" + txtidcustomer.Text.Trim() + "'";
            if (Class_General.General.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidcustomer.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO tblCustomer VALUES (N'" + txtidcustomer.Text.Trim() +
                "',N'" + txtnamecustomer.Text.Trim() + "',N'" + txtaddresscustomer.Text.Trim() + "','" + txtphonecustomer.Text + "')";
            Class_General.General.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            bntderelecustomer.Enabled = true;
            bntaddcustomer.Enabled = true;
            bntupdatecustomer.Enabled = true;
            bntskipcustomer.Enabled = false;
            bntsavecustomer.Enabled = false;
            txtidcustomer.Enabled = false;
        }

        private void bntupdatecustomer_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtidcustomer.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtnamecustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnamecustomer.Focus();
                return;
            }
            if (txtaddresscustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtaddresscustomer.Focus();
                return;
            }
            if (txtphonecustomer.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtphonecustomer.Focus();
                return;
            }
            sql = "UPDATE tblCustomer SET NameCustomer=N'" + txtnamecustomer.Text.Trim().ToString() + "',AddressCustomer=N'" +
                txtaddresscustomer.Text.Trim().ToString() + "',PhoneCustomer='" + txtphonecustomer.Text.ToString() +
                "' WHERE IDCustomer=N'" + txtidcustomer.Text + "'";
            Class_General.General.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            bntskipcustomer.Enabled = false;
        }

        private void bntderelecustomer_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtidcustomer.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblCustomer WHERE IDCustomer=N'" + txtidcustomer.Text + "'";
                Class_General.General.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void bntskipcustomer_Click(object sender, EventArgs e)
        {
            ResetValues();
            bntskipcustomer.Enabled = false;
            bntaddcustomer.Enabled = true;
            bntderelecustomer.Enabled = true;
            bntupdatecustomer.Enabled = true;
            bntsavecustomer.Enabled = false;
            txtidcustomer.Enabled = false;
        }
    }
}
