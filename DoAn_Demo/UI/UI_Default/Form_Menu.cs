using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_Demo.UI;
using DoAn_Demo.UI.UI_Default;

namespace DoAn_Demo
{
    public partial class Form_Menu : Form
    {

        public Form_Menu()
        {
            InitializeComponent(); 
        }

    
  
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            panelMenu.Controls.Add(new UserControlXemGiaoVien());
           
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolStripMenuItemTTGV_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlXemGiaoVien());
        }

        private void ToolStripMenuItemQLHS_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UserControlCapNhatDiem123());
        }
    }
}
