using Beverage_Manager.Models;
using Beverage_Manager.Resources;
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
    public partial class frmSuaSP : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmSuaSP()
        {
            InitializeComponent();
            LoadCB();
            LoadThongTinSP();
           
        }
        private void LoadThongTinSP()
        {
            int sanpham = ucSanPham.sp.index;
            DataGridViewRow row = ucSanPham.sp.dgvSP.Rows[sanpham];
            S_txtMaSP.Text = row.Cells[0].Value.ToString();
            S_txtTenSP.Text = row.Cells[1].Value.ToString();
            S_txtGiaNhapSP.Text = row.Cells[2].Value.ToString();
            S_txtGiaBanSP.Text = row.Cells[3].Value.ToString();
            string valueDV = row.Cells[4].Value.ToString();
            int vt = S_cbDonViSP.FindString(valueDV);
            S_cbDonViSP.SelectedIndex = vt;
        }
        public void LoadCB()
        {
            S_cbDonViSP.DataSource = dBQuanLyBanNGK.DONVIs.ToList();
            S_cbDonViSP.DisplayMember = "TENDV";
            S_cbDonViSP.ValueMember = "MADV";
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            SANPHAM sp = dBQuanLyBanNGK.SANPHAMs.FirstOrDefault(p => p.MASP == S_txtMaSP.Text);
            if (sp != null)
            {
                sp.MASP = S_txtMaSP.Text;
                sp.TENSP = S_txtTenSP.Text;
                sp.IDDV = S_cbDonViSP.SelectedValue.ToString();
                sp.GIANHAP = float.Parse(S_txtGiaNhapSP.Text);
                sp.GIABAN = float.Parse(S_txtGiaBanSP.Text);
                dBQuanLyBanNGK.SANPHAMs.AddOrUpdate(sp);
                dBQuanLyBanNGK.SaveChanges();

                List<SANPHAM> listSanPham = dBQuanLyBanNGK.SANPHAMs.ToList();
                ucSanPham.sp.FillDataDGV(listSanPham);


                List<TONKHO> listtk = dBQuanLyBanNGK.TONKHOes.ToList();
                TonKho.tk.FillDataDGV(listtk);

                List<TONKHO> listSP = dBQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
                ucBanHang.bh.FillDataDGV(listSP);

                this.Close();

            }
        }
        private void S_txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên sản phẩm phải là kí tự chữ ", "Thông Báo ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void S_txtGiaNhapSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Giá nhập phải nhập là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void S_txtGiaBanSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Giá bán phải nhập là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void S_txtGiaBanSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaSP.PerformClick();
            }
        }

        private void S_txtTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaSP.PerformClick();
            }
        }

        private void S_cbDonViSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaSP.PerformClick();
            }
        }

        private void S_txtGiaNhapSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaSP.PerformClick();
            }
        }
    }
}
