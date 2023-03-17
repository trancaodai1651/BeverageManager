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
    public partial class frmThemNV : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmThemNV()
        {
            InitializeComponent();
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text != "" && txtTenNV.Text != "")
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = txtMaNV.Text;
                nv.TENNV = txtTenNV.Text;
                nv.SDTNV = txtDienThoaiNV.Text;
                nv.DIACHINV = txtDiaChiNV.Text;
                nv.EMAILNV = txtEmailNV.Text;
                dBQuanLyBanNGK.NHANVIENs.Add(nv);
                dBQuanLyBanNGK.SaveChanges();

                List<NHANVIEN> listNhanVien = dBQuanLyBanNGK.NHANVIENs.ToList();
                ucNhanVien.nv.FillDataDGV(listNhanVien);

                ucBanHang.bh.LoadNV();

                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }
        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Họ tên phải là kí tự chữ ", "Thông Báo ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtDienThoaiNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtEmailNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemNV.PerformClick();
            }
        }
    }
}
