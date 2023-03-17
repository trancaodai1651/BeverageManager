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
    public partial class ucDonVi : UserControl
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public static ucDonVi dv;
        public Guna2DataGridView dgvDV;
        public int index;
        public ucDonVi()
        {
            InitializeComponent();
            dv = this;
            dgvDV = dgvDonVi;
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            frmThemDonVi themLoai = new frmThemDonVi();
            themLoai.ShowDialog();
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            frmSuaDonVi suaLoai = new frmSuaDonVi();
            suaLoai.ShowDialog();
        }

        private void DonVi_Load(object sender, EventArgs e)
        {
            List<DONVI> listDonVi = dBQuanLyBanNGK.DONVIs.ToList();
            FillDataDGV(listDonVi);
        }

        public void FillDataDGV(List<DONVI> listDonVi)
        {
            dgvDonVi.Rows.Clear();
            foreach (var item in listDonVi)
            {
                int RowNew = dgvDonVi.Rows.Add();
                dgvDonVi.Rows[RowNew].Cells[0].Value = item.MADV;
                dgvDonVi.Rows[RowNew].Cells[1].Value = item.TENDV;
            }
        }

        private void dgvDonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void dgvDonVi_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvDonVi.Rows[e.RowIndex].Height = 40;
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvDV.Rows[index];
                string iddv = row.Cells[0].Value.ToString();
                DONVI dv = dBQuanLyBanNGK.DONVIs.Find(iddv);
                dBQuanLyBanNGK.DONVIs.Remove(dv);
                dBQuanLyBanNGK.SaveChanges();

                List<DONVI> listDonVi = dBQuanLyBanNGK.DONVIs.ToList();
                FillDataDGV(listDonVi);

                List<SANPHAM> listsp = dBQuanLyBanNGK.SANPHAMs.ToList();
                ucSanPham.sp.FillDataDGV(listsp);

                List<DONVI> listdv = dBQuanLyBanNGK.DONVIs.ToList();
                ucSanPham.sp.cbtsp.DataSource = listdv;
            }
        }

        private void btnTimDV_Click(object sender, EventArgs e)
        {
            List<DONVI> listDV = dBQuanLyBanNGK.DONVIs.ToList();
            var listTimDV = listDV.Where(p => p.MADV.ToLower().Contains(txtTimDV.Text.ToLower())
                                                           || p.TENDV.ToLower().Contains(txtTimDV.Text.ToLower())).ToList();

            if (listTimDV.Count > 0)
            {
                FillDataDGV(listTimDV);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Đơn Vị Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
