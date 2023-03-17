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
    public partial class ucNhapKho : UserControl
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public static ucNhapKho nk;
        public Guna2DataGridView dgvnk;

        public int madonhang;
        public ucNhapKho()
        {
            InitializeComponent();
            //LoadData();
            nk = this;
            dgvnk = dgvNHAPKHO;
        }
        public void FillDataDGV(List<NHAPKHO> listnhapkho)
        {
            dgvNHAPKHO.Rows.Clear();
            foreach (var item in listnhapkho)
            {
                int RowNew = dgvNHAPKHO.Rows.Add();
                dgvNHAPKHO.Rows[RowNew].Cells[0].Value = item.MAPNK;

                if (item.IDNCC != null)
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[1].Value = item.NHACUNGCAP.TENNCC;
                }
                else
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[1].Value = "Null";
                }

                dgvNHAPKHO.Rows[RowNew].Cells[2].Value = item.NGAYNHAP.Value.ToString("dd/MM/yyyy");

                if(item.IDNV != null)
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[3].Value = item.NHANVIEN.TENNV;
                }
                else
                {
                    dgvNHAPKHO.Rows[RowNew].Cells[3].Value = "Null";
                }

                dgvNHAPKHO.Rows[RowNew].Cells[4].Value = item.TONGTIEN;
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            frmNhapKho nhapKho = new frmNhapKho();
            nhapKho.ShowDialog();
        }

        private void ucNhapKho_Load(object sender, EventArgs e)
        {
            List<NHAPKHO> listnhapkho = dBQuanLyBanNGK.NHAPKHOes.ToList();
            FillDataDGV(listnhapkho);
        }

        private void btnXemPNK_Click(object sender, EventArgs e)
        {
            if(dgvNHAPKHO.SelectedRows.Count > 0)
            {
                frmXemNhapKho nhapKho = new frmXemNhapKho();
                nhapKho.ShowDialog();
            }
        }

        private void btnTimNK_Click(object sender, EventArgs e)
        {

            var LocNull = dBQuanLyBanNGK.NHAPKHOes.Where(p => p.IDNV != null && p.IDNCC != null).ToList();

            var listTimPHK = LocNull.Where(p => p.NHACUNGCAP.TENNCC.ToLower().Contains(txtTimNK.Text.ToLower())
                                                             || p.NHANVIEN.TENNV.ToLower().Contains(txtTimNK.Text.ToLower())).ToList();


            if (listTimPHK.Count > 0)
            {
                FillDataDGV(listTimPHK);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Phiếu Nhập Kho Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvNHAPKHO_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvNHAPKHO.Rows[e.RowIndex].Height = 40;
        }

        private void dgvNHAPKHO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex_ctnk = e.RowIndex;
            madonhang = int.Parse(dgvNHAPKHO.Rows[rowindex_ctnk].Cells[0].Value.ToString());
        }

        private void btnXemDHTheoNgay_Click(object sender, EventArgs e)
        {
            var listdh = dBQuanLyBanNGK.NHAPKHOes.Where(p => p.NGAYNHAP.Value >= DTP_DH_TUNGAY.Value.Date && p.NGAYNHAP <= DTP_DH_DENNGAY.Value.Date).ToList();
            FillDataDGV(listdh);
        }
    }
}
