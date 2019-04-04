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
    public partial class DSPhieuBan : DevExpress.XtraEditors.XtraForm
    {
        private dynamic data;
        public DSPhieuBan()
        {
            InitializeComponent();
        }

        private void DSPhieuBan_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            DataProvider.Ins.DB.PHIEU_BH.LoadAsync().ContinueWith(loadTask =>
            {
                gc.DataSource = DataProvider.Ins.DB.PHIEU_BH.ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

    }
}