using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLBH.LOGIC
{
    public partial class CHAMCONG : DevExpress.XtraReports.UI.XtraReport
    {
        public CHAMCONG()
        {
            InitializeComponent();
            this.parameter1.Name = "Ngày bắt đầu";
            this.parameter2.Name = "Ngày kết thúc";
        }
        
    }
}
