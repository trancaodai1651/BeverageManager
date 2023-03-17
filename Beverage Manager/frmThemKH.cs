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
    public partial class frmThemKH : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmThemKH()
        {
            InitializeComponent();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {            
            if(txtMaKH.Text != "" && txtTenKH.Text != "")
            {
                KHACHHANG kh = new KHACHHANG();
                kh.MAKH = txtMaKH.Text;
                kh.TENKH = txtTenKH.Text;
                kh.SDTKH = txtDienThoaiKH.Text;
                kh.DIACHIKH = txtDiaChiKH.Text;
                kh.EMAILKH = txtEmailKH.Text;

                dBQuanLyBanNGK.KHACHHANGs.Add(kh);
                dBQuanLyBanNGK.SaveChanges();

                List<KHACHHANG> listKhanhHang = dBQuanLyBanNGK.KHACHHANGs.ToList();
                ucKhanhHang.kh.FillDataDGV(listKhanhHang);

                ucBanHang.bh.LoadKH();

                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            }
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Họ tên phải là kí tự chữ ", "Thông Báo ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void txtDienThoaiKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void txtEmailKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemKH.PerformClick();
            }
        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {

        }
    }
}
