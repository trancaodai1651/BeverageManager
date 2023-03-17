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
using Beverage_Manager.Resources;
using Guna.UI2.WinForms;

namespace Beverage_Manager
{
    public partial class ucSanPham : UserControl
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();

        public static ucSanPham sp;
        public Guna2DataGridView dgvSP;
        public Guna2ComboBox cbtsp;
        public int index;
        public ucSanPham()
        {
            InitializeComponent();
            sp = this;
            dgvSP = dgvSanPham;
            cbtsp = cbxTimSP;
        }
        private void dgvSanPham_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvSanPham.Rows[e.RowIndex].Height = 40;
        }
        public void SanPham_Load(object sender, EventArgs e)
        {
            List<SANPHAM> listSanPham = dBQuanLyBanNGK.SANPHAMs.ToList();
            FillDataDGV(listSanPham);
            FillDataCBX();

        }

        private void FillDataCBX()
        {
            cbxTimSP.DataSource = dBQuanLyBanNGK.DONVIs.ToList();
            cbxTimSP.DisplayMember = "TENDV";
            cbxTimSP.ValueMember = "MADV";
        }

        public void FillDataDGV(List<SANPHAM> listSanPham)
        {
            dgvSanPham.Rows.Clear();
            foreach (var item in listSanPham)
            {
                int RowNew = dgvSanPham.Rows.Add();
                dgvSanPham.Rows[RowNew].Cells[0].Value = item.MASP;
                dgvSanPham.Rows[RowNew].Cells[1].Value = item.TENSP;
                dgvSanPham.Rows[RowNew].Cells[2].Value = item.GIANHAP;
                dgvSanPham.Rows[RowNew].Cells[3].Value = item.GIABAN;
                if (item.IDDV != null)
                {
                    dgvSanPham.Rows[RowNew].Cells[4].Value = item.DONVI.TENDV;
                }
                else
                {
                    dgvSanPham.Rows[RowNew].Cells[4].Value = "Null";
                }
                
            }
        }


        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmThemSP themSP = new frmThemSP();
            themSP.ShowDialog();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            frmSuaSP suaSP = new frmSuaSP();
            suaSP.ShowDialog();
        }



        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvSP.Rows[index];
                string idsp = row.Cells[0].Value.ToString();
                SANPHAM sp = dBQuanLyBanNGK.SANPHAMs.Find(idsp);
                dBQuanLyBanNGK.SANPHAMs.Remove(sp);
                dBQuanLyBanNGK.SaveChanges();
                List<SANPHAM> listSanPham = dBQuanLyBanNGK.SANPHAMs.ToList();
                FillDataDGV(listSanPham);

                List<TONKHO> listtk = dBQuanLyBanNGK.TONKHOes.ToList();
                TonKho.tk.FillDataDGV(listtk);

                List<TONKHO> listSP = dBQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
                ucBanHang.bh.FillDataDGV(listSP);
            }


        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            List<SANPHAM> listSP = dBQuanLyBanNGK.SANPHAMs.ToList();
            var listTimSP = listSP.Where(p => p.MASP.ToLower().Contains(txtTimSP.Text.ToLower()) ||p.TENSP.ToLower().Contains(txtTimSP.Text.ToLower())).ToList();


            if (listTimSP.Count > 0)
            {
                FillDataDGV(listTimSP);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Sản Phẩm Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiemCbDV_Click(object sender, EventArgs e)
        {
            string iddv = cbxTimSP.SelectedValue.ToString();

            var result = dBQuanLyBanNGK.SANPHAMs.Where(p => p.IDDV == iddv).ToList();

            FillDataDGV(result);
        }
    }
}
