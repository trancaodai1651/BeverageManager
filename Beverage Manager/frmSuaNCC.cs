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
    public partial class frmSuaNCC : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmSuaNCC()
        {
            InitializeComponent();
            LoadThongTinNCC();
        }
        private void LoadThongTinNCC()
        {
            int nhacungcap = ucNhaCungCap.ncc.index;
            DataGridViewRow row = ucNhaCungCap.ncc.dgvNCC.Rows[nhacungcap];
            txtMaNCC.Text = row.Cells[0].Value.ToString();
            txtTenNCC.Text = row.Cells[1].Value.ToString();
            txtDienThoaiNCC.Text = row.Cells[2].Value.ToString();
            txtDiaChiNCC.Text = row.Cells[3].Value.ToString();
            txtEmailNCC.Text = row.Cells[4].Value.ToString();
        }
        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            NHACUNGCAP ncc = dBQuanLyBanNGK.NHACUNGCAPs.FirstOrDefault(p => p.MANCC == txtMaNCC.Text);
            if (ncc != null)
            {
                ncc.MANCC = txtMaNCC.Text;
                ncc.TENNCC = txtTenNCC.Text;
                ncc.SDTNCC = txtDienThoaiNCC.Text;
                ncc.DIACHINCC = txtDiaChiNCC.Text;
                ncc.EMAILNCC = txtEmailNCC.Text;
                dBQuanLyBanNGK.NHACUNGCAPs.AddOrUpdate(ncc);
                dBQuanLyBanNGK.SaveChanges();

                List<NHACUNGCAP> listNhaCungCap = dBQuanLyBanNGK.NHACUNGCAPs.ToList();
                ucNhaCungCap.ncc.FillDataDGV(listNhaCungCap);

                List<NHAPKHO> listnk = dBQuanLyBanNGK.NHAPKHOes.ToList();
                ucNhapKho.nk.FillDataDGV(listnk);

                this.Close();
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
                MessageBox.Show("Số điện thoại phải nhập là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void txtEmailNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaNCC.PerformClick();
            }
        }

        private void txtTenNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaNCC.PerformClick();
            }
        }

        private void txtDienThoaiNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaNCC.PerformClick();
            }
        }

        private void txtDiaChiNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaNCC.PerformClick();
            }
        }
    }
}
