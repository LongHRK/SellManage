using StudentManage.Class_General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManage.Category
{
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }
        DataTable table;
        private void bntclosematerial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }
        private void LoadDataGridview()
        {
            string sql = @"Select * from tblMaterial";
            table = General.GetDataToDatatable(sql);
            dgvshowmaterial.DataSource = table;
            dgvshowmaterial.Columns[0].HeaderText = "Mã nguyên lệu";
            dgvshowmaterial.Columns[1].HeaderText = "Tên nguyên lệu";
            dgvshowmaterial.AllowUserToAddRows = false;
            dgvshowmaterial.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void bntaddmayrtial_Click(object sender, EventArgs e)
        {
            bntdeltematerial.Enabled = false;
            bntupdatematerial.Enabled = false;
            bntsavematerial.Enabled = true;
            bntskipmaterial.Enabled = true;
            bntaddmayrtial.Enabled = false;
            ResetValues();
            txtidmaterial.Enabled = true;
            txtidmaterial.Focus();
        }
        void ResetValues()
        {
            txtidmaterial.Text = "";
            txtnamematerial.Text = "";
        }

        private void dgvshowmaterial_Click(object sender, EventArgs e)
        {
            if (bntaddmayrtial.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidmaterial.Focus();
                return;
            }
            if (table.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtidmaterial.Text = dgvshowmaterial.CurrentRow.Cells[0].Value.ToString();
            txtnamematerial.Text = dgvshowmaterial.CurrentRow.Cells[1].Value.ToString();
            bntupdatematerial.Enabled = true;
            bntdeltematerial.Enabled = true;
            bntskipmaterial.Enabled = true;
        }

        private void bntsavematerial_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtidmaterial.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã vật liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidmaterial.Focus();
                return;
            }
            if (txtnamematerial.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên vật liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnamematerial.Focus();
                return;
            }
            sql = "Select IDMaterial From tblMaterial Where IDMaterial = N'" +
                txtidmaterial.Text.Trim() + "'";
            if (General.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "Insert into tblMaterial Values (N'" + txtidmaterial.Text + "',N'"
                +
                txtnamematerial.Text + "')";
            General.RunSQL(sql);
            LoadDataGridview();
            ResetValues();
            bntdeltematerial.Enabled = true;
            bntupdatematerial.Enabled = true;
            bntaddmayrtial.Enabled = true;
            bntskipmaterial.Enabled = false;
            txtidmaterial.Enabled = false;
        }

        private void bntupdatematerial_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (txtidmaterial.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (txtnamematerial.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtnamematerial.Focus();
                return;
            }
            sql = "Update tblMaterial Set NameMaterial =N'" +
                txtnamematerial.Text.ToString() + "' Where IDMaterial = N'" +
                txtidmaterial.Text + "'";
            General.RunSQL(sql);
            LoadDataGridview();
            ResetValues();
            bntskipmaterial.Enabled = false;
        }

        private void bntskipmaterial_Click(object sender, EventArgs e)
        {
            ResetValues();
            bntaddmayrtial.Enabled = true;
            bntdeltematerial.Enabled = true;
            bntupdatematerial.Enabled = true;
            bntsavematerial.Enabled = false;
            bntskipmaterial.Enabled = false;

            txtidmaterial.Enabled = false;
        }

        private void bntdeltematerial_Click(object sender, EventArgs e)
        {
            string sql;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtidmaterial.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblMaterial WHERE IDMaterial=N'" + txtidmaterial.Text + "'";
                General.RunSQL(sql);
                LoadDataGridview();
                ResetValues();
            }
        }
    }
}

