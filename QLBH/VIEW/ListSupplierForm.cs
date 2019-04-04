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
    public partial class ListSupplierForm : DevExpress.XtraEditors.XtraForm
    {
        QLBH.MODEL.QLBHDbContext dbContext;
        public ListSupplierForm()
        {
            InitializeComponent();
            dbContext = new QLBH.MODEL.QLBHDbContext();
            LoadData();
        }
        void LoadData()
        {
            dbContext.DOI_TAC.LoadAsync().ContinueWith(loadTask =>
            {
                gvDoiTac.DataSource = dbContext.DOI_TAC.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = gvListDT.GetFocusedValue() as DOI_TAC;
            if (selectedRow != null)
            {
                var entity = DataProvider.Ins.DB.DOI_TAC.FirstOrDefault(x => x.MA_ST == selectedRow.MA_ST);
                if (entity != null)
                {
                    DataProvider.Ins.DB.DOI_TAC.Remove(entity);
                    DataProvider.Ins.DB.SaveChanges();
                    XtraMessageBox.Show("Xóa đối tác  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    XtraMessageBox.Show("Không tìm thấy đối tác cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                XtraMessageBox.Show("Chưa chọn đối tác cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void ListSupplierForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.Show();
        }

        private void ListSupplierForm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}