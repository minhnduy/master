using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLBH.LOGIC
{
    public partial class CHITIETHANGTON : DevExpress.XtraReports.UI.XtraReport
    {
        public CHITIETHANGTON()
        {
            InitializeComponent();
            this.parameter1.Name = "Mã hàng cần thông kê lượng tồn";
            this.parameter1.Value = '2';
        }

    }
}
