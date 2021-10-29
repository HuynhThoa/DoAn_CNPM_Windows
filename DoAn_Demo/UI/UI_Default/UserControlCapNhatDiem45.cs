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
        private QLHSService service = new QLHSService();
        public UserControlCapNhatDiem45(LopHoc lopHoc)
        {
            InitializeComponent();
            this.lop = lopHoc;
            this.danhSachHocSinh = service.GetDanhSachLop(ds => ds.IDLopHoc == lop.IDLopHoc);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlCapNhatDiem45_Load(object sender, EventArgs e)
        {
            
        }

        private void FillData()
        {

        }
    }
}
