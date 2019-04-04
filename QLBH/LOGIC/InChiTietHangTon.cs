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
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace QLBH.LOGIC
{
    public partial class InChiTietHangTon : DevExpress.XtraEditors.XtraForm
    {
        XtraReport reportMain;
        public InChiTietHangTon()
        {
            InitializeComponent();
        }

        private void InChiTietHangTon_Load(object sender, EventArgs e)
        {
            CHITIETHANGTON cHITIETHANGTON = new CHITIETHANGTON();
            cHITIETHANGTON.ShowPreview();
        }
    }
}