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
    public partial class AddSupplierForm : DevExpress.XtraEditors.XtraForm
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DOI_TAC dOI_TAC = new DOI_TAC();
            this.Save(dOI_TAC);
        }
        private void Save(DOI_TAC dOI_TAC)
        {
            if (String.IsNullOrWhiteSpace(txbMST.Text))
            {
                XtraMessageBox.Show("Mã đối tác là yêu cầu nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                dOI_TAC.MA_ST = txbMST.Text;
                dOI_TAC.TEN_DT = txbTenDT.Text;
                dOI_TAC.DIA_CHI = txbDiaChi.Text;
                dOI_TAC.NGUOI_LH = txbNgDaiDien.Text;
                dOI_TAC.SDT = txbSdt.Text;
                dOI_TAC.EMAIL = txbEmail.Text;
                dOI_TAC.WECHAT = txbWeb.Text;
                dOI_TAC.TAI_KHOAN = txtBank.Text;
                dOI_TAC.GHI_CHU = txbNote.Text;
                dOI_TAC.STATUS = rdbNCC.Checked;
                if (DataProvider.Ins.DB.DOI_TAC.Any(x => x.MA_ST == dOI_TAC.MA_ST))
                {
                    XtraMessageBox.Show("Đối tác đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataProvider.Ins.DB.DOI_TAC.Add(dOI_TAC);
                    DataProvider.Ins.DB.SaveChanges();
                    XtraMessageBox.Show("Thêm đối tác mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
           
        }

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {

        }
    }
}