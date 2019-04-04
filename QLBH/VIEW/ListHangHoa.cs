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
using System.Data.Entity;
using QLBH.MODEL;

namespace QLBH.VIEW
{
    public partial class ListHangHoa : DevExpress.XtraEditors.XtraForm
    {
        private IEnumerable<object> data;
        QLBH.MODEL.QLBHDbContext dbContext = new QLBH.MODEL.QLBHDbContext();
        public ListHangHoa()
        {
            InitializeComponent();
            loadData();

        }
        void loadData()
        {
            dbContext.DM_HANG.LoadAsync().ContinueWith(loadTask =>
            {
                data = from a in dbContext.DM_HANG
                       join b in dbContext.DOI_TAC
                       on a.MA_ST equals b.MA_ST
                       select new
                       {
                           MA_HANG = a.MA_HANG,
                           TEN_HANG = a.TEN_HANG,
                           DVT = a.DVT,
                           DON_GIA = a.DON_GIA,
                           DON_GIA_BAN = a.DON_GIA_BAN,

                           TEN_NCC = b.TEN_DT,
                           NOTE = a.GHI_CHU
                       };
                gridControl1.DataSource = data.ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void ListHangHoa_Load(object sender, EventArgs e)
        {


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            var selected = gvDSHang.GetFocusedRow() as dynamic;
            if (selected != null)
            {
                string id = selected.MA_HANG.ToString();
                DM_HANG hang = dbContext.DM_HANG.FirstOrDefault(x => x.MA_HANG == id);
                if (hang != null)
                {
                    AddhangHoa addhangHoa = new AddhangHoa(hang, false);
                    addhangHoa.Show();
                }
                else
                {
                    XtraMessageBox.Show("Mã hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Chọn MỘT hàng để xem chi tiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddhangHoa addhangHoa = new AddhangHoa();
            addhangHoa.MdiParent = this.MdiParent;
            addhangHoa.WindowState = FormWindowState.Normal;
            addhangHoa.Show();
        }

        private void ListHangHoa_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        private void s_Click(object sender, EventArgs e)
        {

            var selected = gvDSHang.GetFocusedRow() as dynamic;
            if (selected != null)
            {
                var confirmResult = XtraMessageBox.Show("Bạn có thực sự muốn xóa ??",
                                      "Xác nhận xóa!",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {


                        string id = selected.MA_HANG.ToString();
                        DM_HANG hang = dbContext.DM_HANG.FirstOrDefault(x => x.MA_HANG == id);
                        dbContext.DM_HANG.Remove(hang);
                        dbContext.SaveChanges();
                        loadData();
                        XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Không thể xóa hàng hóa đã được lập trong phiếu thu hoạc phiếu bán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }                
            }
            else
            {
                XtraMessageBox.Show("Chọn MỘT hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}