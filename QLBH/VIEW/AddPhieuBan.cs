using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.MODEL;

namespace QLBH.VIEW
{
    public partial class AddPhieuBan : DevExpress.XtraEditors.XtraForm
    {
        public IEnumerable<DOI_TAC> dOI_TACs = DataProvider.Ins.DB.DOI_TAC.Where(x => x.STATUS == false);
        public IEnumerable<DM_HANG> dM_HANGs;
        private string lastId = "null";
        private string lastSoLuong = "null";
        private int lastLine = -1;

        public AddPhieuBan()
        {
            InitializeComponent();
            txtVAT.Text = "10";
            loadData();
            dataGridView1.CellValueChanged +=
            new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged +=
                 new EventHandler(dataGridView1_CurrentCellDirtyStateChanged);
        }

        private void AddPhieuBan_Load(object sender, EventArgs e)
        {
            var temp = DataProvider.Ins.DB.PHIEU_BH.OrderByDescending(x => x.ID_PBH).Take(1).FirstOrDefault();
            int newID = temp != null ? temp.ID_PBH + 1 : 1;
            txbId.Text = newID.ToString();
            IEnumerable<PHIEU_BH_CT> pHIEU_BH_CTs = DataProvider.Ins.DB.PHIEU_BH_CT.Where(x => x.ID_PBH == newID).ToList();
        }


        void loadData()
        {
            cbNCC.DataSource = dOI_TACs.Select(x => x.MA_ST).ToList();
        }
        void dataGridView1_CurrentCellDirtyStateChanged(object sender,
        EventArgs e)
        {
            if (this.dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0];
            if (cb.Value != null && (lastId == "null" || lastId != cb.Value?.ToString()) || lastLine == -1 || lastLine != e.RowIndex)
            {
                lastLine = e.RowIndex;
                lastId = cb.Value.ToString();
                DM_HANG dM_HANG = dM_HANGs.FirstOrDefault(x => x.MA_HANG == cb.Value.ToString());
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = dM_HANG.TEN_HANG;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = dM_HANG.DVT;
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = dM_HANG.DON_GIA_BAN;
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = 0;
            }
            DataGridViewTextBoxCell soluong = (DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[3];
            if (!String.IsNullOrWhiteSpace(soluong.Value?.ToString()) && (lastSoLuong == "null" || lastSoLuong != soluong.Value?.ToString()) || lastLine == -1 || lastLine != e.RowIndex)
            {
                lastLine = e.RowIndex;
                float.TryParse(soluong.Value.ToString(), out float temp);
                float.TryParse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), out float temp2);
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = temp * temp2;
            }
            if (e.ColumnIndex == 5)
                txtTong.Text = CellSum().ToString();
        }
        private double CellSum()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                double d = 0;
                Double.TryParse(dataGridView1.Rows[i].Cells[5].Value?.ToString(), out d);
                sum += d;
            }
            return sum;
        }
        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            DOI_TAC dOI_TAC = dOI_TACs.FirstOrDefault(x => x.MA_ST == cbNCC.SelectedValue.ToString());
            dM_HANGs = DataProvider.Ins.DB.DM_HANG.ToList();
            dataGridView1.Rows.Clear();
            MaHang.DataSource = dM_HANGs.Select(x => x.MA_HANG).ToList();
            tbNCC.Text = dOI_TAC.TEN_DT.ToString();
            txbDiaChi.Text = dOI_TAC.DIA_CHI;
            txbEmail.Text = dOI_TAC.EMAIL;
            txbSDT.Text = dOI_TAC.SDT;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PHIEU_BH pHIEU_BH = new PHIEU_BH();
            pHIEU_BH.ID_PBH = int.Parse(txbId.Text);
            pHIEU_BH.MA_ST = cbNCC.SelectedValue.ToString();
            pHIEU_BH.NGAY_BAN = dateTimePicker1.Value != null ? dateTimePicker1.Value : DateTime.Now;
            pHIEU_BH.SDT = txbSDT.Text;
            pHIEU_BH.TEN_CTY = tbNCC.Text;
            pHIEU_BH.DIA_CHI = txbDiaChi.Text;
            pHIEU_BH.EMAIL = txbEmail.Text;
            double.TryParse(txtTong.Text, out double tienhang);
            pHIEU_BH.TONG_TIEN_HANG = (int)tienhang;
            pHIEU_BH.SO_TIEN_VND = textBox5.Text;

            List<PHIEU_BH_CT> pHIEU_BH_CTs = new List<PHIEU_BH_CT>();
            pHIEU_BH.PHIEU_BH_CT = pHIEU_BH_CTs;
            int rows = dataGridView1.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                if (dataGridView1.Rows[i].Cells[0] != null && !String.IsNullOrEmpty(dataGridView1.Rows[i].Cells[0].Value?.ToString()))
                {
                    PHIEU_BH_CT pHIEU_BH_CT = new PHIEU_BH_CT();
                    pHIEU_BH_CT.ID_PBH = int.Parse(txbId.Text);
                    pHIEU_BH_CT.STT = i + 1;
                    pHIEU_BH_CT.MA_HANG = dataGridView1.Rows[i].Cells[0].Value?.ToString();
                    pHIEU_BH_CT.TEN_HANG = dataGridView1.Rows[i].Cells[1].Value?.ToString();
                    pHIEU_BH_CT.DVT = dataGridView1.Rows[i].Cells[2].Value?.ToString();
                    decimal.TryParse(dataGridView1.Rows[i].Cells[3].Value?.ToString(), out decimal sl);
                    pHIEU_BH_CT.SL = sl;
                    decimal.TryParse(dataGridView1.Rows[i].Cells[4].Value?.ToString(), out decimal dg);
                    pHIEU_BH_CT.DON_GIA = dg;
                    decimal.TryParse(dataGridView1.Rows[i].Cells[5].Value?.ToString(), out decimal tt);
                    pHIEU_BH_CT.THANH_TIEN = tt;
                    pHIEU_BH_CTs.Add(pHIEU_BH_CT);
                }
            }
            try
            {
                DataProvider.Ins.DB.PHIEU_BH.Add(pHIEU_BH);
                DataProvider.Ins.DB.SaveChanges();
                XtraMessageBox.Show("Thêm mới phiếu bán hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Khổng thể thêm phiếu bán hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            changeResult();
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {
            changeResult();
        }

        void changeResult()
        {
            double.TryParse(txtTong.Text, out double tong);
            double.TryParse(txtVAT.Text, out double Vat);
            txbTongThue.Text = (tong * Vat / 100).ToString();
            txbTongTien.Text = (tong + tong * Vat / 100).ToString();
        }


    }
}