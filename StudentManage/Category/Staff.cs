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
    public partial class Staff : Form
    {
        private DataTable table;
        public Staff()
        {
            InitializeComponent();
        }

        private void bntclosestaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            txtidstaff.Enabled = false;
            bntsavestaff.Enabled = false;
            bntskipstaff.Enabled = false;
            LoadDataGridview();
        }
        private void LoadDataGridview()
        {
            string sql = @"Select * from tblStaff";
            table = Class_General.General.GetDataToDatatable(sql);
            dgvshowstaff.DataSource = table;
            dgvshowstaff.Columns[0].HeaderText = "Mã nhân viên";
            dgvshowstaff.Columns[1].HeaderText = "Tên nhân viên";
            dgvshowstaff.Columns[2].HeaderText = "Giới tính";
            dgvshowstaff.Columns[3].HeaderText = "Địa chỉ";
            dgvshowstaff.Columns[4].HeaderText = "Điện thoại";
            dgvshowstaff.Columns[5].HeaderText = "Ngày sinh";
            dgvshowstaff.AllowUserToAddRows = false;
            dgvshowstaff.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvshowstaff_Click(object sender, EventArgs e)
        {
            if (bntaddstaff.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidstaff.Focus();
                return;
            }
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtidstaff.Text = dgvshowstaff.CurrentRow.Cells[0].Value.ToString();
            txtnamestaff.Text = dgvshowstaff.CurrentRow.Cells[1].Value.ToString();
            if (dgvshowstaff.CurrentRow.Cells[2].Value.ToString() == "Nam") cbsexstaff.Checked = true;
            else cbsexstaff.Checked = false;
            textaddresstaff.Text = dgvshowstaff.CurrentRow.Cells[3].Value.ToString();
            textphonestaff.Text = dgvshowstaff.CurrentRow.Cells[4].Value.ToString();
            dtbirthdaystaff.Text = dgvshowstaff.CurrentRow.Cells[5].Value.ToString();
            bntupdatestaff.Enabled = true;
            bntderelestaff.Enabled = true;
        }

        private void bntaddstaff_Click(object sender, EventArgs e)
        {
            bntderelestaff.Enabled = false;
            bntupdatestaff.Enabled = false;
            bntsavestaff.Enabled = true;
            bntskipstaff.Enabled = true;
            bntaddstaff.Enabled = false;
            ResetValues();
            txtidstaff.Enabled = true;
            txtidstaff.Focus();
        }
        private void ResetValues()
        {
            txtidstaff.Text = "";
            txtnamestaff.Text = "";
            cbsexstaff.Checked = false;
            textaddresstaff.Text = "";
            textphonestaff.Text = "";
            dtbirthdaystaff.Text = "";
        }

        private void bntsavestaff_Click(object sender, EventArgs e)
        {
            string sql, sex;
            if (txtidstaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtidstaff.Focus();
                return;
            }
            if (txtnamestaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnamestaff.Focus();
                return;
            }
            if (textaddresstaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textaddresstaff.Focus();
                return;
            }
            if (textphonestaff.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textphonestaff.Focus();
                return;
            }
            if (dtbirthdaystaff.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtbirthdaystaff.Focus();
                return;
            }

            if (cbsexstaff.Checked == true)
                sex = "Nam";
            else
                sex = "Nữ";
            sql = "SELECT IDStaff FROM tblStaff WHERE IDStaff=N'" + txtidstaff.Text.Trim() + "'";
            if (Class_General.General.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtidstaff.Focus();
                txtidstaff.Text = "";
                return;
            }
            sql = "INSERT INTO tblStaff VALUES (N'" +
                txtidstaff.Text.Trim() + "',N'" + txtnamestaff.Text.Trim() + "',N'" + sex + "',N'" + textaddresstaff.Text.Trim() + "','" + textphonestaff.Text + "','" + dtbirthdaystaff.Value + "')";
            Class_General.General.RunSQL(sql);
            LoadDataGridview();
            ResetValues();
            bntderelestaff.Enabled = true;
            bntaddstaff.Enabled = true;
            bntupdatestaff.Enabled = true;
            bntskipstaff.Enabled = false;
            bntsavestaff.Enabled = false;
            txtidstaff.Enabled = false;
        }

        private void bntupdatestaff_Click(object sender, EventArgs e)
        {
            string sql, sex;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtidstaff.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtnamestaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnamestaff.Focus();
                return;
            }
            if (textaddresstaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textaddresstaff.Focus();
                return;
            }
            if (textphonestaff.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textphonestaff.Focus();
                return;
            }
            if (cbsexstaff.Checked == true)
                sex = "Nam";
            else
                sex = "Nữ";
            sql = "UPDATE tblStaff SET  NameStaff=N'" + txtnamestaff.Text.Trim().ToString() +
                    "',AddressStaff=N'" + textaddresstaff.Text.Trim().ToString() +
                    "',PhoneStaff='" + textphonestaff.Text.ToString() +
                    "',SexStaff=N'" + sex +
                    "',BirthdayStaff='" + dtbirthdaystaff.Value.ToString() +
                    "' WHERE IDStaff=N'" + txtidstaff.Text + "'";
            Class_General.General.RunSQL(sql);
            LoadDataGridview();
            ResetValues();
            bntskipstaff.Enabled = false;
        }

        private void bntderelestaff_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtidstaff.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblStaff WHERE IDStaff=N'" + txtidstaff.Text + "'";
                Class_General.General.RunSQL(sql);
                LoadDataGridview();
                ResetValues();
            }
        }

        private void bntskipstaff_Click(object sender, EventArgs e)
        {
            ResetValues();
            bntskipstaff.Enabled = false;
            bntaddstaff.Enabled = true;
            bntderelestaff.Enabled = true;
            bntupdatestaff.Enabled = true;
            bntsavestaff.Enabled = false;
            txtidstaff.Enabled = false;
        }
    }
}
