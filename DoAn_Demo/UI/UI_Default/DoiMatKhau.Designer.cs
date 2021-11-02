
namespace DoAn_Demo.UI.UI_Default
{
    partial class DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxpassCu = new System.Windows.Forms.TextBox();
            this.textBoxpassMoi = new System.Windows.Forms.TextBox();
            this.textBoxpassmoi2 = new System.Windows.Forms.TextBox();
            this.labelCTK = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chủ Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại Mật Khẩu mới";
            // 
            // textBoxpassCu
            // 
            this.textBoxpassCu.Location = new System.Drawing.Point(309, 169);
            this.textBoxpassCu.Name = "textBoxpassCu";
            this.textBoxpassCu.PasswordChar = '*';
            this.textBoxpassCu.Size = new System.Drawing.Size(352, 22);
            this.textBoxpassCu.TabIndex = 4;
            this.textBoxpassCu.TextChanged += new System.EventHandler(this.textBoxpassCu_TextChanged);
            // 
            // textBoxpassMoi
            // 
            this.textBoxpassMoi.Location = new System.Drawing.Point(309, 246);
            this.textBoxpassMoi.Name = "textBoxpassMoi";
            this.textBoxpassMoi.PasswordChar = '*';
            this.textBoxpassMoi.Size = new System.Drawing.Size(352, 22);
            this.textBoxpassMoi.TabIndex = 5;
            this.textBoxpassMoi.TextChanged += new System.EventHandler(this.textBoxpassMoi_TextChanged);
            // 
            // textBoxpassmoi2
            // 
            this.textBoxpassmoi2.Location = new System.Drawing.Point(309, 315);
            this.textBoxpassmoi2.Name = "textBoxpassmoi2";
            this.textBoxpassmoi2.PasswordChar = '*';
            this.textBoxpassmoi2.Size = new System.Drawing.Size(352, 22);
            this.textBoxpassmoi2.TabIndex = 6;
            this.textBoxpassmoi2.TextChanged += new System.EventHandler(this.textBoxpassmoi2_TextChanged);
            // 
            // labelCTK
            // 
            this.labelCTK.AutoSize = true;
            this.labelCTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCTK.Location = new System.Drawing.Point(393, 99);
            this.labelCTK.Name = "labelCTK";
            this.labelCTK.Size = new System.Drawing.Size(132, 20);
            this.labelCTK.TabIndex = 7;
            this.labelCTK.Text = "Chủ Tài Khoản";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(513, 357);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(125, 28);
            this.buttonLuu.TabIndex = 8;
            this.buttonLuu.Text = "Lưu Thay Đổi";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 408);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.labelCTK);
            this.Controls.Add(this.textBoxpassmoi2);
            this.Controls.Add(this.textBoxpassMoi);
            this.Controls.Add(this.textBoxpassCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxpassCu;
        private System.Windows.Forms.TextBox textBoxpassMoi;
        private System.Windows.Forms.TextBox textBoxpassmoi2;
        private System.Windows.Forms.Label labelCTK;
        private System.Windows.Forms.Button buttonLuu;
    }
}