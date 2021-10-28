using DoAn_Demo.Entities;
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
        private List<DanhSachLop> danhSachLop;

        public UserControlCapNhatDiem123(List<DanhSachLop> danhSachLop)
        {
            InitializeComponent();
            this.danhSachLop = danhSachLop;
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
    }
}
