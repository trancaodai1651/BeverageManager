using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beverage_Manager.Models;
using Guna.UI2.WinForms;


namespace Beverage_Manager
{
    public partial class ucNhanVien : UserControl
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();

        public static ucNhanVien nv;
        public Guna2DataGridView dgvNV;
        public int index;
        public ucNhanVien()
        {
            InitializeComponent();
            nv = this;
            dgvNV = dgvNhanVien;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemNV themNV = new frmThemNV();
            themNV.ShowDialog();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            frmSuaNV suaNV = new frmSuaNV();
            suaNV.ShowDialog();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> listNhanVien = dBQuanLyBanNGK.NHANVIENs.ToList();
            FillDataDGV(listNhanVien);
        }
        public void FillDataDGV(List<NHANVIEN> listNhanVien)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in listNhanVien)
            {
                int RowNew = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[RowNew].Cells[0].Value = item.MANV;
                dgvNhanVien.Rows[RowNew].Cells[1].Value = item.TENNV;
                dgvNhanVien.Rows[RowNew].Cells[2].Value = item.SDTNV;
                dgvNhanVien.Rows[RowNew].Cells[3].Value = item.DIACHINV;
                dgvNhanVien.Rows[RowNew].Cells[4].Value = item.EMAILNV;
            }
        }

        private void dgvNhanVien_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Height = 40;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvNV.Rows[index];
                string idnv = row.Cells[0].Value.ToString();
                NHANVIEN nv = dBQuanLyBanNGK.NHANVIENs.Find(idnv);
                dBQuanLyBanNGK.NHANVIENs.Remove(nv);
                dBQuanLyBanNGK.SaveChanges();

                List<NHANVIEN> listNhanVien = dBQuanLyBanNGK.NHANVIENs.ToList();
                FillDataDGV(listNhanVien);

                ucBanHang.bh.LoadNV();

                List<NHAPKHO> listtnk = dBQuanLyBanNGK.NHAPKHOes.ToList();
                ucNhapKho.nk.FillDataDGV(listtnk);

                List<DONHANG> listdh = dBQuanLyBanNGK.DONHANGs.ToList();
                ucDonHang.dh.FillDataDGV(listdh);
            }
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> listNV = dBQuanLyBanNGK.NHANVIENs.ToList();
            var listTimNV = listNV.Where(p => (p is NHANVIEN) && (p as NHANVIEN).MANV.ToLower().Contains(txtTimNV.Text.ToLower())
                                                              || (p as NHANVIEN).TENNV.ToLower().Contains(txtTimNV.Text.ToLower())).ToList();

            if (listTimNV.Count > 0)
            {
                FillDataDGV(listTimNV);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Nhân Viên Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
