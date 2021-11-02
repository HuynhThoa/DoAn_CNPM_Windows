using DoAn_Demo.Reports.ModelReport;
using Microsoft.Reporting.WinForms;

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
    public partial class UserControlThongKe : UserControl
    {
        private int GioiState = 1;
        private int KhaState = 2;
        private int TrungBinhState = 3;
        private int LuuBanState = 4;
        //private int ThoiHocState = 5;
        private List<XepLoaiHocSinh> danhSachXepLoaiHocSinhs;
        int state;
        public UserControlThongKe(int state, List<XepLoaiHocSinh> danhSachXepLoaiHocSinh)
        {
            InitializeComponent();
            this.danhSachXepLoaiHocSinhs = danhSachXepLoaiHocSinh;
            danhSachXepLoaiHocSinh.OrderBy(ds => ds.TenLop);
            this.state = state;
        }

        private void UserControlThongKe_Load(object sender, EventArgs e)
        {
            List<XepLoaiHocSinh> list = GetListTheoXepLoai(state);
            if(list is null)
            {
                MessageBox.Show("Tồn tại học sinh chưa có đủ điểm để thống kê", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            reportViewerThongKe.LocalReport.DataSources.Clear();
            reportViewerThongKe.LocalReport.ReportPath = @"../../Reports\ReportXepLoaiHocSinh.rdlc";
            ReportDataSource reportData = new ReportDataSource("DataSetXepLoai", list);
            reportViewerThongKe.LocalReport.DataSources.Add(reportData);
            reportViewerThongKe.LocalReport.Refresh();
            reportViewerThongKe.RefreshReport();

          
        }

        private List<XepLoaiHocSinh> GetListTheoXepLoai(int state)
        {
            List<XepLoaiHocSinh> list = new List<XepLoaiHocSinh>();
            string xepLoai = "";
            if(state == GioiState)
            {
                xepLoai = "giỏi";
            }
            else if(state == KhaState)
            {
                xepLoai = "khá";
            }
            else if (state == TrungBinhState)
            {
                xepLoai = "trung bình";
            }
            else if(state == LuuBanState)
            {
                xepLoai = "lưu ban";
            }
            
            int stt = 1;

            try
            {
                foreach (XepLoaiHocSinh i in danhSachXepLoaiHocSinhs)
                {
                    if (i.XepLoai is null)
                    {
                        return null;
                    }
                    if (i.XepLoai.ToLower().Contains(xepLoai))
                    {
                        i.STT = stt++;
                        list.Add(i);
                    }
                    if (i.NTH != null)
                    {
                        i.STT = stt++;
                        list.Add(i);
                    }
                }
            }
            catch { }
            return list;
        }
    }
}
