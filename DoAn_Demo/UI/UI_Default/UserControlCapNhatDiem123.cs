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

namespace DoAn_Demo.UI
{
    public partial class UserControlCapNhatDiem123 : UserControl
    {
        private LopHoc lop;
        private List<DanhSachLop> danhSachHocSinh;
        private List<MonHoc> monHoc;
        private QLHSService service = new QLHSService();
        public UserControlCapNhatDiem123(LopHoc lopHoc)
        {
            InitializeComponent();
            this.lop = lopHoc;
            this.danhSachHocSinh = service.GetDanhSachLop(ds => ds.IDLopHoc == lop.IDLopHoc);
            monHoc = service.GetDanhSachMonHocBy(mh => mh.IDLoaiLop == lop.IDLoaiLop);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonCuoiHK1_Click(object sender, EventArgs e)
        {
            Remote_Data(textBoxIDCapNhatDiem, textBoxToan, textBoxTiengAnh, textBoxTiengViet, true);
        }

        private void UserControlCapNhatDiem123_Load(object sender, EventArgs e)
        {
            
            Remote_Data(textBoxIDCapNhatDiem, textBoxToan, textBoxTiengAnh, textBoxTiengViet,false);
            FillData(lop, dataGridViewCapNhatDiem);
        }
        private void Remote_Data(TextBox textBoxIDCapNhatDiem, TextBox textBoxToan, TextBox textBoxTiengAnh, TextBox textBoxTiengViet, bool state)
        {
            textBoxIDCapNhatDiem.Enabled = textBoxToan.Enabled = textBoxTiengAnh.Enabled = textBoxTiengViet.Enabled = state;
            textBoxIDCapNhatDiem.Text = textBoxToan.Text = textBoxTiengAnh.Text = textBoxTiengViet.Text = null;

        }

        private void FillData(LopHoc lop,DataGridView data)
        {
            data.Rows.Clear();
            service.FillDataBangDiem(lop, data);
        }

        private void radioButtonCuoiHK2_CheckedChanged(object sender, EventArgs e)
        {
            Remote_Data(textBoxIDCapNhatDiem, textBoxToan, textBoxTiengAnh, textBoxTiengViet, true);
        }

        private void dataGridViewCapNhatDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDCapNhatDiem.Text = dataGridViewCapNhatDiem.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void textBoxIDCapNhatDiem_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxIDCapNhatDiem.Text.Trim();
            if (text.Length > 0)
            {
                if (!int.TryParse(text, out int a))
                {
                    ShowErr("Id phải là số");
                    textBoxIDCapNhatDiem.Text = text.Substring(0, text.Length - 1);
                    return;
                }
            }
        }

        Action<string> ShowErr = s => MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Action<string> ShowInfo = s => MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void textBoxIDCapNhatDiem_Leave(object sender, EventArgs e)
        {
            string text = textBoxIDCapNhatDiem.Text.Trim();
            if (text.Length > 0)
            {
                DanhSachLop l = danhSachHocSinh.Where(h => h.IDHS == int.Parse(text)).FirstOrDefault();
                if (l is null)
                {
                    ShowErr("Không có học sinh khớp với id này");
                    textBoxIDCapNhatDiem.Text = null;
                    return;
                }
            }
        }

        private void buttonCapNhatDiem_Click(object sender, EventArgs e)
        {
            string idHS = textBoxIDCapNhatDiem.Text.Trim();
            textBoxIDCapNhatDiem_Leave(sender,e);
            if (idHS.Length <= 0)
            {
                ShowErr("Không có học sinh khớp với id này");
                return;
            }

            int diemToan;
            if(!CheckDiem_TextBox(textBoxToan,out diemToan))
            {
                return;
            }
            int diemTiengViet;
            if (!CheckDiem_TextBox(textBoxTiengViet,out diemTiengViet))
            {
                return;
            }
            int diemTiengAnh;
            if (!CheckDiem_TextBox(textBoxTiengAnh,out diemTiengAnh))
            {
                return;
            }

            int idhs = int.Parse(idHS);
            int idMonToan = GetIdByTenMon("toán");

            int idMonTV = GetIdByTenMon("việt");

            int idMonTA = GetIdByTenMon("anh");
            DanhSachLop hocSinh = danhSachHocSinh.Where(h => h.IDHS == idhs).FirstOrDefault();

            if (radioButtonCuoiHK1.Checked)
            {
                int idbxl = (int)hocSinh.IDBXL;
                Update_Diem_KyMot(idMonToan,idbxl,diemToan);
                Update_Diem_KyMot(idMonTA, idbxl, diemTiengAnh);
                Update_Diem_KyMot(idMonTV, idbxl, diemTiengViet);
            }
            else
            {
                int idbxl = (int)hocSinh.IDBXL;
                Update_Diem_KyHai(idMonToan, idbxl, diemToan);
                Update_Diem_KyHai(idMonTA, idbxl, diemTiengAnh);
                Update_Diem_KyHai(idMonTV, idbxl, diemTiengViet);
            }
                

            FillData(lop, dataGridViewCapNhatDiem);
        }
        private void Update_Diem_KyMot(int idMonHoc,int bxl, int diemKy1)
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
        private int GetIdByTenMon(string tenMon)
        {
            int maMon = monHoc.Where(m => m.TenMH.ToLower().Contains(tenMon)).Select(m => m.IDMH).FirstOrDefault();
            return maMon;
        }
        

        private bool CheckDiem_TextBox(TextBox textBox,out int diemOK)
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
    }
}
