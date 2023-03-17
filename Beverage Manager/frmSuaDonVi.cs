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
    public partial class frmSuaDonVi : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmSuaDonVi()
        {
            InitializeComponent();
            LoadThongTinNV();
        }
        private void LoadThongTinNV()
        {
            int donvi = ucDonVi.dv.index;
            DataGridViewRow row = ucDonVi.dv.dgvDV.Rows[donvi];
            txtMaDV.Text = row.Cells[0].Value.ToString();
            txtTenDV.Text = row.Cells[1].Value.ToString();
        }
        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            DONVI dv = dBQuanLyBanNGK.DONVIs.FirstOrDefault(p => p.MADV == txtMaDV.Text);
            if (dv != null)
            {
                dv.MADV = txtMaDV.Text;
                dv.TENDV = txtTenDV.Text;
                dBQuanLyBanNGK.DONVIs.AddOrUpdate(dv);
                dBQuanLyBanNGK.SaveChanges();
                List<DONVI> listDonVi = dBQuanLyBanNGK.DONVIs.ToList();
                ucDonVi.dv.FillDataDGV(listDonVi);

                List<SANPHAM> listsp = dBQuanLyBanNGK.SANPHAMs.ToList();
                ucSanPham.sp.FillDataDGV(listsp);

                List<DONVI> listdv = dBQuanLyBanNGK.DONVIs.ToList();
                ucSanPham.sp.cbtsp.DataSource = listdv;

                this.Close();
            }
        }
        private void txtTenDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên đơn vị phải là kí tự chữ ", "Thông Báo ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtTenDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaDV.PerformClick();
            }
        }
    }
}
