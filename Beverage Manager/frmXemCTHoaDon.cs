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
    public partial class frmXemCTHoaDon : Form
    {
        public frmXemCTHoaDon()
        {
            InitializeComponent();
        }

        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();

        public void FillDataDGV(List<CT_DONHANG> list_ctdh)
        {
            DH_DGV_CTHD.Rows.Clear();

            foreach (var item in list_ctdh)
            {
                int RowNew = DH_DGV_CTHD.Rows.Add();

                if (item.MASP != null)
                {
                    DH_DGV_CTHD.Rows[RowNew].Cells[0].Value = item.MASP;
                }
                else
                {
                    DH_DGV_CTHD.Rows[RowNew].Cells[0].Value = "Null";
                }
       

                if(item.MASP != null)
                {
                    DH_DGV_CTHD.Rows[RowNew].Cells[1].Value = item.SANPHAM.TENSP;
                }
                else
                {
                    DH_DGV_CTHD.Rows[RowNew].Cells[1].Value = "Null";
                }

                DH_DGV_CTHD.Rows[RowNew].Cells[2].Value = item.SL;
                DH_DGV_CTHD.Rows[RowNew].Cells[3].Value = item.THANHTIEN;
            }
        }

        private void frmXemCTHoaDon_Load(object sender, EventArgs e)
        {
            int madonhang = ucDonHang.dh.mahoadon;
            CTHD_TXT_MHDON.Text = madonhang.ToString();
            List<CT_DONHANG> list_ctdh = dBQuanLyBanNGK.CT_DONHANG.Where(p => p.MADH == madonhang).ToList();
            FillDataDGV(list_ctdh);
        }

        private void frmXemCTHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctbClose.PerformClick();
            }
        }

        private void DH_DGV_CTHD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DH_DGV_CTHD.Rows[e.RowIndex].Height = 40;
        }
    }
}
