namespace StudentManage.Category
{
    partial class Material
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
            this.txtnamematerial = new System.Windows.Forms.TextBox();
            this.txtidmaterial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bntclosematerial = new System.Windows.Forms.Button();
            this.bntskipmaterial = new System.Windows.Forms.Button();
            this.bntsavematerial = new System.Windows.Forms.Button();
            this.bntupdatematerial = new System.Windows.Forms.Button();
            this.bntdeltematerial = new System.Windows.Forms.Button();
            this.bntaddmayrtial = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvshowmaterial = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowmaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 54);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(414, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục chất liệu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtnamematerial);
            this.panel2.Controls.Add(this.txtidmaterial);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(20, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 121);
            this.panel2.TabIndex = 2;
            // 
            // txtnamematerial
            // 
            this.txtnamematerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamematerial.Location = new System.Drawing.Point(202, 71);
            this.txtnamematerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnamematerial.Name = "txtnamematerial";
            this.txtnamematerial.Size = new System.Drawing.Size(928, 22);
            this.txtnamematerial.TabIndex = 8;
            // 
            // txtidmaterial
            // 
            this.txtidmaterial.Enabled = false;
            this.txtidmaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidmaterial.Location = new System.Drawing.Point(202, 14);
            this.txtidmaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidmaterial.Name = "txtidmaterial";
            this.txtidmaterial.Size = new System.Drawing.Size(928, 22);
            this.txtidmaterial.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên chất liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã chất liệu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bntclosematerial);
            this.panel5.Controls.Add(this.bntskipmaterial);
            this.panel5.Controls.Add(this.bntsavematerial);
            this.panel5.Controls.Add(this.bntupdatematerial);
            this.panel5.Controls.Add(this.bntdeltematerial);
            this.panel5.Controls.Add(this.bntaddmayrtial);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(18, 494);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1158, 46);
            this.panel5.TabIndex = 6;
            // 
            // bntclosematerial
            // 
            this.bntclosematerial.Location = new System.Drawing.Point(962, 5);
            this.bntclosematerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntclosematerial.Name = "bntclosematerial";
            this.bntclosematerial.Size = new System.Drawing.Size(182, 37);
            this.bntclosematerial.TabIndex = 5;
            this.bntclosematerial.Text = "Đóng";
            this.bntclosematerial.UseVisualStyleBackColor = true;
            this.bntclosematerial.Click += new System.EventHandler(this.bntclosematerial_Click);
            // 
            // bntskipmaterial
            // 
            this.bntskipmaterial.Enabled = false;
            this.bntskipmaterial.Location = new System.Drawing.Point(771, 5);
            this.bntskipmaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntskipmaterial.Name = "bntskipmaterial";
            this.bntskipmaterial.Size = new System.Drawing.Size(182, 37);
            this.bntskipmaterial.TabIndex = 4;
            this.bntskipmaterial.Text = "Bỏ qua";
            this.bntskipmaterial.UseVisualStyleBackColor = true;
            this.bntskipmaterial.Click += new System.EventHandler(this.bntskipmaterial_Click);
            // 
            // bntsavematerial
            // 
            this.bntsavematerial.Enabled = false;
            this.bntsavematerial.Location = new System.Drawing.Point(580, 5);
            this.bntsavematerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntsavematerial.Name = "bntsavematerial";
            this.bntsavematerial.Size = new System.Drawing.Size(182, 37);
            this.bntsavematerial.TabIndex = 3;
            this.bntsavematerial.Text = "Lưu";
            this.bntsavematerial.UseVisualStyleBackColor = true;
            this.bntsavematerial.Click += new System.EventHandler(this.bntsavematerial_Click);
            // 
            // bntupdatematerial
            // 
            this.bntupdatematerial.Location = new System.Drawing.Point(390, 5);
            this.bntupdatematerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntupdatematerial.Name = "bntupdatematerial";
            this.bntupdatematerial.Size = new System.Drawing.Size(182, 37);
            this.bntupdatematerial.TabIndex = 2;
            this.bntupdatematerial.Text = "Sửa";
            this.bntupdatematerial.UseVisualStyleBackColor = true;
            this.bntupdatematerial.Click += new System.EventHandler(this.bntupdatematerial_Click);
            // 
            // bntdeltematerial
            // 
            this.bntdeltematerial.Location = new System.Drawing.Point(200, 5);
            this.bntdeltematerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntdeltematerial.Name = "bntdeltematerial";
            this.bntdeltematerial.Size = new System.Drawing.Size(182, 37);
            this.bntdeltematerial.TabIndex = 1;
            this.bntdeltematerial.Text = "Xóa";
            this.bntdeltematerial.UseVisualStyleBackColor = true;
            this.bntdeltematerial.Click += new System.EventHandler(this.bntdeltematerial_Click);
            // 
            // bntaddmayrtial
            // 
            this.bntaddmayrtial.Location = new System.Drawing.Point(9, 5);
            this.bntaddmayrtial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntaddmayrtial.Name = "bntaddmayrtial";
            this.bntaddmayrtial.Size = new System.Drawing.Size(182, 37);
            this.bntaddmayrtial.TabIndex = 0;
            this.bntaddmayrtial.Text = "Thêm";
            this.bntaddmayrtial.UseVisualStyleBackColor = true;
            this.bntaddmayrtial.Click += new System.EventHandler(this.bntaddmayrtial_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvshowmaterial);
            this.panel4.Location = new System.Drawing.Point(18, 242);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1162, 244);
            this.panel4.TabIndex = 5;
            // 
            // dgvshowmaterial
            // 
            this.dgvshowmaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvshowmaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshowmaterial.Location = new System.Drawing.Point(-2, 0);
            this.dgvshowmaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvshowmaterial.Name = "dgvshowmaterial";
            this.dgvshowmaterial.Size = new System.Drawing.Size(1160, 240);
            this.dgvshowmaterial.TabIndex = 0;
            this.dgvshowmaterial.Click += new System.EventHandler(this.dgvshowmaterial_Click);
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Material";
            this.Text = "Quản lý chất liệu";
            this.Load += new System.EventHandler(this.Material_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowmaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnamematerial;
        private System.Windows.Forms.TextBox txtidmaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bntclosematerial;
        private System.Windows.Forms.Button bntskipmaterial;
        private System.Windows.Forms.Button bntsavematerial;
        private System.Windows.Forms.Button bntupdatematerial;
        private System.Windows.Forms.Button bntdeltematerial;
        private System.Windows.Forms.Button bntaddmayrtial;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvshowmaterial;
    }
}