using DoAn_Demo.Entities;
using DoAn_Demo.Services;
using DoAn_Demo.UI.UI_Default;
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
    public partial class UserControlQLHS : UserControl
    {
        /// <summary>
        /// lớp học bao gồm giáo viên chủ nhiệm và loại lớp
        /// </summary>
        private LopHoc lop;
        /// <summary>
        /// Giao Viên Dam Nhiem Cua Lop
        /// </summary>
        private GiaoVien user;
        /// <summary>
        /// Học sinh của lơp
        /// </summary>
        private HocSinh hocSinh;
        /// <summary>
        /// danh sách học sinh của lớp
        /// </summary>
        private List<DanhSachLop> danhSachHocSinh;
      

        /// <summary>
        /// dịch vụ điều khiển các tác vụ trên các bảng
        /// </summary>
        private QLHSService service = new QLHSService();
        public UserControlQLHS(LopHoc lopHoc)
        {
            InitializeComponent();
            this.lop = lopHoc;
            this.danhSachHocSinh = service.GetDanhSachLop(ds => ds.IDLopHoc == lop.IDLopHoc);
            FillData(danhSachHocSinh);
            
        }

        private void FillData(List<DanhSachLop> danhSaches)
        {
            dataGridViewHocSinh.Rows.Clear();
            if (danhSaches != null)
            {
                foreach (DanhSachLop ds in danhSaches)
                {
                    string gioiTinh = ds.HocSinh.GioiTinh ? "Nam" : "Nữ";
                    dataGridViewHocSinh.Rows.Add(ds.IDHS, ds.HocSinh.TenHS, ds.HocSinh.TenPH, ds.HocSinh.NTNS, ds.HocSinh.GioiTinh,
                                                  ds.HocSinh.DiaChi, ds.HocSinh.SDT, ds.HocSinh.NNH);
                }
            }
        }

        private void UserControlQLHS_Load(object sender, EventArgs e)
        {
            radioButtonNamThemHS.Checked = true;
        }

        private void dataGridViewHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowIndex = dataGridViewHocSinh.Rows[e.RowIndex];

                // get value 
                string idHS = rowIndex.Cells[0].Value.ToString();
                string tenHS = rowIndex.Cells[1].Value.ToString();
                string tenPH = rowIndex.Cells[2].Value.ToString();
                string gioiTinh = rowIndex.Cells[4].Value.ToString();
                string diaChi = rowIndex.Cells[5].Value.ToString();
                string sdt = rowIndex.Cells[6].Value.ToString();
                DateTime nnh = Convert(rowIndex.Cells[7].Value.ToString());
                DateTime ntns = Convert(rowIndex.Cells[3].Value.ToString());

                // tabpage thêm học sinh
                textBoxNameThemHS.Text = tenHS;
                textBoxPhuHuynhThemHS.Text = tenPH;
                dateTimePickerNTNS.Value =
                dateTimePickerNTNSThemHS.Value = ntns;

                if (gioiTinh.Contains("Nam"))
                {
                    radioButtonNam.Checked =
                    radioButtonNamThemHS.Checked =  true;
                }
                else
                {
                    radioButtonNu.Checked =
                    radioButtonNuThemHS.Checked = true;
                }
                textBoxDiaChiThemHS.Text = diaChi;
                textBoxSDTThemHS.Text = sdt;
                dateTimePickerNNH.Value = 
                dateTimePickerNNHThemHS.Value = nnh;


                // tabpage sửa học sinh
                textBoxIDHS.Text = idHS;
                textBoxName.Text = tenHS;
                textBoxNamePH.Text = tenPH;
                textBoxDiaChi.Text = diaChi;
                textBoxSDT.Text = sdt;

                //tabpage xóa học sinh
                textBoxIDXoaHS.Text = idHS;
                
            }
            catch { }
        }

        /// <summary>
        /// chuyển string về thành datetime nếu string có dạng date time
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private DateTime Convert(string date)
        {
            string[] regex = { "/", " ", ":" };
            string[] arrStr = date.Split(regex,System.StringSplitOptions.RemoveEmptyEntries);

            int dd = int.Parse(arrStr[0]);
            int mm = int.Parse(arrStr[1]);
            int yyyy = int.Parse(arrStr[2]);
            int hh = int.Parse(arrStr[3]);
            return new DateTime(yyyy, mm, dd, hh, 00, 0);
        }

        private void checkBoxThoiHoc_Click(object sender, EventArgs e)
        {
            if (checkBoxThoiHoc.Checked)
            {
                dateTimePickerNTH.Visible = true;
                return;
            }
            dateTimePickerNTH.Visible = false;
        }

        private void tabPageCapNhatDiem_Click(object sender, EventArgs e)
        {
            

        }

        private void tabControlCNTTHocSinh_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlCNTTHocSinh.SelectedIndex == 1)
            {
                if (lop.IDLoaiLop < 4)
                {
                    panelCapNhatDiem.Controls.Clear();
                    panelCapNhatDiem.Controls.Add(new UserControlCapNhatDiem123(danhSachHocSinh));
                }
                else
                {
                    panelCapNhatDiem.Controls.Clear();
                    panelCapNhatDiem.Controls.Add(new UserControlCapNhatDiem45(danhSachHocSinh));
                }
            }
        }

        private void textBoxSeach_TextChanged(object sender, EventArgs e)
        {
            string txtTimKiem = textBoxSeach.Text.Trim();
            if (txtTimKiem.Length > 0)
            {
                List<DanhSachLop> list = danhSachHocSinh.Where( hs => hs.HocSinh.TenHS.Contains(txtTimKiem) || 
                                                                hs.HocSinh.TenPH.Contains(txtTimKiem) || 
                                                                hs.HocSinh.SDT.Contains(txtTimKiem)).ToList();
                FillData(list);
            }
            else
            {
                FillData(danhSachHocSinh);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Create_bangXepLoai();
                Create_CTBangDiem();

                HocSinh hs = new HocSinh();
            }
            catch (Exception ex)
            {
                ShowErr(ex.Message,"Exception");
            }

        }
        public bool Check_HoTen(string hoTen)
        {
            foreach (char c in hoTen)
            {
                if(c>= '0' && c <= '9')
                {
                    return false;
                }
            }
            return true;
        }
        Action<string, string> ShowErr = (s1, s2) => MessageBox.Show(s1, s2, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void Create_CTBangDiem()
        {
            BangXepLoai bangXepLoai = service.GetBangXepLoaiNew();
            List<MonHoc> monHocs = GetListMonHoc();
            CTBangDiem ct;
            foreach (MonHoc mon in monHocs)
            {
                ct = new CTBangDiem() { IDBXL = bangXepLoai.IDBXL, IDMH = mon.IDMH};
                service.AddCT_BangDiem(ct);
            }
        }
        public List<MonHoc> GetListMonHoc()
        {
            List<MonHoc> monHocs;
            switch (lop.IDLoaiLop)
            {
                case 1:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains('1'));
                    break;
                case 2:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains('2'));
                    break;
                case 3:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains('3'));
                    break;
                case 4:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains('4'));
                    break;
                default:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains('5'));
                    break;
            }
            return monHocs;
        }


        private void Create_bangXepLoai()
        {
            int nienKhoa = int.Parse(DateTime.Now.Year.ToString().Substring(2));
            BangXepLoai bangXepLoai = new BangXepLoai() { XepLoai = null, HanhKiem = null, NienKhoa = nienKhoa };
            service.CreateBangXepLoai(bangXepLoai);
        }
        Action<string> ShowMess = s => MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        /// <summary>
        /// kiểm tra ký tự có phải là số
        /// </summary>
        /// <param name="c"></param>
        /// <returns>true nếu là số</returns>
        private bool CheckNumber(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
            return false;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            int IDHS = int.Parse(textBoxIDXoaHS.Text);
            DanhSachLop danhSachLop = danhSachHocSinh.Where(ds => ds.IDHS == IDHS).FirstOrDefault();
            service.Remove_DSLop(danhSachLop);
            service.Save();
            List<DanhSachLop> danhSaches = service.GetDanhSachLop(ds => ds.IDLopHoc == lop.IDLopHoc);
            FillData(danhSaches);
            

            
        }

        private void textBoxIDXoaHS_TextChanged(object sender, EventArgs e)
        {
            string IDHS = textBoxIDXoaHS.Text.Trim();
            if (IDHS.Length > 0)
            {
                List<DanhSachLop> list = danhSachHocSinh.Where(hs => hs.HocSinh.IDHS.ToString().Contains(IDHS)).ToList();
                FillData(list);
            }
            else
            {
                FillData(danhSachHocSinh);
            }
            int length = IDHS.Length;

            if (length > 0)
            {


                if (!CheckNumber(IDHS[length - 1]))
                {
                    ShowMess("Vui lòng nhập số !!!");
                    textBoxIDXoaHS.Text = IDHS.Substring(0, length - 1);

                    return;
                }
            }
            
        }
    }
}
