using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
    public partial class ucBanHang : UserControl
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();
        public static ucBanHang bh;
        public Guna2ComboBox cbnv;
        public Guna2ComboBox cbkh;
        int rowindex;
        int row_cthd;
        DONHANG dh;
        int madh;


        //report hoa don
        public Guna2ComboBox tennv;
        public Guna2TextBox madonhang;
        public Guna2ComboBox tenkh;
        public Guna2DateTimePicker ngaytaohd;
        public Guna2TextBox tongtien;
        public Guna2TextBox tienkhachdua;
        public Guna2TextBox tienthua;
        

        public ucBanHang()
        {
            InitializeComponent();
            bh = this;
            cbnv = BH_CB_NV;
            cbkh = BH_CB_KH;

            //report
            tennv = cbnv;
            madonhang = BH_TXT_MADH;
            tenkh = cbkh;
            ngaytaohd = BH_DATE_TTOAN;
            tongtien = BH_TXT_TongTien;
            tienkhachdua = BH_TXT_KhachDua;
            tienthua= BH_TXT_TienThua;

        }
        private void ucBanHang_Load(object sender, EventArgs e)
        {
            List<TONKHO> listSP = dBQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
            BH_DATE_TTOAN.Value = DateTime.Now;
            FillDataDGV(listSP);
            LoadKH();
            LoadNV();
        }
        public void LoadKH()
        {
            BH_CB_KH.DataSource = dBQuanLyBanNGK.KHACHHANGs.ToList();
            BH_CB_KH.DisplayMember = "TENKH";
            BH_CB_KH.ValueMember = "MAKH";
        }
        public void LoadNV()
        {
            BH_CB_NV.DataSource = dBQuanLyBanNGK.NHANVIENs.ToList();
            BH_CB_NV.DisplayMember = "TENNV";
            BH_CB_NV.ValueMember = "MANV";
        }
        public void FillDataDGV(List<TONKHO> listSP)
        {
            BH_DGV_DSSP.Rows.Clear();

            foreach (var item in listSP)
            {
                int RowNew = BH_DGV_DSSP.Rows.Add();
                BH_DGV_DSSP.Rows[RowNew].Cells[0].Value = item.IDSP;
                BH_DGV_DSSP.Rows[RowNew].Cells[1].Value = item.SANPHAM.TENSP;
                BH_DGV_DSSP.Rows[RowNew].Cells[2].Value = item.SANPHAM.GIABAN;
                BH_DGV_DSSP.Rows[RowNew].Cells[3].Value = item.SLTON;
            }
        }
        private void BH_DGV_DSSP_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BH_DGV_DSSP.Rows[e.RowIndex].Height = 35;
        }
        private void BH_DGV_CTHD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BH_DGV_CTHD.Rows[e.RowIndex].Height = 35;
        }
        private void BH_DGV_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = BH_DGV_DSSP.Rows[e.RowIndex];
            BH_TXT_TENSP.Text = row.Cells[1].Value.ToString();
            BH_TXT_GIATIEN.Text = row.Cells[2].Value.ToString();

        }
        public int LayDongTonTaiTrongCTHoaDon()
        {

            int sodong = BH_DGV_CTHD.Rows.Count;
            string idsphientai = BH_DGV_DSSP.Rows[rowindex].Cells[0].Value.ToString();
            for (int i = 0; i < sodong; i++)
            {
                string KTTonTaiIDSP = BH_DGV_CTHD.Rows[i].Cells[0].Value.ToString();
                //MessageBox.Show(KTTonTaiIDSP);
                if (idsphientai == KTTonTaiIDSP)
                {
                    return i;
                }
            }
            return -1;
        }
        public void ThemCTHoaDon()
        {
            int row = BH_DGV_CTHD.Rows.Add();
            string idsp = BH_DGV_DSSP.Rows[rowindex].Cells[0].Value.ToString();
            BH_DGV_CTHD.Rows[row].Cells[0].Value = idsp;
            BH_DGV_CTHD.Rows[row].Cells[1].Value = BH_TXT_TENSP.Text;
            double dongia = double.Parse(BH_DGV_DSSP.Rows[rowindex].Cells[2].Value.ToString());
            BH_DGV_CTHD.Rows[row].Cells[2].Value = dongia;
            var sp = dBQuanLyBanNGK.SANPHAMs.FirstOrDefault(p => p.MASP == idsp);
            int sl = int.Parse(BH_TXT_SL.Text);
            double thanhtien = double.Parse(sp.GIABAN.Value.ToString()) * sl;
            BH_DGV_CTHD.Rows[row].Cells[3].Value = BH_TXT_SL.Text;
            BH_DGV_CTHD.Rows[row].Cells[4].Value = thanhtien.ToString();
        }
        public void XuLyThemCTNhapKho()
        {
            int sodong = BH_DGV_CTHD.Rows.Count;

            if (sodong == 0)
            {
                ThemCTHoaDon();
            }
            else
            {
                if (LayDongTonTaiTrongCTHoaDon() != -1)
                {
                    int sl = int.Parse(BH_TXT_SL.Text);
                    int slhientai = int.Parse(BH_DGV_CTHD.Rows[LayDongTonTaiTrongCTHoaDon()].Cells[3].Value.ToString());
                    slhientai += sl;
                    BH_DGV_CTHD.Rows[LayDongTonTaiTrongCTHoaDon()].Cells[3].Value = slhientai.ToString();
                    //Cap nhat lai thanh tien khi tang slsp
                    double thanhtienhientai = double.Parse(BH_DGV_CTHD.Rows[LayDongTonTaiTrongCTHoaDon()].Cells[4].Value.ToString());
                    string checkma = BH_DGV_CTHD.Rows[LayDongTonTaiTrongCTHoaDon()].Cells[0].Value.ToString();
                    var sp = dBQuanLyBanNGK.SANPHAMs.FirstOrDefault(p => p.MASP == checkma);
                    double gianhap = double.Parse(sp.GIABAN.ToString());
                    BH_DGV_CTHD.Rows[LayDongTonTaiTrongCTHoaDon()].Cells[4].Value = thanhtienhientai + gianhap * sl;
                }
                else
                {
                    ThemCTHoaDon();
                }
            }
        }
        private void BH_BTN_THEMVAOHD_Click(object sender, EventArgs e)
        {
            if (BH_TXT_MADH.Text == "")
            {
                if (BH_TXT_TENSP.Text == "" && BH_TXT_GIATIEN.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm!", "Thông báo", MessageBoxButtons.OK);
                }
                else if (BH_TXT_SL.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số lượng sản phẩm!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    int slkhachmua = int.Parse(BH_TXT_SL.Text);
                    int sltonkho = int.Parse(BH_DGV_DSSP.Rows[rowindex].Cells[3].Value.ToString());
                    if (sltonkho >= slkhachmua)
                    {
                        BH_DGV_DSSP.Rows[rowindex].Cells[3].Value = sltonkho - slkhachmua;
                        XuLyThemCTNhapKho();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng trong kho không đủ!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Đơn hàng đã được xác nhận. Không thể thêm!", "Thông báo");
            }
        }
        private void BH_BTN_XOASPCT_Click(object sender, EventArgs e)
        {
            if(BH_DGV_CTHD.SelectedRows.Count != 0)
            {
                if (BH_TXT_MADH.Text == "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == result)
                    {
                        //xu ly cot soluongton khi go sp trong cthoadon
                        string masp_trongcthd = BH_DGV_CTHD.Rows[row_cthd].Cells[0].Value.ToString();
                        int slsp_trongcthd = int.Parse(BH_DGV_CTHD.Rows[row_cthd].Cells[3].Value.ToString());

                        int sodong = BH_DGV_DSSP.Rows.Count;
                        for (int i = 0; i < sodong; i++)
                        {
                            string masp_trongdssp = BH_DGV_DSSP.Rows[i].Cells[0].Value.ToString();
                            int slsp_trongdssp = int.Parse(BH_DGV_DSSP.Rows[i].Cells[3].Value.ToString());

                            if (masp_trongcthd == masp_trongdssp)
                            {
                                BH_DGV_DSSP.Rows[i].Cells[3].Value = slsp_trongcthd + slsp_trongdssp;
                            }
                        }
                        BH_DGV_CTHD.Rows.RemoveAt(row_cthd);
                    }
                }
                else
                {
                    MessageBox.Show("Đơn hàng đã được xác nhận. Không thể xóa sản phẩm!", "Thông báo");
                }
                
            }
        }
        private void BH_DGV_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           row_cthd = e.RowIndex;
        }
        private void BH_BTN_THANHTOAN_Click(object sender, EventArgs e)
        {
            if(BH_TXT_MADH.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == result)
                {
                    //tao ct_hd
                    int sodong = BH_DGV_CTHD.Rows.Count;
                    TaoChiTietDonHang(dh.MADH, sodong);

                    BH_BTN_THANHTOAN.Enabled = false;

                    List<DONHANG> listdh = dBQuanLyBanNGK.DONHANGs.ToList();
                    ucDonHang.dh.FillDataDGV(listdh);

                    List<TONKHO> listSP = dBQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
                    TonKho.tk.FillDataDGV(listSP);
                    FillDataDGV(listSP);

                }
                
            }
            else
            {
                MessageBox.Show("Không thể thanh toán! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void TinhTongTienHD()
        {
            double tongTien = 0;

            int tongdong = BH_DGV_CTHD.Rows.Count;

            if (tongdong != 0)
            {
                for (int i = 0; i < tongdong; i++)
                {
                    double tien = double.Parse(BH_DGV_CTHD.Rows[i].Cells[4].Value.ToString());
                    tongTien += tien;
                }
            }
            BH_TXT_TongTien.Text = tongTien.ToString();
        }
        public void TaoMoi()
        {
            BH_TXT_TENSP.Text = null;
            BH_TXT_GIATIEN.Text = null;
            BH_TXT_SL.Text = null;
            BH_DGV_CTHD.Rows.Clear();
            BH_TXT_MADH.Text = null;
            BH_TXT_TongTien.Text = "0";
            BH_TXT_KhachDua.Text = null;
            BH_TXT_TienThua.Text = null;
            BH_BTN_THANHTOAN.Enabled = true;

            List<TONKHO> listSP = dBQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
            FillDataDGV(listSP);
        }

        public void TaoDonHang(DONHANG dh)
        {
            dh.NGAYLAP = BH_DATE_TTOAN.Value;
            dh.IDNV = BH_CB_NV.SelectedValue.ToString();
            dh.IDKH = BH_CB_KH.SelectedValue.ToString();
            dh.TONGTIEN = double.Parse(BH_TXT_TongTien.Text);
            dBQuanLyBanNGK.DONHANGs.Add(dh);
            dBQuanLyBanNGK.SaveChanges();
        }
        public void TaoChiTietDonHang(int maDH, int sodong)
        {
            CT_DONHANG ct_dh;
            for (int i = 0; i < sodong; i++)
            {
                ct_dh = new CT_DONHANG();
                ct_dh.MADH = maDH;
                ct_dh.MASP = BH_DGV_CTHD.Rows[i].Cells[0].Value.ToString();
                ct_dh.SL = int.Parse(BH_DGV_CTHD.Rows[i].Cells[3].Value.ToString());
                //Xu ly ton kh
                string masp = BH_DGV_CTHD.Rows[i].Cells[0].Value.ToString();
                var sptonkho = dBQuanLyBanNGK.TONKHOes.FirstOrDefault(p => p.IDSP == masp);
                int slton = int.Parse(sptonkho.SLTON.ToString());
                int slmua = int.Parse(BH_DGV_CTHD.Rows[i].Cells[3].Value.ToString());
                slton -= slmua;
                CapNhatKho(masp, slton);
                ct_dh.THANHTIEN = double.Parse(BH_DGV_CTHD.Rows[i].Cells[4].Value.ToString());
                dBQuanLyBanNGK.CT_DONHANG.Add(ct_dh);
                dBQuanLyBanNGK.SaveChanges();
            }
        }
        private void CapNhatKho(string idsp, int sltoncapnhat)
        {
            TONKHO tk = dBQuanLyBanNGK.TONKHOes.FirstOrDefault(p => p.IDSP == idsp);
            if (tk != null)
            {
                tk.SLTON = sltoncapnhat;
                dBQuanLyBanNGK.TONKHOes.AddOrUpdate(tk);
                dBQuanLyBanNGK.SaveChanges();
            }
            List<TONKHO> listtonkho = dBQuanLyBanNGK.TONKHOes.ToList();
            TonKho.tk.FillDataDGV(listtonkho);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
             int sodong = BH_DGV_CTHD.Rows.Count;

            if(sodong > 0)
            {
                if (BH_TXT_MADH.Text == "")
                {
                    TinhTongTienHD();
                    dh = new DONHANG();
                    TaoDonHang(dh);
                    madh = dh.MADH;
                    BH_TXT_MADH.Text = "HD" + dh.MADH;
                    List<DONHANG> listdh = dBQuanLyBanNGK.DONHANGs.ToList();
                    ucDonHang.dh.FillDataDGV(listdh);
                }
                else
                {
                    MessageBox.Show("Đơn hàng đã được xác nhận. Không thể xác nhận tiếp!", "Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào!", "Thông báo");
            }
        }

        private void BH_TXT_KhachDua_TextChanged(object sender, EventArgs e)
        {
            if (BH_TXT_KhachDua.Text != "")
            {
                double tienkhachdua = double.Parse(BH_TXT_KhachDua.Text);
                double tongtien = double.Parse(BH_TXT_TongTien.Text);

                double tienthua = tienkhachdua - tongtien;

                BH_TXT_TienThua.Text = tienthua.ToString();
            }
            else
            {
                BH_TXT_TienThua.Text = "0";
            }
        }
        private void BH_BTN_HUY_Click(object sender, EventArgs e)
        {
            if(BH_TXT_MADH.Text != "")
            {
                if (BH_BTN_THANHTOAN.Enabled)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn hủy đơn hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == result)
                    {
                        DONHANG dh = dBQuanLyBanNGK.DONHANGs.Find(madh);
                        dBQuanLyBanNGK.DONHANGs.Remove(dh);
                        dBQuanLyBanNGK.SaveChanges();

                        List<DONHANG> listdh = dBQuanLyBanNGK.DONHANGs.ToList();
                        ucDonHang.dh.FillDataDGV(listdh);

                        TaoMoi();
                    }
                }
                else
                {
                    MessageBox.Show("Đơn hàng đã được thanh toán. Không thể hủy!", "Thông báo");
                }
            }
        }
        private void btnTimSP_DH_Click(object sender, EventArgs e)
        {
            List<TONKHO> listSP = dBQuanLyBanNGK.TONKHOes.Where(p => p.SLTON > 0).ToList();
            var listTimSP = listSP.Where(p => p.SANPHAM.MASP.ToLower().Contains(txtTimSP_BH.Text.ToLower())
                                                             || p.SANPHAM.TENSP.ToLower().Contains(txtTimSP_BH.Text.ToLower())).ToList();

            if (listTimSP.Count > 0)
            {
                FillDataDGV(listTimSP);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Sản Phẩm Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTaoMoiHD_Click(object sender, EventArgs e)
        {
           
            TaoMoi();
        }

        private void BH_CB_KH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadKH();
            }
        }

        private void BH_TXT_SL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BH_BTN_THEMVAOHD.PerformClick();
            }
        }

        private void BH_TXT_KhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BH_BTN_THANHTOAN.PerformClick();
            }
        }
    }
}
