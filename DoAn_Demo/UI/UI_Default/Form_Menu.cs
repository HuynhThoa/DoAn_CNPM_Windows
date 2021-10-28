using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_Demo.Entities;
using DoAn_Demo.Services;
using DoAn_Demo.UI;
using DoAn_Demo.UI.UI_Default;

namespace DoAn_Demo
{
    public partial class Form_Menu : Form
    {
        private GiaoVien user;
        private QLHSService service = new QLHSService();
        public Form_Menu(GiaoVien user)
        {
            InitializeComponent();
            this.user = user;
        }

    
  
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            panelMenu.Controls.Add(new UserControlXemGiaoVien(service.GetListGiaoVien()));
           
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolStripMenuItemTTGV_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlXemGiaoVien(service.GetListGiaoVien()));
        }

        private void ToolStripMenuItemQLHS_Click(object sender, EventArgs e)
        {

            panelMenu.Controls.Clear();
            if (!user.LoaiTaiKhoan)
            {
                string nienKhoa = DateTime.Now.Year.ToString().Substring(2);
                LopHoc lopHoc = service.GetLopHocBy(lop => lop.IDGV == user.IDGV && lop.IDLopHoc.Contains(nienKhoa));

                if(lopHoc != null)
                {
                    panelMenu.Controls.Add(new UserControlQLHS(lopHoc));
                    return;
                }
                else
                {
                    ShowMessErr("Bạn không có đảm nhiệm bất kỳ lớp nào trong năm nay");
                    return;
                }
            }
        }

        Action<string> ShowMessErr = s => MessageBox.Show(s,"Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);

        Action<string> ShowMessInfor= s => MessageBox.Show(s, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
