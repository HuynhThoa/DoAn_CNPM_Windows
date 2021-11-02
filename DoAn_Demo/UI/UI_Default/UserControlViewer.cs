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

namespace DoAn_Demo.UI.UI_Default
{
    public partial class UserControlViewer : UserControl
    {
        private List<GiaoVien> giaoViens;
        public UserControlViewer(List<GiaoVien> list)
        {
            InitializeComponent();
            giaoViens = list;
            FillDataGrid(giaoViens);
            
        }

        private void FillDataGrid(List<GiaoVien> giaoViens)
        {
            // xóa tất cả các hàng trong datagrid
            dataGridViewXemGiaoVien.Rows.Clear();

            foreach (GiaoVien gv in giaoViens)
            {
                string gioiTinh = gv.GioiTinh ? "Nam" : "Nữ";
                dataGridViewXemGiaoVien.Rows.Add(gv.IDGV, gv.HoTen, gv.SDT, gv.DC, gv.Email, gioiTinh);
            }
        }

        private void UserControlXemGiaoVien_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxSeachGV_TextChanged(object sender, EventArgs e)
        {
            string textFind = textBoxSeachGV.Text.Trim().ToLower();
            if (textFind.Length > 0)
            {
               
                List<GiaoVien> listFind = giaoViens.Where(  gv => gv.HoTen.ToLower().Contains(textFind) ||
                                                            gv.Email.ToLower().Contains(textFind) || 
                                                            gv.DC.ToLower().Contains(textFind)).ToList();

                FillDataGrid(listFind);

            }
            else
            {
                FillDataGrid(giaoViens);
            }

        }
    }
}
