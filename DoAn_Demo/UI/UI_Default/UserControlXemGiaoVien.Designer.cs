
namespace DoAn_Demo.UI.UI_Default
{
    partial class UserControlXemGiaoVien
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewXemGiaoVien
            // 
            this.dataGridViewXemGiaoVien.AllowUserToAddRows = false;
            this.dataGridViewXemGiaoVien.AllowUserToDeleteRows = false;
            this.dataGridViewXemGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXemGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewXemGiaoVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSapXep;
        private System.Windows.Forms.TextBox textBoxSeachGV;
    }
}
