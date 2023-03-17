using Beverage_Manager.Models;
using Guna.UI2.WinForms;
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
    public partial class ucKhanhHang : UserControl
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();

        public static ucKhanhHang kh;
        public Guna2DataGridView dgvKH;
        public int index;
        public ucKhanhHang()
        {
            InitializeComponent();
            kh = this;
            dgvKH = dgvKhachHang;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemKH themKH = new frmThemKH();
            themKH.ShowDialog();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            frmSuaKH suaKH = new frmSuaKH();
            suaKH.ShowDialog();
        }

        private void KhanhHang_Load(object sender, EventArgs e)
        {
            List<KHACHHANG> listKhachHang = dBQuanLyBanNGK.KHACHHANGs.ToList();
            FillDataDGV(listKhachHang);
        }

        public void FillDataDGV(List<KHACHHANG> listKhachHang)
        {
            dgvKhachHang.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int RowNew = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[RowNew].Cells[0].Value = item.MAKH;
                dgvKhachHang.Rows[RowNew].Cells[1].Value = item.TENKH;
                dgvKhachHang.Rows[RowNew].Cells[2].Value = item.SDTKH;
                dgvKhachHang.Rows[RowNew].Cells[3].Value = item.DIACHIKH;
                dgvKhachHang.Rows[RowNew].Cells[4].Value = item.EMAILKH;
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void dgvKhachHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvKhachHang.Rows[e.RowIndex].Height = 40;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvKH.Rows[index];
                string iddv = row.Cells[0].Value.ToString();
                KHACHHANG kh = dBQuanLyBanNGK.KHACHHANGs.Find(iddv);
                dBQuanLyBanNGK.KHACHHANGs.Remove(kh);
                dBQuanLyBanNGK.SaveChanges();
                List<KHACHHANG> listKhachHang = dBQuanLyBanNGK.KHACHHANGs.ToList();
                FillDataDGV(listKhachHang);

                ucBanHang.bh.LoadKH();

                List<DONHANG> listdh = dBQuanLyBanNGK.DONHANGs.ToList();
                ucDonHang.dh.FillDataDGV(listdh);
            }

        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            List<KHACHHANG> listKH = dBQuanLyBanNGK.KHACHHANGs.ToList();
            var listTimKH = listKH.Where(p => (p is KHACHHANG) && (p as KHACHHANG).MAKH.ToLower().Contains(txtTimKH.Text.ToLower())
                                                               || (p as KHACHHANG).TENKH.ToLower().Contains(txtTimKH.Text.ToLower())).ToList();

            if (listTimKH.Count > 0)
            {
                FillDataDGV(listTimKH);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Khách Hàng Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
