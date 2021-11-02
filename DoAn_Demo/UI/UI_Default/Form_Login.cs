using DoAn_Demo.Entities;
using DoAn_Demo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Demo
{
    public partial class Form_Login : Form
    {

        public QLHSService service = new QLHSService();
        public Form_Login( )
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kiểm tra data trong control
        /// </summary>
        /// <param name="control">true nếu có chứa dữ liệu else false</param>
        private bool CheckDataInControl(Control control)
        {
            int length = control.Text.Trim().Length;
            if(length <= 0)
            {
                return false;
            }
            return true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string numberPhone = textBoxSDT.Text.Trim();
            string password = textBoxPass.Text.Trim();

            if(numberPhone.Length < 9)
            {
                ShowMess("Số điện thoại không hợp lệ( 8 < Số điện thoại < 13)!");
                return;
            }
            if(password.Length > 100)
            {
                ShowMess("Mật khẩu không hợp lệ");
                return;
            }
            GiaoVien giaoVien = service.GetGiaoVien(gv =>  string.Compare(numberPhone, gv.SDT.ToString(), true) == 0);
            
            if(giaoVien != null)
            {
               // string pass = Decrypt(giaoVien.Pass);
                if(string.Compare(password,giaoVien.Pass,true) == 0)
                {
                    Form_Menu form = new Form_Menu(giaoVien);
                    this.Visible = false;
                    form.ShowDialog();
                    
                }
                else
                {
                    ShowMess("Nhập sai số điện thoại hoặc password");
                    return;
                }

            }
            else
            {
                ShowMess("Nhập sai số điện thoại hoặc password");
                return;
            }

        }

        
        public void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();           
        }
        string key = "nguyenhoangkhang";
        
            private string Encrypt(string value)
            {
                byte[] plaintext = Encoding.Unicode.GetBytes(value);

                CspParameters cspParams = new CspParameters();
                cspParams.KeyContainerName = key;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048, cspParams))
                {
                    byte[] encryptedData = RSA.Encrypt(plaintext, false);
                    return Convert.ToBase64String(encryptedData);
                }
            }
        
        private void textBoxSDT_TextChanged(object sender, EventArgs e)
        {
            string numberPhone = textBoxSDT.Text.Trim();

            int length = numberPhone.Length;

            if(length > 0)
            {
                if(!CheckNumber(numberPhone[length - 1]))
                {
                    ShowMess("Vui lòng nhập số !!!");
                    textBoxSDT.Text = numberPhone.Substring(0, length - 1);

                    return;
                }
            }
            if(length > 12)
            {
                ShowMess("Số điện thoại không hợp lệ (8 < Số điện thoại < 13)");
                textBoxSDT.Text = numberPhone.Substring(0, length - 1);
                return;
            }
        }
        private string Decrypt(string value)
        {
            byte[] encryptedData = Convert.FromBase64String(value);

            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = key;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048, cspParams))
            {
                byte[] decryptedData = RSA.Decrypt(encryptedData, false);
                return Encoding.Unicode.GetString(decryptedData);
            }
        }
        Action<string> ShowMess = s => MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        /// <summary>
        /// kiểm tra ký tự có phải là số
        /// </summary>
        /// <param name="c"></param>
        /// <returns>true nếu là số</returns>
        private bool CheckNumber(char c)
        {
            if(c >= '0' && c <= '9')
            {
                return true;
            }
            return false;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            int pass = textBoxPass.Text.Trim().Length;
            if(pass > 100)
            {
                ShowMess("Password không hợp lệ !!!");
            }
        }
    }
}
