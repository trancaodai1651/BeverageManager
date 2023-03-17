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
    public partial class frmThemDonVi : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmThemDonVi()
        {
            InitializeComponent();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if(txtMaDV.Text != "" && txtTenDV.Text != "")
            {
                DONVI dv = new DONVI();

                dv.MADV = txtMaDV.Text;
                dv.TENDV = txtTenDV.Text;
                dBQuanLyBanNGK.DONVIs.Add(dv);
                dBQuanLyBanNGK.SaveChanges();

                List<DONVI> listDonVi = dBQuanLyBanNGK.DONVIs.ToList();
                ucDonVi.dv.FillDataDGV(listDonVi);

                List<DONVI> listdv = dBQuanLyBanNGK.DONVIs.ToList();
                ucSanPham.sp.cbtsp.DataSource = listdv;

                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
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
                btnThemDV.PerformClick();
            }
        }
    }
}
