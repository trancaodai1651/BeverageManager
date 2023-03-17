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

namespace Beverage_Manager
{
    public partial class frmXemNhapKho : Form
    {
        public frmXemNhapKho()
        {
            InitializeComponent();
        }

        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();


        public void FillDataDGV(List<CT_PNHAPKHO> list_ctnk)
        {
            NK_DGV_CTNK.Rows.Clear();

            foreach (var item in list_ctnk)
            {
                int RowNew = NK_DGV_CTNK.Rows.Add();
                NK_DGV_CTNK.Rows[RowNew].Cells[0].Value = item.IDSP;
                NK_DGV_CTNK.Rows[RowNew].Cells[1].Value = item.SANPHAM.TENSP;
                NK_DGV_CTNK.Rows[RowNew].Cells[2].Value = item.SL;
                NK_DGV_CTNK.Rows[RowNew].Cells[3].Value = item.THANHTIEN;
            }
        }

        private void frmXemNhapKho_Load(object sender, EventArgs e)
        {

            int madonhang = ucNhapKho.nk.madonhang;
            CTNK_TXT_MPhieu.Text = madonhang.ToString();
            List<CT_PNHAPKHO> list_ctnk = dBQuanLyBanNGK.CT_PNHAPKHO.Where(p => p.IDPNK == madonhang).ToList();
            FillDataDGV(list_ctnk);
        }

        private void NK_DGV_CTNK_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NK_DGV_CTNK.Rows[e.RowIndex].Height = 40;
        }

        private void frmXemNhapKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctbClose.PerformClick();
            }
        }
    }
}
