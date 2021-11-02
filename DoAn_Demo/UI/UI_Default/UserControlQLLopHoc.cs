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
    public partial class UserControlQLLopHoc : UserControl
    {
        List<LopHoc> listLopHoc;
        QLHSService service = new QLHSService();
        List<GiaoVien> listGiaoVien;
        List<LoaiLop> listLoaiLop;
        public UserControlQLLopHoc()
        {
            InitializeComponent();
            listLopHoc = service.getListLopHoc();
            listGiaoVien = service.GetListGiaoVien();
            listLoaiLop = service.GetListLoaiLop();
        }

        private void radioButtonTao_CheckedChanged(object sender, EventArgs e)
        {
            RemoteTool(buttonThem, buttonCapNhat, buttonXoa);
            TurnOffOnControl(panel1, true);
            comboBoxGiaoVienCN.Enabled = comboBoxTenLoaiLop.Enabled = comboBoxTenLop.Enabled = true;
        }

        private void TurnOffOnControl(Control button,bool state)
        {
            button.Enabled = state;
        }
        private void RemoteTool(Button buttonThem, Button buttonCapNhat, Button buttonXoa)
        {
            buttonThem.Enabled = true;
            buttonCapNhat.Enabled = buttonXoa.Enabled = false;
        }

        private void radioButtonCapNhat_CheckedChanged(object sender, EventArgs e)
        {
            RemoteTool( buttonCapNhat, buttonThem, buttonXoa);
            TurnOffOnControl(panel1, true);
            comboBoxGiaoVienCN.Enabled = comboBoxTenLoaiLop.Enabled = comboBoxTenLop.Enabled = true;
        }

        private void radioButtonXoaLop_CheckedChanged(object sender, EventArgs e)
        {
            RemoteTool( buttonXoa, buttonCapNhat, buttonThem);
            TurnOffOnControl(panel1, true);
            comboBoxGiaoVienCN.Enabled = comboBoxTenLoaiLop.Enabled = comboBoxTenLop.Enabled = false;
        }

        private void UserControlQLLopHoc_Load(object sender, EventArgs e)
        {
            FillData(dataGridViewTTLopHoc, listLopHoc);
            FillData(dataGridViewDanhSachLopHoc, listLopHoc);
            comboBoxGiaoVienCN.DataSource = listGiaoVien;
            comboBoxGiaoVienCN.DisplayMember = "HoTen";
            comboBoxTenLoaiLop.DataSource = listLoaiLop;
            comboBoxTenLoaiLop.DisplayMember = "TenLoaiLop";
            comboBoxGiaoVienCN.SelectedIndex = comboBoxTenLoaiLop.SelectedIndex = comboBoxTenLop.SelectedIndex = 0;

        }

        private void FillData(DataGridView dataGridViewTTLopHoc, List<LopHoc> listLopHoc)
        {
            dataGridViewTTLopHoc.Rows.Clear();
            foreach (LopHoc l in listLopHoc)
            {
                dataGridViewTTLopHoc.Rows.Add(l.IDLopHoc, l.TenLop, l.SiSo, l.GiaoVien.HoTen, l.LoaiLop.TenLoaiLop);
            }
        }

        private void dataGridViewTTLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewTTLopHoc.Rows[e.RowIndex];
            string idlophoc = row.Cells[0].Value.ToString();
            string tenLop = row.Cells[1].Value.ToString().Substring(1);
            string tengv = row.Cells[3].Value.ToString();
            string tenloailop = row.Cells[4].Value.ToString();

            comboBoxGiaoVienCN.Text = tengv;
            comboBoxTenLop.Text = tenLop;
            comboBoxTenLoaiLop.Text = tenloailop;
            textBoxIDLopHoc.Text = idlophoc;

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string nienKhoa = DateTime.Now.Year.ToString().Substring(2);
            string tenLoaiLop = comboBoxTenLoaiLop.Text;
            string tenLop = comboBoxTenLop.Text;
            int idLoaiLop = listLoaiLop.Where(l => l.TenLoaiLop.Contains(tenLoaiLop)).Select(l => l.IDLoaiLop).FirstOrDefault();
            string idlophoc = nienKhoa + idLoaiLop + tenLop;
            string tengv = comboBoxGiaoVienCN.Text;
            int idgv = listGiaoVien.Where(g => g.HoTen.Equals(tengv)).Select(g => g.IDGV).FirstOrDefault();
            LopHoc oldLop = listLopHoc.Where(l => l.IDGV == idgv).FirstOrDefault();
            if(oldLop != null)
            {
                ShowErr("Giáo viên này hiện đang đảm nhiệm lớp khác, vui lòng không chọn");
                return;
            }
            LopHoc lop = listLopHoc.Where(l => l.IDLopHoc == idlophoc).FirstOrDefault();
            if(lop is null)
            {
                LopHoc lopHoc = new LopHoc();
                lopHoc.IDLopHoc = idlophoc;
                lopHoc.IDGV = idgv;
                lopHoc.TenLop = idLoaiLop + tenLop;
                lopHoc.IDLoaiLop = idLoaiLop;
                lopHoc.SiSo = 0;
                AddNewLopHoc(lopHoc);
                UpdateListLopHoc();
                FillData(dataGridViewTTLopHoc, listLopHoc);
                
                return;
            }
            ShowErr("tên lớp học này đã tồn tại vui lòng chọn tên lớp học khác");
            
        }

        private void UpdateLopHoc(LopHoc lopHoc)
        {
            service.UpdateLopHoc(lopHoc);
            service.Save();
        }

        private void AddNewLopHoc(LopHoc lopHoc)
        {
            service.addNewLopHoc(lopHoc);
            service.Save();
        }

        private void UpdateListLopHoc()
        {
            listLopHoc = service.getListLopHoc();
        }

        Action<string> ShowErr = s => MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Action<string> ShowInfo = s => MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void comboBoxGiaoVienCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = textBoxTimKiem.Text.Trim();
            if(timkiem.Length > 0)
            {
                List<LopHoc> lopHocs = listLopHoc.Where(l => l.GiaoVien.HoTen.Contains(timkiem)
                                        || l.TenLop.Contains(timkiem) || l.LoaiLop.TenLoaiLop.Contains(timkiem)).ToList();
                FillData(dataGridViewTTLopHoc, lopHocs);
            }
            else
            {
                FillData(dataGridViewTTLopHoc, listLopHoc);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string idlophoc = textBoxIDLopHoc.Text;
            if(idlophoc.Length > 0)
            {
                LopHoc lop = listLopHoc.Where(l => l.IDLopHoc == idlophoc).FirstOrDefault();
                DialogResult ok = MessageBox.Show("Bạn xác nhận xóa lớp học với thông tin" +
                    lop.IDLopHoc + "-" + lop.TenLop + "-" + lop.GiaoVien.HoTen + "-" + lop.LoaiLop.TenLoaiLop,
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ok == DialogResult.Yes)
                {
                    DeleteLopHoc(lop);
                    UpdateListLopHoc();
                    FillData(dataGridViewTTLopHoc, listLopHoc);
                    textBoxIDLopHoc.Text = null;
                    return;
                }
            }
        }

        private void DeleteLopHoc(LopHoc lop)
        {
            service.DeleteLopHoc(lop);
            service.Save();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            string idlophoc = textBoxIDLopHoc.Text;
            string tenLoaiLop = comboBoxTenLoaiLop.Text;
            string tenLop = comboBoxTenLop.Text;
            int idLoaiLop = listLoaiLop.Where(l => l.TenLoaiLop.Contains(tenLoaiLop)).Select(l => l.IDLoaiLop).FirstOrDefault();
            string tengv = comboBoxGiaoVienCN.Text;
            int idgv = listGiaoVien.Where(g => g.HoTen.Equals(tengv)).Select(g => g.IDGV).FirstOrDefault();
            LopHoc lop = listLopHoc.Where(l => l.IDLopHoc == idlophoc).FirstOrDefault();
            if (lop != null)
            {
                LopHoc lopHoc = new LopHoc();
                lopHoc.IDLopHoc = idlophoc;
                lopHoc.IDGV = idgv;
                lopHoc.TenLop = idLoaiLop + tenLop;
                lopHoc.IDLoaiLop = idLoaiLop;
                UpdateLopHoc(lopHoc);
                UpdateListLopHoc();
                FillData(dataGridViewTTLopHoc, listLopHoc);

                return;
            }
            ShowErr("tên lớp học này chưa tồn tại vui lòng chọn tên lớp học khác");
        }
    }
}
