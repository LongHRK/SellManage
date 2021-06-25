namespace StudentManage.Search
{
    partial class SearchBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtidBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtidcustomer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvshowSearchBill = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchSearchBill = new System.Windows.Forms.Button();
            this.btnFindAgainSearchBill = new System.Windows.Forms.Button();
            this.btnCloseSearchBill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowSearchBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 44);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtStaff);
            this.panel2.Controls.Add(this.txtyear);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtmonth);
            this.panel2.Controls.Add(this.txtidBill);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 144);
            this.panel2.TabIndex = 2;
            // 
            // txtmonth
            // 
            this.txtmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(137, 58);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(67, 22);
            this.txtmonth.TabIndex = 4;
            // 
            // txtidBill
            // 
            this.txtidBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidBill.Location = new System.Drawing.Point(137, 11);
            this.txtidBill.Name = "txtidBill";
            this.txtidBill.Size = new System.Drawing.Size(222, 22);
            this.txtidBill.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(234, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Năm";
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(295, 58);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(64, 22);
            this.txtyear.TabIndex = 6;
            // 
            // txtStaff
            // 
            this.txtStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.Location = new System.Drawing.Point(137, 107);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(222, 22);
            this.txtStaff.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txttotal);
            this.panel3.Controls.Add(this.txtidcustomer);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(406, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 144);
            this.panel3.TabIndex = 8;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(137, 58);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(222, 22);
            this.txttotal.TabIndex = 4;
            // 
            // txtidcustomer
            // 
            this.txtidcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidcustomer.Location = new System.Drawing.Point(137, 11);
            this.txtidcustomer.Name = "txtidcustomer";
            this.txtidcustomer.Size = new System.Drawing.Size(222, 22);
            this.txtidcustomer.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(17, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tổng tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(17, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã khách hàng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvshowSearchBill);
            this.panel4.Location = new System.Drawing.Point(12, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 171);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(12, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(775, 39);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCloseSearchBill);
            this.panel6.Controls.Add(this.btnFindAgainSearchBill);
            this.panel6.Controls.Add(this.btnSearchSearchBill);
            this.panel6.Location = new System.Drawing.Point(12, 443);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(775, 57);
            this.panel6.TabIndex = 11;
            // 
            // dgvshowSearchBill
            // 
            this.dgvshowSearchBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshowSearchBill.Location = new System.Drawing.Point(3, 0);
            this.dgvshowSearchBill.Name = "dgvshowSearchBill";
            this.dgvshowSearchBill.Size = new System.Drawing.Size(769, 168);
            this.dgvshowSearchBill.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nháy đúp vào hóa đơn để hiển thị chi tiết";
            // 
            // btnSearchSearchBill
            // 
            this.btnSearchSearchBill.Location = new System.Drawing.Point(137, 3);
            this.btnSearchSearchBill.Name = "btnSearchSearchBill";
            this.btnSearchSearchBill.Size = new System.Drawing.Size(134, 51);
            this.btnSearchSearchBill.TabIndex = 0;
            this.btnSearchSearchBill.Text = "Tìm kiếm";
            this.btnSearchSearchBill.UseVisualStyleBackColor = true;
            // 
            // btnFindAgainSearchBill
            // 
            this.btnFindAgainSearchBill.Location = new System.Drawing.Point(320, 3);
            this.btnFindAgainSearchBill.Name = "btnFindAgainSearchBill";
            this.btnFindAgainSearchBill.Size = new System.Drawing.Size(134, 51);
            this.btnFindAgainSearchBill.TabIndex = 1;
            this.btnFindAgainSearchBill.Text = "Tìm lại";
            this.btnFindAgainSearchBill.UseVisualStyleBackColor = true;
            // 
            // btnCloseSearchBill
            // 
            this.btnCloseSearchBill.Location = new System.Drawing.Point(509, 3);
            this.btnCloseSearchBill.Name = "btnCloseSearchBill";
            this.btnCloseSearchBill.Size = new System.Drawing.Size(134, 51);
            this.btnCloseSearchBill.TabIndex = 2;
            this.btnCloseSearchBill.Text = "Đóng";
            this.btnCloseSearchBill.UseVisualStyleBackColor = true;
            this.btnCloseSearchBill.Click += new System.EventHandler(this.btnCloseSearchBill_Click);
            // 
            // SearchBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SearchBill";
            this.Text = "SearchBill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowSearchBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtidBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtidcustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvshowSearchBill;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCloseSearchBill;
        private System.Windows.Forms.Button btnFindAgainSearchBill;
        private System.Windows.Forms.Button btnSearchSearchBill;
    }
}