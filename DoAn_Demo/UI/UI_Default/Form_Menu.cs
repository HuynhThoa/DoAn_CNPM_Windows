using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_Demo.Entities;
using DoAn_Demo.Reports.ModelReport;
using DoAn_Demo.Services;
using DoAn_Demo.UI;
using DoAn_Demo.UI.UI_Default;
using Microsoft.Reporting.WinForms;

namespace DoAn_Demo
{
    public partial class Form_Menu : Form
    {
        private GiaoVien user;
        private QLHSService service = new QLHSService();
        public Form_Menu( GiaoVien user)
        {
            InitializeComponent();
            this.user = user;
            if(!user.LoaiTaiKhoan)
            {
                ToolStripMenuItemQLTTGV.Visible = false;
                QLLHMenu.Visible = false;
                ToolStripMenuItemTK.Visible = false;
            }
            else
            {
                ToolStripMenuItemTTGV.Visible = false;
                tltipTaiKhoan.Visible = false;
            }
        }

    
  
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            if (user.LoaiTaiKhoan)
            {
                panelMenu.Controls.Add(new UserControlQLThongTinGiaoVien(user));
            }
            panelMenu.Controls.Add(new UserControlViewer(service.GetListGiaoVien()));
           
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolStripMenuItemTTGV_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlViewer(service.GetListGiaoVien()));
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

        private void ToolStripMenuItemHome_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            if (user.LoaiTaiKhoan)
            { 
                panelMenu.Controls.Add(new UserControlQLThongTinGiaoVien(user));
                return;
            }
            ToolStripMenuItemTTGV_Click(sender, e);
        }

        private void ToolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/it.nhk.hutech");
        }
        private List<XepLoaiHocSinh> GetListXepLoaiHocSinh()
        {
            List<XepLoaiHocSinh> xepLoais = service.GetListXepLoaiHocSinh();
            return xepLoais;
        }
        private void ToolStripMenuItemHSG_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlThongKe(1,GetListXepLoaiHocSinh()));

        }

        private void ToolStripMenuItemHSK_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlThongKe(2, GetListXepLoaiHocSinh()));
        }

        private void ToolStripMenuItemHSTB_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlThongKe(3, GetListXepLoaiHocSinh()));
        }

        private void ToolStripMenuItemHSLB_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlThongKe(4, GetListXepLoaiHocSinh()));
        }

        private void ToolStripMenuItemHSTH_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlThongKe(5, GetListXepLoaiHocSinh()));
        }

        private void ToolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýThôngTinGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlQLThongTinGiaoVien(user));
        }

        private void Form_Menu_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Form_Login _Login = new Form_Login();
            _Login.Show();
        }

        private void QLLHMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlQLLopHoc());
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau(user);
            f.ShowDialog();
        }
    }
}
