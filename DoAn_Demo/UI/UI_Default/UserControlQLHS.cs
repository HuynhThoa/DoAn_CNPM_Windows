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
        private  LopHoc lop;
        /// <summary>
        /// Giao Viên Dam Nhiem Cua Lop
        /// </summary>
        private  GiaoVien user;
        /// <summary>
        /// Học sinh của lơp
        /// </summary>
        private  HocSinh hocSinh;
        /// <summary>
        /// danh sách học sinh của lớp
        /// </summary>
        private  List<DanhSachLop> danhSachHocSinh;
      

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


        #region method
        private void FillData(List<DanhSachLop> danhSaches)
        {
            dataGridViewHocSinh.Rows.Clear();
            if (danhSaches != null)
            {

                foreach (DanhSachLop ds in danhSaches)
                {
                    string gioiTinh = ds.HocSinh.GioiTinh ? "Nam" : "Nữ";
                    dataGridViewHocSinh.Rows.Add(ds.IDHS, ds.HocSinh.TenHS, ds.HocSinh.TenPH, ds.HocSinh.NTNS,gioiTinh,
                                                  ds.HocSinh.DiaChi, ds.HocSinh.SDT, ds.HocSinh.NNH);
                }

            }
        }
        private DateTime Convert(string date)
        {
            string[] regex = { "/", " ", ":" };
            string[] arrStr = date.Split(regex, System.StringSplitOptions.RemoveEmptyEntries);

            int dd = int.Parse(arrStr[0]);
            int mm = int.Parse(arrStr[1]);
            int yyyy = int.Parse(arrStr[2]);
            int hh = int.Parse(arrStr[3]);
            return new DateTime(yyyy, mm, dd, hh, 00, 0);
        }

        public bool Check_HoTen(string hoTen)
        {
            foreach (char c in hoTen)
            {
                if (c >= '0' && c <= '9')
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
                ct = new CTBangDiem() { IDBXL = bangXepLoai.IDBXL, IDMH = mon.IDMH };
                service.AddCT_BangDiem(ct);
            }
        }
        public List<MonHoc> GetListMonHoc()
        {
            List<MonHoc> monHocs;
            switch (lop.IDLoaiLop)
            {
                case 1:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains("1"));
                    break;
                case 2:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains("2"));
                    break;
                case 3:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains("3"));
                    break;
                case 4:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains("4"));
                    break;
                default:
                    monHocs = service.GetDanhSachMonHocBy(m => m.TenMH.Contains("5"));
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

        Action<string> ShowInfo = s => MessageBox.Show(s,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

        #endregion



        #region events

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
                    radioButtonNamThemHS.Checked = true;
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
                List<DanhSachLop> list = danhSachHocSinh.Where(hs => hs.HocSinh.TenHS.Contains(txtTimKiem) ||
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
                bool check_Data = Check_Data_Exists(textBoxNameThemHS, textBoxPhuHuynhThemHS,textBoxDiaChiThemHS,textBoxSDTThemHS);
                if (!check_Data) return;
                //tên học sinh
                string tenHS = textBoxNameThemHS.Text.Trim();
                string tenPH = textBoxPhuHuynhThemHS.Text.Trim();
                string diaChi = textBoxDiaChiThemHS.Text.Trim();
                string sdt = textBoxSDTThemHS.Text.Trim();
               

                //ngay thang
                DateTime ntns = dateTimePickerNTNSThemHS.Value;
                DateTime nnh = dateTimePickerNNHThemHS.Value;

                // check giới tính
                bool gioiTinh = false;
                if (radioButtonNamThemHS.Checked)
                {
                    gioiTinh = true;
                }


                Create_bangXepLoai();
                service.Save();
                Create_CTBangDiem();
                service.Save();

                HocSinh hs = new HocSinh() { TenHS = tenHS, TenPH = tenPH, GioiTinh = gioiTinh, DiaChi = diaChi, NTNS = ntns, NNH = nnh, SDT = sdt };
                service.Add_HS(hs);
                service.Save();

                service.JoinLopHoc(lop);
                service.Save();

                ShowInfo("Thêm sinh viên thành công");
                danhSachHocSinh = service.GetDanhSachLop(l => l.IDLopHoc == lop.IDLopHoc);
                FillData(danhSachHocSinh);
                
            }
            catch (Exception ex)
            {
                ShowErr(ex.Message, "Exception");
            }

        }

        /// <summary>
        /// check data exist in textbox
        /// </summary>
        /// <param name="textBoxNameThemHS">tên học sinh</param>
        /// <param name="textBoxPhuHuynhThemHS">tên phụ huynh</param>
        /// <param name="textBoxDiaChiThemHS">địa chỉ</param>
        /// <param name="textBoxSDT">sdt </param>
        /// <returns>true if all true else false</returns>
        private bool Check_Data_Exists(TextBox textBoxNameThemHS, TextBox textBoxPhuHuynhThemHS, TextBox textBoxDiaChiThemHS, TextBox textBoxSDTThemHS)
        {
            string tenHS = textBoxNameThemHS.Text.Trim();
            if (!Check_HoTen(tenHS) || tenHS.Length <= 0)
            {
                ShowErr("Tên không hợp lệ, không được để trống tên, và không xuất hiện số trong tên", "Lỗi");
                return false;
            }

            string tenPH = textBoxPhuHuynhThemHS.Text.Trim();
            if (tenPH.Length <= 0 || !Check_HoTen(tenPH))
            {
                ShowErr("Tên không hợp lệ, không được để trống tên, và không xuất hiện số trong tên", "Lỗi");
                return false ;
            }
            string diaChi = textBoxDiaChiThemHS.Text.Trim();

            if (diaChi.Length <= 0)
            {
                ShowErr("địa chỉ không được bỏ trống", "Lỗi");
                return false;
            }
            //sdt
            string sdt = textBoxSDTThemHS.Text.Trim();
            if (sdt.Length < 9)
            {
                ShowErr("Số điện thoại phải > 9 và nhỏ hơn 13", "Thông báo");
                return false;
            }
            return true;

        }

        private void textBoxIDHS_TextChanged(object sender, EventArgs e)
        {
            string idHS = textBoxIDHS.Text.Trim();
            if (idHS.Length > 0)
            {
                int id;
                bool parseId = int.TryParse(idHS, out id);
                if (parseId)
                {
                    List<DanhSachLop> hocSinhs = service.GetDanhSachLop(hs => hs.IDHS == id);
                    FillData(hocSinhs);
                    return;
                }
                textBoxIDHS.Text = null;
                ShowErr("ID phải là số", "Thông báo");
            }
            else
            {
                FillData(danhSachHocSinh);
            }
            

        }



        private void textBoxNameThemHS_TextChanged(object sender, EventArgs e)
        {
            string name = textBoxNameThemHS.Text.Trim();

            if (name.Length > 100)
            {
                ShowErr("Kích thước tối đa 100 ký tự", "Thông báo");
                textBoxNameThemHS.Text = name.Substring(0, name.Length - 1);
                return;
            }
        }

        private void textBoxDiaChiThemHS_TextChanged(object sender, EventArgs e)
        {
            string dc = textBoxDiaChiThemHS.Text.Trim();
            if (dc.Length > 200)
            {
                ShowErr("Kích thước tối đa 200 ký tự", "Thông báo");
                textBoxNameThemHS.Text = dc.Substring(0, dc.Length - 1);
                return;
            }
        }

        #endregion

        private void textBoxSDTThemHS_TextChanged(object sender, EventArgs e)
        {
            string sdt = textBoxSDTThemHS.Text.Trim();
            if (sdt.Length > 12)
            {
                ShowErr("Kích thước tối đa 12 ký tự", "Thông báo");
                textBoxNameThemHS.Text = sdt.Substring(0, sdt.Length - 1);
                return;
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

        
        private void textBoxIDHS_Leave(object sender, EventArgs e)
        {
            string idHS = textBoxIDHS.Text.Trim();

            if(idHS.Length > 0)
            {
                int idhs = int.Parse(idHS);
                DanhSachLop hocSinhInDanhSach = service.GetDanhSachLop(hs => hs.IDHS == idhs).FirstOrDefault();
                if(hocSinhInDanhSach == null)
                {
                    ShowErr("Không tồn tại học sinh với ID này","Thông báo");
                    textBoxIDHS.Text = null;
                    return;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check_Data = Check_Data_Exists(textBoxName, textBoxNamePH, textBoxDiaChi, textBoxSDT);
            if (!check_Data) return;

            /// get attribute Hoc Sinh
            int iDHS;
            bool parseId = int.TryParse(textBoxIDHS.Text.Trim(),out iDHS);
            if(!parseId)
            {
                ShowErr("Id học sinh không được bỏ trống", "thông báo");
                return;
            }

            string tenHS = textBoxName.Text.Trim();
            string tenPH = textBoxNamePH.Text.Trim();
            string diaChi = textBoxDiaChi.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            bool gioiTinh = false;
            if (radioButtonNam.Checked)
            {
                gioiTinh = true;
            }
            DateTime ntns = dateTimePickerNTNS.Value;
            DateTime nnh = dateTimePickerNNH.Value;
            DateTime nth ;

            HocSinh hocSinh = new HocSinh() { IDHS = iDHS, TenHS = tenHS, TenPH = tenPH, DiaChi = diaChi, SDT = sdt, NTNS = ntns, NNH = nnh};

            if (checkBoxThoiHoc.CheckState == CheckState.Checked)
            {
                nth = dateTimePickerNTH.Value;
                hocSinh.NTH = nth;
            }
            
            service.Update_Infor_HocSinh(hocSinh);
            service.Save();
            ShowInfo("Sửa thông tin sinh viên thành công");

            FillData(danhSachHocSinh);

        }
    }
}
