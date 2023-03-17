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
    public partial class frmThemSP : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmThemSP()
        {
            InitializeComponent();
            LoadCB();
        }
        public void LoadCB()
        {
            cbDonViSP.DataSource = dBQuanLyBanNGK.DONVIs.ToList();
            cbDonViSP.DisplayMember = "TENDV";
            cbDonViSP.ValueMember = "MADV";
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if(txtMaSP.Text != "" && txtTenSP.Text != "")
            {
                SANPHAM sp = new SANPHAM();
                sp.MASP = txtMaSP.Text;
                sp.TENSP = txtTenSP.Text;
                sp.GIANHAP = float.Parse(txtGiaNhapSP.Text);
                sp.GIABAN = float.Parse(txtGiaBanSP.Text);
                sp.IDDV = cbDonViSP.SelectedValue.ToString();
                dBQuanLyBanNGK.SANPHAMs.Add(sp);
                dBQuanLyBanNGK.SaveChanges();

                List<SANPHAM> listSanPham = dBQuanLyBanNGK.SANPHAMs.ToList();
                ucSanPham.sp.FillDataDGV(listSanPham); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
        }
        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên sản phẩm phải là kí tự chữ ", "Thông Báo ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtGiaNhapSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Giá nhập phải là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtGiaBanSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Giá bán phải nhập là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtGiaBanSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemSP.PerformClick();
            }
        }
    }
}
