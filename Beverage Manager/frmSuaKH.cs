using Beverage_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Manager
{
    public partial class frmSuaKH : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmSuaKH()
        {
            InitializeComponent();
            LoadThongTinKH();
        }
        private void LoadThongTinKH()
        {
            int khachhang = ucKhanhHang.kh.index;
            DataGridViewRow row = ucKhanhHang.kh.dgvKH.Rows[khachhang];
            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtTenKH.Text = row.Cells[1].Value.ToString();
            txtDienThoaiKH.Text = row.Cells[2].Value.ToString();
            txtDiaChiKH.Text = row.Cells[3].Value.ToString();
            txtEmailKH.Text = row.Cells[4].Value.ToString();
        }
        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = dBQuanLyBanNGK.KHACHHANGs.FirstOrDefault(p => p.MAKH == txtMaKH.Text);
            if (kh != null)
            {
                kh.MAKH = txtMaKH.Text;
                kh.TENKH = txtTenKH.Text;
                kh.SDTKH = txtDienThoaiKH.Text;
                kh.DIACHIKH = txtDiaChiKH.Text;
                kh.EMAILKH = txtEmailKH.Text;
                dBQuanLyBanNGK.KHACHHANGs.AddOrUpdate(kh);
                dBQuanLyBanNGK.SaveChanges();
                List<KHACHHANG> listKhachHang = dBQuanLyBanNGK.KHACHHANGs.ToList();
                ucKhanhHang.kh.FillDataDGV(listKhachHang);

                ucBanHang.bh.LoadKH();

                this.Close();
            }
        }
        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên khách hàng phải là kí tự chữ ", "Thông Báo ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtDienThoaiKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Điện thoại phải là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtTenKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaKH.PerformClick();
            }
        }

        private void txtDienThoaiKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaKH.PerformClick();
            }
        }

        private void txtDiaChiKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaKH.PerformClick();
            }
        }

        private void txtEmailKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaKH.PerformClick();
            }
        }
    }
}
