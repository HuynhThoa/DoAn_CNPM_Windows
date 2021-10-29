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

        private QLHSService service = new QLHSService();
        public UserControlCapNhatDiem123(LopHoc lopHoc)
        {
            InitializeComponent();
            this.lop = lopHoc;
            this.danhSachHocSinh = service.GetDanhSachLop(ds => ds.IDLopHoc == lop.IDLopHoc);
           
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonCuoiHK1_Click(object sender, EventArgs e)
        {
           
        }

        private void remote(Control control,object[] contol)
        {

        }

        private void UserControlCapNhatDiem123_Load(object sender, EventArgs e)
        {
            radioButtonCuoiHK1.Checked = true;
            textBoxIDCapNhatDiem.Enabled = false;
            textBoxTiengAnh.Enabled = false;
            textBoxTiengViet.Enabled = false;
            FillData(lop, dataGridViewCapNhatDiem);
        }

        private void FillData(LopHoc lop,DataGridView data)
        {
          
                service.FillDataBangDiem(lop, data);
            
        }
    }
}
