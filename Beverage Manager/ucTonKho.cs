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

namespace Beverage_Manager.Resources
{
    public partial class TonKho : UserControl
    {
        public static TonKho tk;
        public Guna2DataGridView dgvtk;
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public TonKho()
        {
            InitializeComponent();
            tk = this;
            dgvtk = dgv_TK;
        }

        public void FillDataDGV(List<TONKHO> listtonkho)
        {
            dgv_TK.Rows.Clear();
            foreach (var item in listtonkho)
            {
                int RowNew = dgv_TK.Rows.Add();
                dgv_TK.Rows[RowNew].Cells[0].Value = item.IDSP;
                dgv_TK.Rows[RowNew].Cells[1].Value = item.SANPHAM.TENSP;
                dgv_TK.Rows[RowNew].Cells[2].Value = item.SLTON;
            }
        }

        private void dgv_TK_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgv_TK.Rows[e.RowIndex].Height = 40;
        }

        private void btnTimTK_Click(object sender, EventArgs e)
        {
            List<TONKHO> listTK = dBQuanLyBanNGK.TONKHOes.ToList();
            var listTimTK = listTK.Where(p => p.SANPHAM.MASP.ToLower().Contains(txtTimTK.Text.ToLower())
                                                             || p.SANPHAM.TENSP.ToLower().Contains(txtTimTK.Text.ToLower())).ToList();

            if (listTimTK.Count > 0)
            {
                FillDataDGV(listTimTK);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Sản Phẩm Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void TonKho_Load(object sender, EventArgs e)
        {
            List<TONKHO> listtonkho = dBQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
            FillDataDGV(listtonkho);
        }

    }
}
