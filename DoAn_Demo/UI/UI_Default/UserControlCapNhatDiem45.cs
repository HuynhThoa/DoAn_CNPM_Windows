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
    public partial class UserControlCapNhatDiem45 : UserControl
    {
        private LopHoc lop;
        private List<DanhSachLop> danhSachHocSinh;
        private List<MonHoc> monHoc;
        private QLHSService service = new QLHSService();
        public UserControlCapNhatDiem45(LopHoc lopHoc)
        {
            InitializeComponent();
            this.lop = lopHoc;
            this.danhSachHocSinh = service.GetDanhSachLop(ds => ds.IDLopHoc == lop.IDLopHoc);
            monHoc = service.GetDanhSachMonHocBy(mh => mh.IDLoaiLop == lop.IDLoaiLop);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlCapNhatDiem45_Load(object sender, EventArgs e)
        {
            Remote_Data(textBoxDiemDiaLy, textBoxDiemLichSu, textBoxDiemTiengAnh_45, textBoxDiemTiengViet_45, textBoxDiemToan_45, textBoxIDCapNhatDiem_45, false);
            FillData(lop, dataGridViewCapNhatDiem_45);
        }

        private void radioButtonCuoiHK1_45_Click(object sender, EventArgs e)
        {
            Remote_Data(textBoxIDCapNhatDiem_45, textBoxDiemToan_45, textBoxDiemTiengAnh_45, textBoxDiemTiengViet_45, textBoxDiemLichSu, textBoxDiemDiaLy, true);
        }

        private void Remote_Data(TextBox textBoxIDCapNhatDiem_45, TextBox textBoxDiemToan_45, TextBox textBoxDiemTiengAnh_45, TextBox textBoxDiemTiengViet_45, TextBox textBoxDiemLichSu, TextBox textBoxDiemDiaLy, bool state)
        {
           textBoxDiemDiaLy.Enabled = textBoxDiemLichSu.Enabled = textBoxDiemTiengAnh_45.Enabled 
                = textBoxDiemTiengViet_45.Enabled = textBoxDiemToan_45.Enabled = textBoxIDCapNhatDiem_45.Enabled = state;
           

            textBoxDiemDiaLy.Text = textBoxDiemLichSu.Text = textBoxDiemTiengAnh_45.Text
                = textBoxDiemTiengViet_45.Text = textBoxDiemToan_45.Text = textBoxIDCapNhatDiem_45.Text = null;

        }

        private void radioButtonCuoiHK2_45_CheckedChanged(object sender, EventArgs e)
        {
            Remote_Data(textBoxIDCapNhatDiem_45, textBoxDiemToan_45, textBoxDiemTiengAnh_45, textBoxDiemTiengViet_45, textBoxDiemLichSu, textBoxDiemDiaLy, true);
        }

        private void textBoxIDCapNhatDiem_45_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxIDCapNhatDiem_45.Text.Trim();
            if (text.Length > 0)
            {
                if (!int.TryParse(text, out int a))
                {
                    ShowErr("Id phải là số");
                    textBoxIDCapNhatDiem_45.Text = text.Substring(0, text.Length - 1);
                    return;
                }
            }
        }
        Action<string> ShowErr = s => MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Action<string> ShowInfo = s => MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void textBoxIDCapNhatDiem_45_Leave(object sender, EventArgs e)
        {
            string text = textBoxIDCapNhatDiem_45.Text.Trim();
            if (text.Length > 0)
            {
                DanhSachLop l = danhSachHocSinh.Where(h => h.IDHS == int.Parse(text)).FirstOrDefault();
                if (l is null)
                {
                    ShowErr("Không có học sinh khớp với id này");
                    textBoxIDCapNhatDiem_45.Text = null;
                    return;
                }
            }
        }

        private void dataGridViewCapNhatDiem_45_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDCapNhatDiem_45.Text = dataGridViewCapNhatDiem_45.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void buttonCapNhatDiem_45_Click(object sender, EventArgs e)
        {
            string idHS = textBoxIDCapNhatDiem_45.Text.Trim();
            textBoxIDCapNhatDiem_45_Leave(sender, e);
            if (idHS.Length <= 0)
            {
                ShowErr("Không có học sinh khớp với id này");
                return;
            }

            int diemToan;
            if (!CheckDiem_TextBox(textBoxDiemToan_45, out diemToan))
            {
                return;
            }
            int diemTiengViet;
            if (!CheckDiem_TextBox(textBoxDiemTiengViet_45, out diemTiengViet))
            {
                return;
            }
            int diemTiengAnh;
            if (!CheckDiem_TextBox(textBoxDiemTiengAnh_45, out diemTiengAnh))
            {
                return;
            }
            int diemLichSu;
            if (!CheckDiem_TextBox(textBoxDiemLichSu, out diemLichSu))
            {
                return;
            }
            int diemDiaLy;
            if (!CheckDiem_TextBox(textBoxDiemDiaLy, out diemDiaLy))
            {
                return;
            }

            int idhs = int.Parse(idHS);
            int idMonToan = GetIdByTenMon("toán");

            int idMonTV = GetIdByTenMon("việt");

            int idMonTA = GetIdByTenMon("anh");

            int idMonLS = GetIdByTenMon("lịch sử");

            int idMonDL = GetIdByTenMon("địa lý");
            DanhSachLop hocSinh = danhSachHocSinh.Where(h => h.IDHS == idhs).FirstOrDefault();

            if (radioButtonCuoiHK1_45.Checked)
            {
                int idbxl = (int)hocSinh.IDBXL;
                Update_Diem_KyMot(idMonToan, idbxl, diemToan);
                Update_Diem_KyMot(idMonTA, idbxl, diemTiengAnh);
                Update_Diem_KyMot(idMonTV, idbxl, diemTiengViet);
                Update_Diem_KyMot(idMonLS, idbxl, diemLichSu);
                Update_Diem_KyMot(idMonDL, idbxl, diemDiaLy);
            }
            else
            {
                int idbxl = (int)hocSinh.IDBXL;
                Update_Diem_KyHai(idMonToan, idbxl, diemToan);
                Update_Diem_KyHai(idMonTA, idbxl, diemTiengAnh);
                Update_Diem_KyHai(idMonTV, idbxl, diemTiengViet);
                Update_Diem_KyHai(idMonLS, idbxl, diemLichSu);
                Update_Diem_KyHai(idMonDL, idbxl, diemDiaLy);
            }


            FillData(lop, dataGridViewCapNhatDiem_45);
            UpdateXepLoai(idhs);
        }

        private void UpdateXepLoai(int idhs)
        {
            BangXepLoai bxl = danhSachHocSinh.Where(h => h.IDHS == idhs).Select(h => h.BangXepLoai).FirstOrDefault();

            List<CTBangDiem> cTBangDiem = service.getListCTBangDiem(ct => ct.BangXepLoai.IDBXL == bxl.IDBXL);
            int? avg = 0;
            foreach (CTBangDiem ct in cTBangDiem)
            {
                if (ct.DiemKyMot != null && ct.DiemKyHai != null)
                {
                    avg += (ct.DiemKyMot + ct.DiemKyHai) / 2;
                }
                else
                {
                    return;
                }
            }
            avg /= 5;
            if (avg >= 9)
            {
                SetXepLoai("Giỏi", bxl);
            }
            else if (avg >= 7)
            {
                SetXepLoai("Khá", bxl);
            }
            else if (avg >= 5)
            {
                SetXepLoai("Trung Bình", bxl);
            }
            else
            {
                SetXepLoai("Lưu Ban", bxl);
            }
        }

        private void SetXepLoai(string xepLoai, BangXepLoai bxl)
        {
            bxl.XepLoai = xepLoai;
            bxl.HanhKiem = "Tốt";
            service.updateBangXepLoai(bxl);
            service.Save();
        }

        private void FillData(LopHoc lop, DataGridView data)
        {
            data.Rows.Clear();
            service.FillDataBangDiem(lop, data);
        }

        private bool CheckDiem_TextBox(TextBox textBox, out int diemOK)
        {
            int diem;
            if (!int.TryParse(textBox.Text.Trim(), out diem))
            {
                diemOK = 0;
                ShowErr("Điểm phải là số nguyên nhỏ hơn hoặc bằng 10 và lớn hơn hoặc bằng 0");
                return false;
            }
            if (diem > 10 || diem < 0)
            {
                ShowErr("Điểm phải là số nguyên nhỏ hơn hoặc bằng 10 và lớn hơn hoặc bằng 0");
                diemOK = 0;
                return false;
            }
            diemOK = diem;
            return true;
        }
        private int GetIdByTenMon(string tenMon)
        {
            int maMon = monHoc.Where(m => m.TenMH.ToLower().Contains(tenMon)).Select(m => m.IDMH).FirstOrDefault();
            return maMon;
        }
        private void Update_Diem_KyMot(int idMonHoc, int bxl, int diemKy1)
        {
            CTBangDiem oldCTBangdiem = service.getCTBangDiem(ct => ct.IDMH == idMonHoc && ct.IDBXL == bxl);
            CTBangDiem newCTBangDiem = new CTBangDiem() { IDMH = idMonHoc, IDBXL = (int)bxl, DiemKyMot = diemKy1, DiemKyHai = oldCTBangdiem.DiemKyHai };
            service.UpdateCTBangDiem(newCTBangDiem);
            service.Save();
        }
        private void Update_Diem_KyHai(int idMonHoc, int bxl, int diemKy2)
        {
            CTBangDiem oldCTBangdiem = service.getCTBangDiem(ct => ct.IDMH == idMonHoc && ct.IDBXL == bxl);
            CTBangDiem NewCTBangDiem = new CTBangDiem() { IDMH = idMonHoc, IDBXL = (int)bxl, DiemKyMot = oldCTBangdiem.DiemKyMot, DiemKyHai = diemKy2 };
            service.UpdateCTBangDiem(NewCTBangDiem);
            service.Save();
        }
    }
}
