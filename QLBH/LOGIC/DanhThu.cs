using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLBH.LOGIC
{
    public partial class DanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public DanhThu()
        {
            InitializeComponent();
            this.parameter1.Name = "Doanh thu của ngày";
        }

    }
}
