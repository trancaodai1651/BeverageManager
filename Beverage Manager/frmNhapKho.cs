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
using System.Data.Entity.Migrations;

namespace Beverage_Manager
{
    public partial class frmNhapKho : Form
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public frmNhapKho()
        {
            InitializeComponent();
        }
        public void LoadNCC()
        {
            NK_CB_NCC.DataSource = dBQuanLyBanNGK.NHACUNGCAPs.ToList();
            NK_CB_NCC.DisplayMember = "TENNCC";
            NK_CB_NCC.ValueMember = "MANCC";
        }
        public void LoadNV()
        {
            NK_CB_NV.DataSource = dBQuanLyBanNGK.NHANVIENs.ToList();
            NK_CB_NV.DisplayMember = "TENNV";
            NK_CB_NV.ValueMember = "MANV";
        }
        public void LoadSP()
        {
            NK_CB_SP.DataSource = dBQuanLyBanNGK.SANPHAMs.ToList();
            NK_CB_SP.DisplayMember = "TENSP";
            NK_CB_SP.ValueMember = "MASP";
        }
        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            LoadNCC();
            LoadNV();
            LoadSP();
            NK_DATENK.Value = DateTime.Now;
        }
        public void FillDataDGV(List<CT_PNHAPKHO> listctnk)
        {
            NK_DGV_CTNK.Rows.Clear();
            foreach (var item in listctnk)
            {
                int RowNew = NK_DGV_CTNK.Rows.Add();
                NK_DGV_CTNK.Rows[RowNew].Cells[0].Value = item.SANPHAM.TENSP;
                NK_DGV_CTNK.Rows[RowNew].Cells[1].Value = item.SL;
                NK_DGV_CTNK.Rows[RowNew].Cells[2].Value = item.THANHTIEN;
            }
        }
        public void ThemCTNhapKho()
        {
            int row = NK_DGV_CTNK.Rows.Add();
            string idsp_combobox = NK_CB_SP.SelectedValue.ToString();
            NK_DGV_CTNK.Rows[row].Cells[0].Value = idsp_combobox;
            NK_DGV_CTNK.Rows[row].Cells[1].Value = NK_CB_SP.Text;
            NK_DGV_CTNK.Rows[row].Cells[2].Value = NK_TXT_SL.Text;
            var sp = dBQuanLyBanNGK.SANPHAMs.FirstOrDefault(p => p.MASP == idsp_combobox);
            int sl = int.Parse(NK_TXT_SL.Text);
            double thanhtien = double.Parse(sp.GIANHAP.Value.ToString()) * sl;
            NK_DGV_CTNK.Rows[row].Cells[3].Value = thanhtien.ToString();
        }
        //Lay ra so dong ton tai trong ct_phieu nhap kho
        public int LayDongTonTai()
        {
            int sodong = NK_DGV_CTNK.Rows.Count;
            string valueCBHienTai = NK_CB_SP.SelectedValue.ToString();
            for (int i = 0; i < sodong; i++)
            {
                string KTTonTaiIDSP = NK_DGV_CTNK.Rows[i].Cells[0].Value.ToString();
                //MessageBox.Show(KTTonTaiIDSP);
                if (valueCBHienTai == KTTonTaiIDSP)
                {
                    return i;
                }
            }

            return -1;
        }
        public void XuLyThemCTNhapKho()
        {
            if(NK_TXT_SL.Text != "")
            {
                int sodong = NK_DGV_CTNK.Rows.Count;

                if (sodong == 0)
                {
                    ThemCTNhapKho();
                }
                else
                {
                    if (LayDongTonTai() != -1)
                    {
                        int sl = int.Parse(NK_TXT_SL.Text);
                        int slhientai = int.Parse(NK_DGV_CTNK.Rows[LayDongTonTai()].Cells[2].Value.ToString());
                        slhientai += sl;
                        NK_DGV_CTNK.Rows[LayDongTonTai()].Cells[2].Value = slhientai.ToString();

                        //Cap nhat lai thanh tien khi tang slsp
                        double thanhtienhientai = double.Parse(NK_DGV_CTNK.Rows[LayDongTonTai()].Cells[3].Value.ToString());
                        string checkma = NK_DGV_CTNK.Rows[LayDongTonTai()].Cells[0].Value.ToString();
                        var sp = dBQuanLyBanNGK.SANPHAMs.FirstOrDefault(p => p.MASP == checkma);
                        double gianhap = double.Parse(sp.GIANHAP.ToString());
                        NK_DGV_CTNK.Rows[LayDongTonTai()].Cells[3].Value = thanhtienhientai + gianhap * sl;
                    }
                    else
                    {
                        ThemCTNhapKho();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo");
            }
        }
        private void NK_BTN_THEM_CTNK_Click(object sender, EventArgs e)
        {
            XuLyThemCTNhapKho();
        }
        // tinh tong tien
        private double TongTien()
        {
            double tongTien = 0;
            int sodong = NK_DGV_CTNK.Rows.Count;

            for (int i = 0; i < sodong; i++)
            {
                tongTien+= double.Parse(NK_DGV_CTNK.Rows[i].Cells[3].Value.ToString());
            }
            return tongTien;
        }
        // ====================== TON KHO ================
        public void ThemSPVaoTonKho(string idsp, int slton)
        {
            TONKHO tk = dBQuanLyBanNGK.TONKHOes.FirstOrDefault(p => p.IDSP == idsp);
            if (tk != null)
            {
                tk.IDSP = idsp;
                int sl = slton;
                int slhientai = int.Parse(tk.SLTON.ToString());
                slhientai += sl;
                tk.SLTON = slhientai;
                dBQuanLyBanNGK.TONKHOes.AddOrUpdate(tk);
                dBQuanLyBanNGK.SaveChanges();
            }
            else
            {
                ThemTonKho(idsp,slton);
            }

            List<TONKHO> listtonkho = dBQuanLyBanNGK.TONKHOes.ToList();
            TonKho.tk.FillDataDGV(listtonkho);
        }
        public void ThemTonKho(string idsp , int slton)
        {
            TONKHO tk = new TONKHO();
            tk.IDSP = idsp;
            tk.SLTON = slton;
            dBQuanLyBanNGK.TONKHOes.Add(tk);
            dBQuanLyBanNGK.SaveChanges();
           
        }
        private void NK_BTN_XACNHAN_Click(object sender, EventArgs e)
        {
            if(NK_DGV_CTNK.Rows.Count > 0)
            {
                //ThemPhieuNhapKho();
                NHAPKHO nk = new NHAPKHO();
                nk.NGAYNHAP = NK_DATENK.Value.Date;
                nk.TONGTIEN = TongTien();
                nk.IDNV = NK_CB_NV.SelectedValue.ToString();
                nk.IDNCC = NK_CB_NCC.SelectedValue.ToString();
                dBQuanLyBanNGK.NHAPKHOes.Add(nk);
                dBQuanLyBanNGK.SaveChanges();
                int sodong = NK_DGV_CTNK.Rows.Count;
                //Them CT phieu nhap kho
                CT_PNHAPKHO ctnk = new CT_PNHAPKHO();

                for (int i = 0; i < sodong; i++)
                {
                    ctnk.IDPNK = nk.MAPNK;
                    ctnk.IDSP = NK_DGV_CTNK.Rows[i].Cells[0].Value.ToString();
                    ctnk.SL = int.Parse(NK_DGV_CTNK.Rows[i].Cells[2].Value.ToString());
                    ctnk.THANHTIEN = double.Parse(NK_DGV_CTNK.Rows[i].Cells[3].Value.ToString());
                    dBQuanLyBanNGK.CT_PNHAPKHO.Add(ctnk);
                    dBQuanLyBanNGK.SaveChanges();
                    string idsp = NK_DGV_CTNK.Rows[i].Cells[0].Value.ToString();
                    int slton = int.Parse(NK_DGV_CTNK.Rows[i].Cells[2].Value.ToString());
                    ThemSPVaoTonKho(idsp, slton);
                    //Load lai DGV DANH SACH SAN PHAM
                    List<TONKHO> listSP = dBQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
                    ucBanHang.bh.FillDataDGV(listSP);
                }
                List<NHAPKHO> listnhapkho = dBQuanLyBanNGK.NHAPKHOes.ToList();
                ucNhapKho.nk.FillDataDGV(listnhapkho);

                this.Close();
                MessageBox.Show("Sản phẩm đã được thêm vào kho!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn chưa thêm sản phẩm!", "Thông báo");
            }
        }

        private void NK_TXT_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số lượng phải là kí tự số?", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void NK_TXT_SL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NK_BTN_THEM_CTNK.PerformClick();
            }
        }

        private void NK_DGV_CTNK_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NK_DGV_CTNK.Rows[e.RowIndex].Height = 40;
        }
    }
}
