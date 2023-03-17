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
using Beverage_Manager.Models;

namespace Beverage_Manager
{
    public partial class frmSuaNV : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmSuaNV()
        {
            InitializeComponent();
            LoadThongTinNV();
        }
        private void LoadThongTinNV()
        {
            int nhanvien = ucNhanVien.nv.index;
            DataGridViewRow row = ucNhanVien.nv.dgvNV.Rows[nhanvien];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtDienThoaiNV.Text = row.Cells[2].Value.ToString();
            txtDiaChiNV.Text = row.Cells[3].Value.ToString();
            txtEmailNV.Text = row.Cells[4].Value.ToString();
        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = dBQuanLyBanNGK.NHANVIENs.FirstOrDefault(p => p.MANV == txtMaNV.Text);
            if (nv != null)
            {
                nv.MANV = txtMaNV.Text;
                nv.TENNV = txtTenNV.Text;
                nv.SDTNV = txtDienThoaiNV.Text;
                nv.DIACHINV = txtDiaChiNV.Text;
                nv.EMAILNV = txtEmailNV.Text;
                dBQuanLyBanNGK.NHANVIENs.AddOrUpdate(nv);
                dBQuanLyBanNGK.SaveChanges();

                List<NHANVIEN> listNhanVien = dBQuanLyBanNGK.NHANVIENs.ToList();
                ucNhanVien.nv.FillDataDGV(listNhanVien);

                ucBanHang.bh.LoadNV();

                List<NHAPKHO> listnk = dBQuanLyBanNGK.NHAPKHOes.ToList();
                ucNhapKho.nk.FillDataDGV(listnk);

                List<DONHANG> listdh = dBQuanLyBanNGK.DONHANGs.ToList();
                ucDonHang.dh.FillDataDGV(listdh);

                this.Close();
            }
        }
        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên nhân viên phải là kí tự chữ ", "Thông Báo ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtDienThoaiNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Điện thoại phải nhập là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void txtMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaNV.PerformClick();
            }
        }

        private void txtTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaNV.PerformClick();
            }
        }

        private void txtDienThoaiNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaNV.PerformClick();
            }
        }

        private void txtDiaChiNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaNV.PerformClick();
            }
        }

        private void txtEmailNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaNV.PerformClick();
            }
        }
    }
}
