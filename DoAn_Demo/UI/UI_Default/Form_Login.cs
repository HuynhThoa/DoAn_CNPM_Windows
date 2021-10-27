using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Demo
{
    public partial class Form_Login : Form
    {
 
        public Form_Login( )
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form_Menu form = new Form_Menu();
            this.Visible = false;
            form.Show();
            
        }

        public void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

       
    }
}
