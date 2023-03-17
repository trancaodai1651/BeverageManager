using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beverage_Manager.Models;

namespace Beverage_Manager
{
    public partial class frmMenu : Form
    {

        public static frmMenu menu;
        public UserControl bh;
        public frmMenu()
        {
            InitializeComponent();
            menu = this;
            bh = banHang;
            
        }

        DBQuanLyBanNuocGiaiKhat DBQuanLyBanNuocGiaiKhat = new DBQuanLyBanNuocGiaiKhat();

        private void pcbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pcbLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new frmLogin().Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            sanPham.BringToFront();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            donHang.BringToFront();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            nhapKho.BringToFront();
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            tonKho.BringToFront();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            nhanVien.BringToFront();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            khanhHang.BringToFront();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            nhaCungCap.BringToFront();
        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            loai.BringToFront();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            banHang.BringToFront();
        }

        private void pcbClose_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(DialogResult.Yes == result)
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }

    }
}
