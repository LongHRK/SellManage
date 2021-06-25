using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManage.Category
{
    public partial class Items : Form
    {
        DataTable table;
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * from tblMaterial";
            txtiditems.Enabled = false;
            bntsaveitems.Enabled = false;
            bntskipitems.Enabled = false;
            LoadDataGridView();
            Class_General.General.FillCombobox(sql, cbidmaterialofitems, "IDMaterial", "NameMaterial");
            cbidmaterialofitems.SelectedIndex = -1;
            ResetValues();
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT * from tblItems";
            table = Class_General.General.GetDataToDatatable(sql);
            dgvshowitems.DataSource = table;
            dgvshowitems.Columns[0].HeaderText = "Mã hàng";
            dgvshowitems.Columns[1].HeaderText = "Tên hàng";
            dgvshowitems.Columns[2].HeaderText = "Chất liệu";
            dgvshowitems.Columns[3].HeaderText = "Số lượng";
            dgvshowitems.Columns[4].HeaderText = "Đơn giá nhập";
            dgvshowitems.Columns[5].HeaderText = "Đơn giá bán";
            dgvshowitems.Columns[6].HeaderText = "Ảnh";
            dgvshowitems.Columns[7].HeaderText = "Ghi chú";
            dgvshowitems.AllowUserToAddRows = false;
            dgvshowitems.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtiditems.Text = "";
            txtnameitems.Text = "";
            cbidmaterialofitems.Text = "";
            txtamountitems.Text = "0";
            txtimportpriceitems.Text = "0";
            txtpriceitems.Text = "0";
            txtamountitems.Enabled = true;
            txtimportpriceitems.Enabled = false;
            txtpriceitems.Enabled = false;
            txtimageitems.Text = "";
            ptbimageitems.Image = null;
            txtnoteitems.Text = "";
        }

        private void dgvshowitems_Click(object sender, EventArgs e)
        {
            string IDMaterial,sql;
            if (bntadditems.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtiditems.Focus();
                return;
            }
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtiditems.Text = dgvshowitems.CurrentRow.Cells[0].Value.ToString();
            txtnameitems.Text = dgvshowitems.CurrentRow.Cells[1].Value.ToString();
            IDMaterial = dgvshowitems.CurrentRow.Cells[2].Value.ToString();
            sql = "SELECT NameMaterial FROM tblMaterial WHERE IDMaterial=N'" + IDMaterial + "'";
            cbidmaterialofitems.Text = Class_General.General.GetFieldValues(sql);
            txtamountitems.Text = dgvshowitems.CurrentRow.Cells[3].Value.ToString();
            txtimportpriceitems.Text = dgvshowitems.CurrentRow.Cells[4].Value.ToString();
            txtpriceitems.Text = dgvshowitems.CurrentRow.Cells[5].Value.ToString();
            sql = "SELECT Picture FROM tblItems WHERE IDItems=N'" + txtiditems.Text + "'";
            txtimageitems.Text = Class_General.General.GetFieldValues(sql);
            ptbimageitems.Image = Image.FromFile(txtimageitems.Text);
            sql = "SELECT Note FROM tblItems WHERE IDItems = N'" + txtiditems.Text + "'";
            txtnoteitems.Text = Class_General.General.GetFieldValues(sql);
            bntupdateitems.Enabled = true;
            bntdeleteitems.Enabled = true;
            bntskipitems.Enabled = true;
        }

        private void bntadditems_Click(object sender, EventArgs e)
        {
            bntupdateitems.Enabled = false;
            bntdeleteitems.Enabled = false;
            bntskipitems.Enabled = true;
            bntsaveitems.Enabled = true;
            bntadditems.Enabled = false;
            ResetValues();
            txtiditems.Enabled = true;
            txtiditems.Focus();
            txtamountitems.Enabled = true;
            txtimportpriceitems.Enabled = true;
            txtpriceitems.Enabled = true;
        }

        private void bntsaveitems_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtiditems.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtiditems.Focus();
                return;
            }
            if (txtnameitems.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnameitems.Focus();
                return;
            }
            if (cbidmaterialofitems.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbidmaterialofitems.Focus();
                return;
            }
            if (txtimageitems.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bntshowimageitems.Focus();
                return;
            }
            sql = "SELECT IDItems FROM tblItems WHERE IDItems=N'" + txtiditems.Text.Trim() + "'";
            if (Class_General.General.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtiditems.Focus();
                return;
            }
            sql = "INSERT INTO tblItems VALUES(N'"
                + txtiditems.Text.Trim() + "',N'" + txtnameitems.Text.Trim() +
                "',N'" + cbidmaterialofitems.SelectedValue.ToString() +
                "'," + txtamountitems.Text.Trim() + "," + txtimportpriceitems.Text +
                "," + txtpriceitems.Text + ",'" + txtimageitems.Text + "',N'" + txtnoteitems.Text.Trim() + "')";
            Class_General.General.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            bntdeleteitems.Enabled = true;
            bntadditems.Enabled = true;
            bntupdateitems.Enabled = true;
            bntskipitems.Enabled = false;
            bntsaveitems.Enabled = false;
            txtiditems.Enabled = false;
        }

        private void bntshowimageitems_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                ptbimageitems.Image = Image.FromFile(dlgOpen.FileName);
                txtimageitems.Text = dlgOpen.FileName;
            }
        }

        private void bntupdateitems_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtiditems.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtiditems.Focus();
                return;
            }
            if (txtnameitems.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnameitems.Focus();
                return;
            }
            if (cbidmaterialofitems.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbidmaterialofitems.Focus();
                return;
            }
            if (txtimageitems.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtimageitems.Focus();
                return;
            }
            sql = "UPDATE tblItems SET NameItems=N'" + txtnameitems.Text.Trim().ToString() +
                "',IDMaterial=N'" + cbidmaterialofitems.SelectedValue.ToString() +
                "',Amount=" + txtamountitems.Text +
                ",Picture='" + txtimageitems.Text + "',Note=N'" + txtnoteitems.Text + "' WHERE IDItems=N'" + txtiditems.Text + "'";
            Class_General.General.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            bntskipitems.Enabled = false;
        }

        private void bntdeleteitems_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtiditems.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblItems WHERE IDItems=N'" + txtiditems.Text + "'";
                Class_General.General.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void bntskipitems_Click(object sender, EventArgs e)
        {
            ResetValues();
            bntdeleteitems.Enabled = true;
            bntupdateitems.Enabled = true;
            bntadditems.Enabled = true;
            bntskipitems.Enabled = false;
            bntsaveitems.Enabled = false;
            txtiditems.Enabled = false;
        }

        private void bntsearchitems_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtiditems.Text == "") && (txtnameitems.Text == "") && (cbidmaterialofitems.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblItems WHERE 1=1";
            if (txtiditems.Text != "")
                sql += " AND IDItems LIKE N'%" + txtiditems.Text + "%'";
            if (txtnameitems.Text != "")
                sql += " AND NameItems LIKE N'%" + txtnameitems.Text + "%'";
            if (cbidmaterialofitems.Text != "")
                sql += " AND IDMaterial LIKE N'%" + cbidmaterialofitems.SelectedValue + "%'";
            table = Class_General.General.GetDataToDatatable(sql);
            if (table.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + table.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvshowitems.DataSource = table;
            ResetValues();
        }

        private void bntshowitems_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void bntcloseitems_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
