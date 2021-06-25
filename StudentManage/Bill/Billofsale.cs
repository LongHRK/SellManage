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
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;


namespace StudentManage.Bill
{
    public partial class Billofsale : Form
    {
        DataTable table;
        public Billofsale()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Billofsale_Load(object sender, EventArgs e)
        {
            bntAdd.Enabled = true;
            bntSave.Enabled = false;
            bntCancel.Enabled = false;
            bntprint.Enabled = false;
            txtIDBill.ReadOnly = true;
            txtNameStaff.ReadOnly = true;
            txtNameCustomer.ReadOnly = true;
            txtAddress.ReadOnly = true;
            mkPhone.ReadOnly = true;
            txtNameItems.ReadOnly = true;
            txtBillPrice.ReadOnly = true;
            txtintomoney.ReadOnly = true;
            txttotalmoney.ReadOnly = true;
            txtDiscount.Text = "0";
            txttotalmoney.Text = "0";
            Class_General.General.FillCombobox("SELECT IDCustomer, NameCustomer FROM tblCustomer", cbIDCustomer, "IDCustomer", "IDCustomer");
            cbIDCustomer.SelectedIndex = -1;
            Class_General.General.FillCombobox("SELECT IDStaff, NameStaff FROM tblStaff", cbIDStaff, "IDStaff", "IDStaff");
            cbIDStaff.SelectedIndex = -1;
            Class_General.General.FillCombobox("SELECT IDItems, NameItems FROM tblItems", cbIDItems, "IDItems", "IDItems");
            cbIDItems.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtIDBill.Text != "")
            {
                LoadInfoBill();
                bntCancel.Enabled = true;
                bntprint.Enabled = true;
            }
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT A.IDItems, B.NameItems, A.Amount,  B.Billpriceimport, A.Discount, A.TotalMoney FROM tblDetailBill AS A, tblItems AS B WHERE A.IDBillSell = N'" + txtIDBill.Text + "' AND A.IDItems=B.IDItems";
            table = Class_General.General.GetDataToDatatable(sql);
            dgvshowBillSell.DataSource = table;
            dgvshowBillSell.Columns[0].HeaderText = "Mã hàng";
            dgvshowBillSell.Columns[1].HeaderText = "Tên hàng";
            dgvshowBillSell.Columns[2].HeaderText = "Số lượng";
            dgvshowBillSell.Columns[3].HeaderText = "Đơn giá";
            dgvshowBillSell.Columns[4].HeaderText = "Giảm giá %";
            dgvshowBillSell.Columns[5].HeaderText = "Thành tiền";
            dgvshowBillSell.AllowUserToAddRows = false;
            dgvshowBillSell.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadInfoBill()
        {
            string str = "SELECT SellTime FROM tblBillSell WHERE IDBillSell = N'" + txtIDBill.Text + "'";
            dtDateSell.Value = DateTime.Parse(Class_General.General.GetFieldValues(str));
            str = "SELECT IDStaff FROM tblBillSell WHERE IDBillSell = N'" + txtIDBill.Text + "'";
            cbIDStaff.Text = Class_General.General.GetFieldValues(str);
            str = "SELECT IDCustomer FROM tblBillSell WHERE IDBillSell = N'" + txtIDBill.Text + "'";
            cbIDCustomer.Text = Class_General.General.GetFieldValues(str);
            str = "SELECT Total FROM tblBillSell WHERE IDBillSell = N'" + txtIDBill.Text + "'";
            txttotalmoney.Text = Class_General.General.GetFieldValues(str);
            lbmoneytext.Text = "Bằng chữ: " + Class_General.General.ConvertNumbertotext(double.Parse(txttotalmoney.Text));
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            bntCancel.Enabled = false;
            bntSave.Enabled = true;
            bntprint.Enabled = false;
            bntAdd.Enabled = false;
            ResetValues();
            txtIDBill.Text = Class_General.General.CreateKey("Bill ");
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtIDBill.Text = "";
            dtDateSell.Value = DateTime.Now;
            cbIDStaff.Text = "";
            cbIDCustomer.Text = "";
            txttotalmoney.Text = "0";
            lbmoneytext.Text = "Bằng chữ: ";
            cbIDItems.Text = "";
            txtamount.Text = "";
            txtDiscount.Text = "0";
            txtintomoney.Text = "0";
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            string sql = "SELECT IDBillSell FROM tblBillSell WHERE IDBillSell=N'" + txtIDBill.Text + "'";
            double Amount, AmountRest, total, NewTotal;
            if (!Class_General.General.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (cbIDStaff.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbIDStaff.Focus();
                    return;
                }
                if (cbIDCustomer.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbIDCustomer.Focus();
                    return;
                }
                sql = "INSERT INTO tblBillSell VALUES (N'" + txtIDBill.Text.Trim() + "','" +
                        cbIDStaff.SelectedValue + "',N'" + dtDateSell.Value + "',N'" +
                        cbIDCustomer.SelectedValue + "'," + txttotalmoney.Text + ")";
                Class_General.General.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cbIDItems.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbIDItems.Focus();
                return;
            }
            if ((txtamount.Text.Trim().Length == 0) || (txtamount.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtamount.Text = "";
                txtamount.Focus();
                return;
            }
            if (txtDiscount.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Focus();
                return;
            }
            sql = "SELECT IDItems FROM tblDetailBill WHERE IDItems=N'" + cbIDItems.SelectedValue + "' AND IDBillSell = N'" + txtIDBill.Text.Trim() + "'";
            if (Class_General.General.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesItems();
                cbIDItems.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            Amount = Convert.ToDouble(Class_General.General.GetFieldValues("SELECT amount FROM tblItems WHERE IDItems = N'" + cbIDItems.SelectedValue + "'"));
            if (Convert.ToDouble(txtamount.Text) > Amount)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + Amount, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtamount.Text = "";
                txtamount.Focus();
                return;
            }
            sql = "INSERT INTO tblDetailBill VALUES(N'" + txtIDBill.Text.Trim() + "',N'" + cbIDItems.SelectedValue + "'," + txtamount.Text + "," + txtBillPrice.Text + "," + txtDiscount.Text + "," + txtintomoney.Text + ")";
            Class_General.General.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng
            AmountRest = Amount - Convert.ToDouble(txtamount.Text);
            sql = "UPDATE tblItems SET amount =" + AmountRest + " WHERE IDItems= N'" + cbIDItems.SelectedValue + "'";
            Class_General.General.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            total = Convert.ToDouble(Class_General.General.GetFieldValues("SELECT Total FROM tblBillSell WHERE IDBillSell = N'" + txtIDBill.Text + "'"));
            NewTotal = total + Convert.ToDouble(txtintomoney.Text);
            sql = "UPDATE tblBillSell SET Total =" + NewTotal + " WHERE IDBillSell = N'" + txtIDBill.Text + "'";
            Class_General.General.RunSQL(sql);
            txttotalmoney.Text = NewTotal.ToString();
            lbmoneytext.Text = "Bằng chữ: " + Class_General.General.ConvertNumbertotext(NewTotal);
            ResetValuesItems();
            bntCancel.Enabled = true;
            bntAdd.Enabled = true;
            bntprint.Enabled = true;
        }

        private void ResetValuesItems()
        {
            cbIDItems.Text = "";
            txtamount.Text = "";
            txtDiscount.Text = "0";
            txtintomoney.Text = "0";
        }

        private void cbIDCustomer_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbIDCustomer.Text == "")
            {
                txtNameCustomer.Text = "";
                txtAddress.Text = "";
                mkPhone.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select NameCustomer from tblCustomer where IDCustomer = N'" + cbIDCustomer.SelectedValue + "'";
            txtNameCustomer.Text = Class_General.General.GetFieldValues(str);
            str = "Select AddressCustomer from tblCustomer where IDCustomer = N'" + cbIDCustomer.SelectedValue + "'";
            txtAddress.Text = Class_General.General.GetFieldValues(str);
            str = "Select PhoneCustomer from tblCustomer where IDCustomer= N'" + cbIDCustomer.SelectedValue + "'";
            mkPhone.Text = Class_General.General.GetFieldValues(str);
        }

        private void cbIDStaff_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbIDStaff.Text == "")
                txtNameStaff.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select NameStaff from tblStaff where IDStaff =N'" + cbIDStaff.SelectedValue + "'";
            txtNameStaff.Text = Class_General.General.GetFieldValues(str);
        }

        private void cbIDItems_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbIDItems.Text == "")
            {
                txtNameItems.Text = "";
                txtBillPrice.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT NameItems FROM tblItems WHERE IDItems =N'" + cbIDItems.SelectedValue + "'";
            txtNameItems.Text = Class_General.General.GetFieldValues(str);
            str = "SELECT BillPrice FROM tblItems WHERE IDItems =N'" + cbIDItems.SelectedValue + "'";
            txtBillPrice.Text = Class_General.General.GetFieldValues(str);
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double total, amount, price, discount;
            if (txtamount.Text == "")
                amount = 0;
            else
                amount = Convert.ToDouble(txtamount.Text);
            if (txtDiscount.Text == "")
                discount = 0;
            else
                discount = Convert.ToDouble(txtDiscount.Text);
            if (txtBillPrice.Text == "")
                price = 0;
            else
                price = Convert.ToDouble(txtBillPrice.Text);
            total = amount * price - amount * price * discount / 100;
            txtintomoney.Text = total.ToString();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double total, amount, price, discount;
            if (txtamount.Text == "")
                amount = 0;
            else
                amount = Convert.ToDouble(txtamount.Text);
            if (txtDiscount.Text == "")
                discount = 0;
            else
                discount = Convert.ToDouble(txtDiscount.Text);
            if (txtBillPrice.Text == "")
                price = 0;
            else
                price = Convert.ToDouble(txtBillPrice.Text);
            total = amount * price - amount * price * discount / 100;
            txtintomoney.Text = total.ToString();
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void Billofsale_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void cbIDBill_DropDown(object sender, EventArgs e)
        {
            Class_General.General.FillCombobox("SELECT IDBillSell FROM tblBillSell", cbIDBill, "IDBillSell", "IDBillSell");
            cbIDBill.SelectedIndex = -1;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            if (cbIDBill.Text == "")
            {
                MessageBox.Show("bạn phải chọn một mã hóa đơn để tìm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbIDBill.Focus();
                return;
            }
            txtIDBill.Text = cbIDBill.Text;
            LoadInfoBill();
            LoadDataGridView();
            bntCancel.Enabled = true;
            bntSave.Enabled = true;
            bntprint.Enabled = true;
            cbIDBill.SelectedIndex = -1;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            double amount, amountrest, amountdelete;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT IDItems,amount FROM tblDetailBill WHERE IDBillSell = N'" + txtIDBill.Text + "'";
                DataTable tblitems = Class_General.General.GetDataToDatatable(sql);
                for (int items = 0; items <= tblitems.Rows.Count - 1; items++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    amount = Convert.ToDouble(Class_General.General.GetFieldValues("SELECT amount FROM tblItems WHERE IDItems = N'" + tblitems.Rows[items][0].ToString() + "'"));
                    amountdelete = Convert.ToDouble(tblitems.Rows[items][1].ToString());
                    amountrest = amount + amountdelete;
                    sql = "UPDATE tblItems SET amount =" + amountrest + " WHERE IDItems= N'" + tblitems.Rows[items][0].ToString() + "'";
                    Class_General.General.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblDetailBill WHERE IDBillSell=N'" + txtIDBill.Text + "'";
                Class_General.General.RunSQL(sql);

                //Xóa hóa đơn
                sql = "DELETE tblBillSell WHERE IDBillSell=N'" + txtIDBill.Text + "'";
                Class_General.General.RunSQL(sql);
                ResetValues();
                LoadDataGridView();
                bntCancel.Enabled = false;
                bntprint.Enabled = false;
            }
        }

        private void dgvshowBillSell_DoubleClick(object sender, EventArgs e)
        {
            string IDItemsDelete, sql;
            double IntoMonetDelete, AmountDelete, Amount, AmountRest, Total, NewTotal;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                IDItemsDelete = dgvshowBillSell.CurrentRow.Cells[0].Value.ToString();
                AmountDelete = Convert.ToDouble(dgvshowBillSell.CurrentRow.Cells[2].Value.ToString());
                IntoMonetDelete = Convert.ToDouble(dgvshowBillSell.CurrentRow.Cells[5].Value.ToString());
                sql = "DELETE tblDetailBill WHERE IDBillSell=N'" + txtIDBill.Text + "' AND IDItems = N'" + IDItemsDelete + "'";
                Class_General.General.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                Amount = Convert.ToDouble(Class_General.General.GetFieldValues("SELECT amount FROM tblItems WHERE IDItems = N'" + IDItemsDelete + "'"));
                AmountRest = Amount + AmountDelete;
                sql = "UPDATE tblItems SET amount =" + AmountRest + " WHERE IDItems= N'" + IDItemsDelete + "'";
                Class_General.General.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                Total = Convert.ToDouble(Class_General.General.GetFieldValues("SELECT total FROM tblBillSell WHERE IDBillSell = N'" + txtIDBill.Text + "'"));
                NewTotal = Total - IntoMonetDelete;
                sql = "UPDATE tblBillSell SET total =" + NewTotal + " WHERE IDBillSell = N'" + txtIDBill.Text + "'";
                Class_General.General.RunSQL(sql);
                txttotalmoney.Text = NewTotal.ToString();
                lbmoneytext.Text = "Bằng chữ: " + Class_General.General.ConvertNumbertotext(NewTotal);
                LoadDataGridView();
            }
        }
    }
}

//Đang gặp lỗi tại hàm LoadInfoBill 
//chưa xong phần yimf kiếm 
/*phần cần làm tiếp theo là bắt sụ kiện dounleclick 
vào DGV để xóa sản phẩm và BTN In hóa đơn ra file Excel */