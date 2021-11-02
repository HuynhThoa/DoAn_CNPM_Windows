using DoAn_Demo.Entities;
using DoAn_Demo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Demo.UI.UI_Default
{
    public partial class DoiMatKhau : Form
    {
        private GiaoVien user;
        QLHSService service = new QLHSService();
        public DoiMatKhau(GiaoVien user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void textBoxpassCu_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxMax(textBoxpassCu);
        }

        private void CheckTextBoxMax(TextBox textBoxpass1)
        {
            string text = textBoxpass1.Text.Trim();
            if(text.Length > 50)
            {
                MessageBox.Show("Tối đa 50 ký tự","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBoxpass1.Text = text.Substring(0, text.Length - 1);
                return;
            }
        }

        private void textBoxpassMoi_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxMax(textBoxpassMoi);
        }

        private void textBoxpassmoi2_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxMax(textBoxpassmoi2);
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            string textCu = textBoxpassCu.Text.Trim();
            if(textCu.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập pass cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!user.Pass.Equals(textCu))
            {
                MessageBox.Show("Pass cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string textmoi = textBoxpassMoi.Text.Trim();
            string textmoi2 = textBoxpassmoi2.Text.Trim();
            if(textmoi.Length <= 0)
            {
                MessageBox.Show("Pass không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textmoi2.Length <= 0)
            {
                MessageBox.Show("Pass không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.Compare(textmoi, textmoi2, true) == 0)
            {
                user.Pass = textmoi;
                service.UpdateGiaoVien(user);
                service.Save();
                MessageBox.Show("Mật khẩu đã được thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                MessageBox.Show("Pass mới không đúng vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            labelCTK.Text = "Chủ Tài Khoản: " + user.HoTen; 
        }
    }
}
