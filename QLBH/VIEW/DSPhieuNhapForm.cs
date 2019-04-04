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
using System.Data.Entity;

namespace QLBH.VIEW
{
    public partial class DSPhieuNhapForm : DevExpress.XtraEditors.XtraForm
    {
        private dynamic data;
        public DSPhieuNhapForm()
        {
            InitializeComponent();
        }

        private void DSPhieuNhapForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            //gc.DataSource = DataProvider.Ins.DB.PHIEU_MH.ToList();
            DataProvider.Ins.DB.PHIEU_MH.LoadAsync().ContinueWith(loadTask =>
            {               
                gc.DataSource = DataProvider.Ins.DB.PHIEU_MH.ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

    }
}