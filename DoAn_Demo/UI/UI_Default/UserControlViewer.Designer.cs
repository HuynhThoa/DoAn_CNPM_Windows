
namespace DoAn_Demo.UI.UI_Default
{
    partial class UserControlViewer
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
            this.dataGridViewXemGiaoVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSapXep = new System.Windows.Forms.Button();
            this.textBoxSeachGV = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewXemGiaoVien
            // 
            this.dataGridViewXemGiaoVien.AllowUserToAddRows = false;
            this.dataGridViewXemGiaoVien.AllowUserToDeleteRows = false;
            this.dataGridViewXemGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXemGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewXemGiaoVien.Location = new System.Drawing.Point(121, 161);
            this.dataGridViewXemGiaoVien.Name = "dataGridViewXemGiaoVien";
            this.dataGridViewXemGiaoVien.RowHeadersWidth = 51;
            this.dataGridViewXemGiaoVien.RowTemplate.Height = 24;
            this.dataGridViewXemGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXemGiaoVien.Size = new System.Drawing.Size(1268, 455);
            this.dataGridViewXemGiaoVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(975, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm";
            // 
            // buttonSapXep
            // 
            this.buttonSapXep.Location = new System.Drawing.Point(121, 113);
            this.buttonSapXep.Name = "buttonSapXep";
            this.buttonSapXep.Size = new System.Drawing.Size(100, 29);
            this.buttonSapXep.TabIndex = 2;
            this.buttonSapXep.Text = "Sắp Xếp";
            this.buttonSapXep.UseVisualStyleBackColor = true;
            // 
            // textBoxSeachGV
            // 
            this.textBoxSeachGV.Location = new System.Drawing.Point(1047, 113);
            this.textBoxSeachGV.Name = "textBoxSeachGV";
            this.textBoxSeachGV.Size = new System.Drawing.Size(212, 22);
            this.textBoxSeachGV.TabIndex = 3;
            this.textBoxSeachGV.TextChanged += new System.EventHandler(this.textBoxSeachGV_TextChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Giáo Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Điện Thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "GIới Tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // UserControlXemGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSeachGV);
            this.Controls.Add(this.buttonSapXep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewXemGiaoVien);
            this.Name = "UserControlXemGiaoVien";
            this.Size = new System.Drawing.Size(1522, 649);
            this.Load += new System.EventHandler(this.UserControlXemGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewXemGiaoVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSapXep;
        private System.Windows.Forms.TextBox textBoxSeachGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
