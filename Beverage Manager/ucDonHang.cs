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
    public partial class ucDonHang : UserControl
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();

        public static ucDonHang dh;
        public int mahoadon;


        public ucDonHang()
        {
            InitializeComponent();
            dh = this;
        }

        private void dgvDonHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvDonHang.Rows[e.RowIndex].Height = 40;
        }

        private void ucDonHang_Load(object sender, EventArgs e)
        {
            List<DONHANG> listDonHang = dBQuanLyBanNGK.DONHANGs.ToList();
            FillDataDGV(listDonHang);
        }

        public void FillDataDGV(List<DONHANG> listDonHang)
        {
            dgvDonHang.Rows.Clear();
            foreach (var item in listDonHang)
            {
                int RowNew = dgvDonHang.Rows.Add();
                dgvDonHang.Rows[RowNew].Cells[0].Value = item.MADH;
                dgvDonHang.Rows[RowNew].Cells[1].Value = item.NGAYLAP.Value.ToString("dd/MM/yyyy");

                if (item.IDKH != null)
                {
                    dgvDonHang.Rows[RowNew].Cells[2].Value = item.KHACHHANG.TENKH;
                }
                else
                {
                    dgvDonHang.Rows[RowNew].Cells[2].Value = "Null";
                }

                if (item.IDNV != null)
                {
                    dgvDonHang.Rows[RowNew].Cells[3].Value = item.NHANVIEN.TENNV;
                }
                else
                {
                    dgvDonHang.Rows[RowNew].Cells[3].Value = "Null";
                }

                dgvDonHang.Rows[RowNew].Cells[4].Value = item.TONGTIEN;
            }
        }

        private void btnTimDH_Click(object sender, EventArgs e)
        {


            if(txtTimDH.Text != "")
            {
                var LocNull = dBQuanLyBanNGK.DONHANGs.Where(p => p.IDKH != null && p.IDNV != null).ToList();

                var listTimDH = LocNull.Where(p => p.KHACHHANG.TENKH.ToLower().Contains(txtTimDH.Text.ToLower())
                                                                 || p.NHANVIEN.TENNV.ToLower().Contains(txtTimDH.Text.ToLower())).ToList();

                if (listTimDH.Count > 0)
                {
                    FillDataDGV(listTimDH);
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy Đơn Hàng Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                List<DONHANG> dh = dBQuanLyBanNGK.DONHANGs.ToList();
                FillDataDGV(dh);
            }



        }

        private void dgvDonHang_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvDonHang.Rows[e.RowIndex].Height = 40;
        }

        private void DH_btnXemCTDonHang_Click(object sender, EventArgs e)
        {
            if(dgvDonHang.SelectedRows.Count > 0)
            {
                frmXemCTHoaDon xemcthd = new frmXemCTHoaDon();
                xemcthd.ShowDialog();
            }
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int rowindex_dgvDonHang = e.RowIndex;
             mahoadon = int.Parse(dgvDonHang.Rows[rowindex_dgvDonHang].Cells[0].Value.ToString());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmMenu.menu.bh.BringToFront();
        }

        private void btnXemDHTheoNgay_Click(object sender, EventArgs e)
        {
            var listdh = dBQuanLyBanNGK.DONHANGs.Where(p => p.NGAYLAP.Value >= DTP_DH_TUNGAY.Value.Date && p.NGAYLAP <= DTP_DH_DENNGAY.Value.Date).ToList();
            FillDataDGV(listdh);
        }
    }
}
