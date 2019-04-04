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
using DevExpress.XtraReports.UI;

namespace QLBH.LOGIC
{
    public partial class InTonKho : DevExpress.XtraEditors.XtraForm
    {
        public InTonKho()
        {
            InitializeComponent();
        }

        private void InTonKho_Load(object sender, EventArgs e)
        {
            TONHANG tONHANG = new TONHANG();
            tONHANG.ShowPreview();
        }
    }
}