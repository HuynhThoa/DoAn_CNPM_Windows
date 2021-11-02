
namespace DoAn_Demo.UI.UI_Default
{
    partial class UserControlQLLopHoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlQLLOPHOC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachLopHoc = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTTLopHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTenLop = new System.Windows.Forms.ComboBox();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.comboBoxTenLoaiLop = new System.Windows.Forms.ComboBox();
            this.comboBoxGiaoVienCN = new System.Windows.Forms.ComboBox();
            this.textBoxIDLopHoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonXoaLop = new System.Windows.Forms.RadioButton();
            this.radioButtonCapNhat = new System.Windows.Forms.RadioButton();
            this.radioButtonTao = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControlQLLOPHOC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachLopHoc)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTLopHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlQLLOPHOC
            // 
            this.tabControlQLLOPHOC.Controls.Add(this.tabPage1);
            this.tabControlQLLOPHOC.Controls.Add(this.tabPage2);
            this.tabControlQLLOPHOC.Controls.Add(this.tabPage3);
            this.tabControlQLLOPHOC.Location = new System.Drawing.Point(4, 4);
            this.tabControlQLLOPHOC.Name = "tabControlQLLOPHOC";
            this.tabControlQLLOPHOC.SelectedIndex = 0;
            this.tabControlQLLOPHOC.Size = new System.Drawing.Size(1396, 636);
            this.tabControlQLLOPHOC.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewDanhSachLopHoc);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1388, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh Sách Các Lớp Học";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Các Lớp Học";
            // 
            // dataGridViewDanhSachLopHoc
            // 
            this.dataGridViewDanhSachLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewDanhSachLopHoc.Location = new System.Drawing.Point(368, 79);
            this.dataGridViewDanhSachLopHoc.Name = "dataGridViewDanhSachLopHoc";
            this.dataGridViewDanhSachLopHoc.RowHeadersWidth = 51;
            this.dataGridViewDanhSachLopHoc.RowTemplate.Height = 24;
            this.dataGridViewDanhSachLopHoc.Size = new System.Drawing.Size(705, 510);
            this.dataGridViewDanhSachLopHoc.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID Lớp Học";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tên Lớp";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Sĩ Số";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Giáo Viên Chủ Nhiệm";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tên Loại Lớp";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewTTLopHoc);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1388, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Lớp Học";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTTLopHoc
            // 
            this.dataGridViewTTLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTTLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewTTLopHoc.Location = new System.Drawing.Point(515, 50);
            this.dataGridViewTTLopHoc.Name = "dataGridViewTTLopHoc";
            this.dataGridViewTTLopHoc.RowHeadersWidth = 51;
            this.dataGridViewTTLopHoc.RowTemplate.Height = 24;
            this.dataGridViewTTLopHoc.Size = new System.Drawing.Size(867, 529);
            this.dataGridViewTTLopHoc.TabIndex = 1;
            this.dataGridViewTTLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTTLopHoc_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Lớp Học";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Lớp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sĩ Số";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giáo Viên Chủ Nhiệm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Loại Lớp";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.radioButtonXoaLop);
            this.groupBox1.Controls.Add(this.radioButtonCapNhat);
            this.groupBox1.Controls.Add(this.radioButtonTao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lớp Học";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(194, 110);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(241, 27);
            this.textBoxTimKiem.TabIndex = 17;
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBoxTimKiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tìm Kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxTenLop);
            this.panel1.Controls.Add(this.buttonCapNhat);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Controls.Add(this.comboBoxTenLoaiLop);
            this.panel1.Controls.Add(this.comboBoxGiaoVienCN);
            this.panel1.Controls.Add(this.textBoxIDLopHoc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(11, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 383);
            this.panel1.TabIndex = 7;
            // 
            // comboBoxTenLop
            // 
            this.comboBoxTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenLop.FormattingEnabled = true;
            this.comboBoxTenLop.Items.AddRange(new object[] {
            "A ",
            "B ",
            "C",
            " D ",
            "E ",
            "F ",
            "G ",
            "H ",
            "I ",
            "J ",
            "K ",
            "L ",
            "M",
            " N ",
            "O ",
            "P ",
            "Q ",
            "R ",
            "S ",
            "T ",
            "U ",
            "V ",
            "W ",
            "X ",
            "Y ",
            "Z",
            ""});
            this.comboBoxTenLop.Location = new System.Drawing.Point(183, 114);
            this.comboBoxTenLop.Name = "comboBoxTenLop";
            this.comboBoxTenLop.Size = new System.Drawing.Size(241, 28);
            this.comboBoxTenLop.TabIndex = 15;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Enabled = false;
            this.buttonCapNhat.Location = new System.Drawing.Point(168, 323);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(123, 34);
            this.buttonCapNhat.TabIndex = 14;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Enabled = false;
            this.buttonXoa.Location = new System.Drawing.Point(345, 323);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(79, 34);
            this.buttonXoa.TabIndex = 13;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Enabled = false;
            this.buttonThem.Location = new System.Drawing.Point(28, 323);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(82, 34);
            this.buttonThem.TabIndex = 12;
            this.buttonThem.Text = "Tạo";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // comboBoxTenLoaiLop
            // 
            this.comboBoxTenLoaiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenLoaiLop.FormattingEnabled = true;
            this.comboBoxTenLoaiLop.Location = new System.Drawing.Point(183, 261);
            this.comboBoxTenLoaiLop.Name = "comboBoxTenLoaiLop";
            this.comboBoxTenLoaiLop.Size = new System.Drawing.Size(241, 28);
            this.comboBoxTenLoaiLop.TabIndex = 11;
            // 
            // comboBoxGiaoVienCN
            // 
            this.comboBoxGiaoVienCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGiaoVienCN.FormattingEnabled = true;
            this.comboBoxGiaoVienCN.Location = new System.Drawing.Point(183, 200);
            this.comboBoxGiaoVienCN.Name = "comboBoxGiaoVienCN";
            this.comboBoxGiaoVienCN.Size = new System.Drawing.Size(241, 28);
            this.comboBoxGiaoVienCN.TabIndex = 10;
            this.comboBoxGiaoVienCN.SelectedIndexChanged += new System.EventHandler(this.comboBoxGiaoVienCN_SelectedIndexChanged);
            // 
            // textBoxIDLopHoc
            // 
            this.textBoxIDLopHoc.Enabled = false;
            this.textBoxIDLopHoc.Location = new System.Drawing.Point(183, 47);
            this.textBoxIDLopHoc.Name = "textBoxIDLopHoc";
            this.textBoxIDLopHoc.Size = new System.Drawing.Size(241, 27);
            this.textBoxIDLopHoc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên Loại Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giáo viên chủ nhiệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Lớp Học";
            // 
            // radioButtonXoaLop
            // 
            this.radioButtonXoaLop.AutoSize = true;
            this.radioButtonXoaLop.Location = new System.Drawing.Point(356, 49);
            this.radioButtonXoaLop.Name = "radioButtonXoaLop";
            this.radioButtonXoaLop.Size = new System.Drawing.Size(99, 24);
            this.radioButtonXoaLop.TabIndex = 6;
            this.radioButtonXoaLop.TabStop = true;
            this.radioButtonXoaLop.Text = "Xóa Lớp";
            this.radioButtonXoaLop.UseVisualStyleBackColor = true;
            this.radioButtonXoaLop.CheckedChanged += new System.EventHandler(this.radioButtonXoaLop_CheckedChanged);
            // 
            // radioButtonCapNhat
            // 
            this.radioButtonCapNhat.AutoSize = true;
            this.radioButtonCapNhat.Location = new System.Drawing.Point(212, 49);
            this.radioButtonCapNhat.Name = "radioButtonCapNhat";
            this.radioButtonCapNhat.Size = new System.Drawing.Size(105, 24);
            this.radioButtonCapNhat.TabIndex = 5;
            this.radioButtonCapNhat.TabStop = true;
            this.radioButtonCapNhat.Text = "Cập nhật";
            this.radioButtonCapNhat.UseVisualStyleBackColor = true;
            this.radioButtonCapNhat.CheckedChanged += new System.EventHandler(this.radioButtonCapNhat_CheckedChanged);
            // 
            // radioButtonTao
            // 
            this.radioButtonTao.AutoSize = true;
            this.radioButtonTao.Location = new System.Drawing.Point(11, 49);
            this.radioButtonTao.Name = "radioButtonTao";
            this.radioButtonTao.Size = new System.Drawing.Size(174, 24);
            this.radioButtonTao.TabIndex = 4;
            this.radioButtonTao.TabStop = true;
            this.radioButtonTao.Text = "Tạo Lớp Học Mới";
            this.radioButtonTao.UseVisualStyleBackColor = true;
            this.radioButtonTao.CheckedChanged += new System.EventHandler(this.radioButtonTao_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1225, 607);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cập nhật loại lớp học";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UserControlQLLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlQLLOPHOC);
            this.Name = "UserControlQLLopHoc";
            this.Size = new System.Drawing.Size(1400, 643);
            this.Load += new System.EventHandler(this.UserControlQLLopHoc_Load);
            this.tabControlQLLOPHOC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachLopHoc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTLopHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQLLOPHOC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachLopHoc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTTLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ComboBox comboBoxTenLoaiLop;
        private System.Windows.Forms.ComboBox comboBoxGiaoVienCN;
        private System.Windows.Forms.TextBox textBoxIDLopHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonXoaLop;
        private System.Windows.Forms.RadioButton radioButtonCapNhat;
        private System.Windows.Forms.RadioButton radioButtonTao;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}
