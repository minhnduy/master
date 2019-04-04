using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.MODEL;

namespace QLBH.VIEW
{
    public partial class AddhangHoa : DevExpress.XtraEditors.XtraForm
    {
        private DM_HANG HangHoa;
        private bool isCreate;
        public AddhangHoa(DM_HANG hangHoa = null, bool isCreate = true)
        {
            InitializeComponent();
            this.HangHoa = hangHoa;
            this.isCreate = isCreate;
        }

        private void AddhangHoa_Load(object sender, EventArgs e)
        {
            List<string> listMST = DataProvider.Ins.DB.DOI_TAC.Where(x => x.STATUS == true).Select(x => x.MA_ST).ToList();
            d.DataSource = listMST;
            if (!this.isCreate)
            {

                txtMa.ReadOnly =true;
                txtTen.ReadOnly = true;
                txtDVT.ReadOnly = true;
                txtDonGia.ReadOnly = true;
                txtGiaBan.ReadOnly = true;
                txtNote.ReadOnly = true;
                txbTenDT.ReadOnly = true;
                d.Enabled = false;
                simpleButton1.Visible = false;
                simpleButton1.Enabled = false;
                txtMa.Text = HangHoa.MA_HANG;
                txtTen.Text = HangHoa.TEN_HANG;
                txtDVT.Text = HangHoa.DVT;
                txtDonGia.Text = HangHoa.DON_GIA.ToString();
                txtGiaBan.Text = HangHoa.DON_GIA_BAN.ToString();
                txtNote.Text = HangHoa.GHI_CHU;
                d.Text = HangHoa.MA_ST;
                txbTenDT.Text = DataProvider.Ins.DB.DOI_TAC.FirstOrDefault(x => x.MA_ST == HangHoa.MA_ST && x.STATUS == true).TEN_DT;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.isCreate)
            {
                // tao moi
                HangHoa = new DM_HANG();
                string maHang = txtMa.Text.Trim();
                string tenHang = txtTen.Text.Trim();
                if (String.IsNullOrEmpty(maHang) || String.IsNullOrEmpty(tenHang))
                {
                    XtraMessageBox.Show("Mã hàng và tên hàng chưa được điền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (DataProvider.Ins.DB.DM_HANG.Any(x => x.MA_HANG == maHang))
                    {
                        XtraMessageBox.Show("Mã hàng hóa đã tông tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        HangHoa.MA_HANG = maHang;
                        HangHoa.TEN_HANG = tenHang;
                        HangHoa.DVT = txtDVT.Text;
                        decimal.TryParse(txtDonGia.Text, out decimal donGia);
                        HangHoa.DON_GIA = donGia;
                        decimal.TryParse(txtGiaBan.Text, out decimal giaBan);
                        HangHoa.DON_GIA_BAN = giaBan;
                        HangHoa.MA_ST = d.Text;
                        HangHoa.GHI_CHU = txtNote.Text;
                        DataProvider.Ins.DB.DM_HANG.Add(HangHoa);
                        DataProvider.Ins.DB.SaveChanges();
                        XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {

            }

        }

        private void d_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isCreate)
            {
                txbTenDT.Text = DataProvider.Ins.DB.DOI_TAC.FirstOrDefault(x => x.MA_ST == d.SelectedValue.ToString() && x.STATUS == true).TEN_DT;
            }
        }
    }
}