using Beverage_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Manager
{
    public partial class frmThemNCC : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmThemNCC()
        {
            InitializeComponent();
        }
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            if(txtMaNCC.Text != "" && txtTenNCC.Text != "")
            {
                NHACUNGCAP ncc = new NHACUNGCAP();
                ncc.MANCC = txtMaNCC.Text;
                ncc.TENNCC = txtTenNCC.Text;
                ncc.SDTNCC = txtDienThoaiNCC.Text;
                ncc.DIACHINCC = txtDiaChiNCC.Text;
                ncc.EMAILNCC = txtEmailNCC.Text;
                dBQuanLyBanNGK.NHACUNGCAPs.Add(ncc);
                dBQuanLyBanNGK.SaveChanges();

                List<NHACUNGCAP> listNhaCungCap = dBQuanLyBanNGK.NHACUNGCAPs.ToList();
                ucNhaCungCap.ncc.FillDataDGV(listNhaCungCap);

                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
        }
        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên nhà cung cấp phải là kí tự chữ ", "Thông Báo ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtDienThoaiNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void txtEmailNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemNCC.PerformClick();
            }
        }
    }
}
