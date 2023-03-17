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
    public partial class ucNhaCungCap : UserControl
    {
        DBQuanLyBanNuocGiaiKhat dBQuanLyBanNGK = new DBQuanLyBanNuocGiaiKhat();

        public static ucNhaCungCap ncc;
        public Guna2DataGridView dgvNCC;
        public int index;
        public ucNhaCungCap()
        {
            InitializeComponent();
            ncc = this;
            dgvNCC = dgvNhaCungCap;
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmThemNCC themNCC = new frmThemNCC();
            themNCC.ShowDialog();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            frmSuaNCC suaNCC = new frmSuaNCC();
            suaNCC.ShowDialog();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {


            List<NHACUNGCAP> listNhaCungCap = dBQuanLyBanNGK.NHACUNGCAPs.ToList();
            FillDataDGV(listNhaCungCap);
        }

        public void FillDataDGV(List<NHACUNGCAP> listNhaCungCap)
        {
            dgvNhaCungCap.Rows.Clear();
            foreach (var item in listNhaCungCap)
            {
                int RowNew = dgvNhaCungCap.Rows.Add();
                dgvNhaCungCap.Rows[RowNew].Cells[0].Value = item.MANCC;
                dgvNhaCungCap.Rows[RowNew].Cells[1].Value = item.TENNCC;
                dgvNhaCungCap.Rows[RowNew].Cells[2].Value = item.SDTNCC;
                dgvNhaCungCap.Rows[RowNew].Cells[3].Value = item.DIACHINCC;
                dgvNhaCungCap.Rows[RowNew].Cells[4].Value = item.EMAILNCC;
            }
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void dgvDonHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvNhaCungCap.Rows[e.RowIndex].Height = 40;
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataGridViewRow row = dgvNCC.Rows[index];
                string idncc = row.Cells[0].Value.ToString();
                NHACUNGCAP ncc = dBQuanLyBanNGK.NHACUNGCAPs.Find(idncc);
                dBQuanLyBanNGK.NHACUNGCAPs.Remove(ncc);
                dBQuanLyBanNGK.SaveChanges();

                List<NHACUNGCAP> listNhaCungCap = dBQuanLyBanNGK.NHACUNGCAPs.ToList();
                FillDataDGV(listNhaCungCap);

                List<NHAPKHO> listnk = dBQuanLyBanNGK.NHAPKHOes.ToList();
                ucNhapKho.nk.FillDataDGV(listnk);
            }
        }

        private void btnTimNCC_Click(object sender, EventArgs e)
        {
            List<NHACUNGCAP> listKH = dBQuanLyBanNGK.NHACUNGCAPs.ToList();
            var listTimKH = listKH.Where(p => p.MANCC.ToLower().Contains(txtTimNCC.Text.ToLower())
                                                                || p.TENNCC.ToLower().Contains(txtTimNCC.Text.ToLower())).ToList();

            if (listTimKH.Count > 0)
            {
                FillDataDGV(listTimKH);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Nhân Viên Nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
