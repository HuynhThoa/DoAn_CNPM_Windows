using DoAn_Demo.Entities;
using DoAn_Demo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Demo.UI.UI_Default
{
    public partial class UserControlQLThongTinGiaoVien : UserControl
    {
        private GiaoVien user;

        private List<GiaoVien> listGiaoVien;

        private QLHSService service = new QLHSService();
        public UserControlQLThongTinGiaoVien(GiaoVien user )
        {
            InitializeComponent();
            this.user = user;
            listGiaoVien = service.GetListGiaoVien();
        }

        private void UserControlQLThongTinGiangVien_Load(object sender, EventArgs e)
        {
            FillData(dataGridViewDanhSachGiangVien, listGiaoVien);
            radioButtonNu.Checked = radioButtonNuSua.Checked = true;
        }

        /// <summary>
        /// fill data vào datagrid
        /// </summary>
        /// <param name="dataGridViewDanhSachGiangVien"></param>
        /// <param name="listGiaoVien"></param>
        private void FillData(DataGridView dataGridViewDanhSachGiangVien, List<GiaoVien> listGiaoVien)
        {
            dataGridViewDanhSachGiangVien.Rows.Clear();
            foreach (GiaoVien giaoVien in listGiaoVien)
            {
                dataGridViewDanhSachGiangVien.Rows.Add(giaoVien.IDGV, giaoVien.HoTen, giaoVien.SDT, giaoVien.DC, giaoVien.Email,giaoVien.Pass,giaoVien.GioiTinh?"Nam":"Nữ", giaoVien.LoaiTaiKhoan?"Admin":"Giáo Vien");
            }
        }

        private void textBoxHoTen_TextChanged(object sender, EventArgs e)
        {
            string hoTen = textBoxHoTen.Text.Trim();
            if (hoTen.Length <= 0) return;
            if (Check_Number(hoTen) || !Check_LongString(hoTen, 100))
            {
                ShowErr("Họ Tên không được xuất hiện số và tối đa 100 ký tự");
                RollBack(textBoxHoTen);
                return;
            }

        }

        /// <summary>
        /// kiểm tra độ dài chuỗi truyền vào xem có nhỏ hơn tham số thứ 2 ko
        /// </summary>
        /// <param name="idgv"></param>
        /// <param name="v"></param>
        /// <returns>nếu nhỏ hơn true else false</returns>
        private bool Check_LongString(string idgv, int longMaxString)
        {
            bool kq = idgv.Length < longMaxString ? true : false;
            return kq;
        }

        /// <summary>
        /// quay về dữ liệu cũ
        /// </summary>
        /// <param name="textBoxIDSua"></param>
        private void RollBack(TextBox textBox)
        {
            textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
        }

        Action<string> ShowErr = s => MessageBox.Show(s, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Action<string> ShowInfo = s => MessageBox.Show(s, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        /// <summary>
        /// kiểm tra ký tự vừa nhập là số hay ký tự
        /// </summary>
        /// <param name="idgv"></param>
        /// <returns>true if string is number else false </returns>
        private bool Check_Number(string idgv)
        {
            char c = idgv[idgv.Length - 1];
            if(c < '0' || c > '9')
            {
                return false;
            }
            return true;
        }

        private void textBoxIDSua_TextChanged(object sender, EventArgs e)
        {
            string idgv = textBoxIDSua.Text.Trim();
            if (idgv.Length <= 0) return;
            if (!Check_Number(idgv)|| !Check_LongString(idgv,5))
            {
                ShowErr("ID phải là số, và tối đa 5 ký tự");
                RollBack(textBoxIDSua);
                return;
            }
        }

        private void textBoxIDGVXoa_Leave(object sender, EventArgs e)
        {
            string textIDGV = textBoxIDGVXoa.Text.Trim();
            if (textIDGV.Length <= 0) return;
            if(!Check_Number(textIDGV))
            {
                ShowErr("IDGV phải là số");
                return;
            }
            int idgv = int.Parse(textIDGV); 
            GiaoVien gv = FindGiaoVien(idgv);
            if(gv is null)
            {
                ShowErr("Không tồn tại Giáo Viên với ID này");
                ClearData(textBoxIDGVXoa);
                return;
            }

        }

        /// <summary>
        /// clear all data
        /// </summary>
        /// <param name="textBoxIDGVXoa"></param>
        private void ClearData(TextBox textBox)
        {
            textBox.Text = null;
        }

        private GiaoVien FindGiaoVien(int idgv)
        {
            GiaoVien gv = listGiaoVien.Where(g => g.IDGV == idgv).FirstOrDefault();
            return gv;
        }

        private void textBoxIDSua_Leave(object sender, EventArgs e)
        {
            string textIDGV = textBoxIDSua.Text.Trim();
            if (!Check_Number(textIDGV))
            {
                ShowErr("IDGV phải là số");
                return;
            }
            int idgv = int.Parse(textIDGV);
            GiaoVien gv = FindGiaoVien(idgv);
            if (gv is null)
            {
                ShowErr("Không tồn tại Giáo Viên với ID này");
                ClearData(textBoxIDSua);
                return;
            }
        }

        private void textBoxIDGVXoa_TextChanged(object sender, EventArgs e)
        {
            string idgv = textBoxIDGVXoa.Text.Trim();
            if (idgv.Length <= 0) return;
            if (!Check_Number(idgv) || !Check_LongString(idgv, 4)) 
            {
                ShowErr("ID phải là số, tối đa 4 ký tự");
                RollBack(textBoxIDGVXoa);
                return;
            }
        }

        private void textBoxSDT_TextChanged(object sender, EventArgs e)
        {
            string textNumber = textBoxSDT.Text.Trim();
            if (textNumber.Length <= 0) return;
            if (!Check_Number(textNumber) )
            {
                ShowErr("Số điện thoại phải là số");
                RollBack(textBoxSDT);
                return;
            }
        }

        private void textBoxSDTSua_TextChanged(object sender, EventArgs e)
        {
            string textNumber = textBoxSDTSua.Text.Trim();
            if (textNumber.Length <= 0) return;
            if (!Check_Number(textNumber))
            {
                ShowErr("Số điện thoại phải là số");
                RollBack(textBoxSDTSua);
                return;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string hoten = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            bool gioiTinh = radioButtonNam.Checked ? true : false;
            string diaChi = textBoxDC.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string pass = textBoxPass.Text.Trim();
            
            bool loaiTaiKhoan = checkBoxLoaiTaiKhoan.Checked ? true : false;
            if (Check_LongString(hoten, 5))
            {
                ShowErr("Tên không hợp lệ");
                return;
            }
            if(Check_LongString(sdt,9) || !Check_LongString(sdt, 13))
            {
                ShowErr("Số điện thoại không hợp lệ");
                return;
            }
            GiaoVien gv = FindGVBy(sdt);
            if(gv != null)
            {
                ShowErr("Số điện thoại này đã tồn tại");
                return;
            }
            if (Check_LongString(diaChi, 10))
            {
                ShowErr("Đia chỉ không hợp lệ");
                return;
            }
            if (Check_LongString(email, 10))
            {
                ShowErr("Đia chỉ Email không hợp lệ");
                return;
            }
            if (Check_LongString(pass, 0))
            {
                ShowErr("Pass không hợp lệ");
                return;
            }
          //  pass = Encrypt(pass);
            GiaoVien giaoVien = new GiaoVien()
            {
                HoTen = hoten,
                DC = diaChi,
                GioiTinh = gioiTinh,
                Email = email,
                LoaiTaiKhoan = loaiTaiKhoan,
                SDT = sdt,
                Pass = pass
            };
            AddGiaoVien(giaoVien);
            UpdateListGiaoVien();
            FillData(dataGridViewDanhSachGiangVien, listGiaoVien);
        }

        private GiaoVien FindGVBy(string sdt)
        {
            GiaoVien gv = listGiaoVien.Where(g => g.SDT.Equals(sdt)).FirstOrDefault();
            return gv;
        }

        private void UpdateListGiaoVien()
        {
            listGiaoVien = service.GetListGiaoVien();
        }

        private void AddGiaoVien(GiaoVien giaoVien)
        {
            service.AddGiaoVien(giaoVien);
            service.Save();
        }

        private void textBoxHoTenSua_TextChanged(object sender, EventArgs e)
        {
            string hoTen = textBoxHoTenSua.Text.Trim();
            if (hoTen.Length <= 0) return;
            if(Check_Number(hoTen)|| !Check_LongString(hoTen, 100))
            {
                ShowErr("Họ Tên không được xuất hiện số và tối đa 100 ký tự");
                RollBack(textBoxHoTenSua);
                return;
            }
        }

        private void textBoxDC_TextChanged(object sender, EventArgs e)
        {
            string DC = textBoxDC.Text.Trim();
            if (!Check_LongString(DC, 200))
            {
                ShowErr("Bạn đã vượt quá giới hạn cho phép");
                RollBack(textBoxDC);
                return;
            }
        }

        private void textBoxDCSua_TextChanged(object sender, EventArgs e)
        {
            string DC = textBoxDCSua.Text.Trim();
            if (DC.Length <= 0) return;
            if (!Check_LongString(DC, 200))
            {
                ShowErr("Bạn đã vượt quá giới hạn cho phép");
                RollBack(textBoxDCSua);
                return;
            }
        }

        private void textBoxEmailSua_TextChanged(object sender, EventArgs e)
        {
            string DC = textBoxEmailSua.Text.Trim();
            if (DC.Length <= 0) return;
            if (!Check_LongString(DC, 100))
            {
                ShowErr("Bạn đã vượt quá giới hạn cho phép");
                RollBack(textBoxEmailSua);
                return;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            if (email.Length <= 0) return;
            if (!Check_LongString(email, 100))
            {
                ShowErr("Bạn đã vượt quá giới hạn cho phép");
                RollBack(textBoxEmail);
                return;
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            string DC = textBoxPass.Text.Trim();
            if (!Check_LongString(DC, 50))
            {
                ShowErr("Bạn đã vượt quá giới hạn cho phép");
                RollBack(textBoxPass);
                return;
            }
        }

        private void textBoxPassSua_TextChanged(object sender, EventArgs e)
        {
            string DC = textBoxPassSua.Text.Trim();
            if (DC.Length <= 0) return;
            if (!Check_LongString(DC, 50))
            {
                ShowErr("Bạn đã vượt quá giới hạn cho phép");
                RollBack(textBoxPassSua);
                return;
            }
        }

        private void buttonSUa_Click(object sender, EventArgs e)
        {
            string idgv = textBoxIDSua.Text.Trim();
            if(idgv.Length < 0)
            {
                ShowErr("Id giáo viên không hợp lệ");
                return;
            }
            int iDGV = int.Parse(idgv);
            GiaoVien giaoVien = FindGiaoVien(iDGV);
            if(giaoVien is null)
            {
                ShowErr("Giáo viên với id này không tồn tại");
                return;
            }
            string hoten = textBoxHoTenSua.Text.Trim();
            string sdt = textBoxSDTSua.Text.Trim();
            bool gioiTinh = radioButtonNamSua.Checked ? true : false;
            string diaChi = textBoxDCSua.Text.Trim();
            string email = textBoxEmailSua.Text.Trim();
            string pass = textBoxPassSua.Text.Trim();

            bool loaiTaiKhoan = checkBoxLoaiTaiKhoan.Checked ? true : false;
            if (Check_LongString(hoten, 5))
            {
                ShowErr("Tên không hợp lệ");
                return;
            }
            if (Check_LongString(sdt, 9) || !Check_LongString(sdt, 12))
            {
                ShowErr("Số điện thoại không hợp lệ");
                return;
            }
            if (Check_LongString(diaChi, 10))
            {
                ShowErr("Đia chỉ không hợp lệ");
                return;
            }
            if (Check_LongString(email, 10))
            {
                ShowErr("Đia chỉ Email không hợp lệ");
                return;
            }
            if (Check_LongString(pass, 0))
            {
                ShowErr("Pass không hợp lệ");
                return;
            }
           // pass = Encrypt(pass);
             giaoVien = new GiaoVien()
            {
                 IDGV = iDGV,
                HoTen = hoten,
                DC = diaChi,
                GioiTinh = gioiTinh,
                Email = email,
                LoaiTaiKhoan = loaiTaiKhoan,
                SDT = sdt,
                Pass = pass
            };
            UpdateGiaoVien(giaoVien);
            UpdateListGiaoVien();
            FillData(dataGridViewDanhSachGiangVien, listGiaoVien);
        }

        private void UpdateGiaoVien(GiaoVien giaoVien)
        {
            service.UpdateGiaoVien(giaoVien);
            service.Save();
        }

        string key = "nguyenhoangkhang";
       

        

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string id = textBoxIDGVXoa.Text.Trim();
            if(id.Length > 0)
            {
                int idgv = int.Parse(id);
                GiaoVien giaoVien = FindGiaoVien(idgv);
                List<LopHoc> lop = service.getListLopHoc();
                LopHoc lopHoc = lop.Where(l => l.IDGV == giaoVien.IDGV).FirstOrDefault();
                if(lopHoc != null)
                {
                    ShowErr("Giáo viên đang đảm nhiệm lớp:" + lopHoc.TenLop + "- SiSo: "+ lopHoc.SiSo +"Không thể xóa - vui lòng cho giáo viên thay thế mới xóa được");
                    return;
                }
               if(giaoVien != null)
                {
                    ClearData(textBoxIDGVXoa);
                    DeleteGiaoVien(giaoVien);
                    UpdateListGiaoVien();
                    FillData(dataGridViewDanhSachGiangVien, listGiaoVien);
                }
            }
            else
            {
                ShowErr("Vui lòng nhập id giáo viên cần xóa");
                return;
            }
           
        }

        private void DeleteGiaoVien(GiaoVien giaoVien)
        {
            service.DeleteGiaoVien(giaoVien);
            service.Save();
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

        private void dataGridViewDanhSachGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhSachGiangVien.Rows[e.RowIndex];

            string id = row.Cells[0].Value.ToString();
            string hoTen = row.Cells[1].Value.ToString();
            string sdt = row.Cells[2].Value.ToString();
            string dc = row.Cells[3].Value.ToString();
            string email = row.Cells[4].Value.ToString();
            string pass = row.Cells[5].Value.ToString();
            string gioiTinh = row.Cells[6].Value.ToString();
            string LoaiTaiKhoan = row.Cells[7].Value.ToString();

            // thêm
            textBoxHoTen.Text = textBoxHoTenSua.Text = hoTen;
            textBoxIDGVXoa.Text = textBoxIDSua.Text = id;
            textBoxSDT.Text = textBoxSDTSua.Text = sdt;
            textBoxDC.Text = textBoxDCSua.Text = dc;
            textBoxEmail.Text = textBoxEmailSua.Text = email;
            textBoxPass.Text = textBoxPassSua.Text = pass;
            if (gioiTinh.Contains("Nam"))
            {
                radioButtonNam.Checked = radioButtonNamSua.Checked = true;
            }
            else
            {
                radioButtonNam.Checked = radioButtonNamSua.Checked = false;
            }
            if (LoaiTaiKhoan.Contains("Admin"))
            {
                checkBoxLoaiTaiKhoan.Checked = checkBoxLoaiTaiKhoanSua.Checked = true;
            }
            else
            {
                checkBoxLoaiTaiKhoan.Checked = checkBoxLoaiTaiKhoanSua.Checked = false;
            }
        }
    }
}
