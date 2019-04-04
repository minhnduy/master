using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLBH.MODEL;
using QLBH.LOGIC;
using DevExpress.XtraReports.UI;

namespace QLBH.VIEW
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private User user;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public void OpenForm<T>(bool maximize = true, params object[] paramArray)
        {
            var f = MdiChildren.FirstOrDefault(x => x is T);
            if (f ==null)
            {
                f = Activator.CreateInstance(typeof(T), args: paramArray) as Form;
                f.MdiParent = this;
                if (maximize) f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
            else
            {
                f.Activate();
            }
        }
        private void ribbon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword(user);
            changePasswordForm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<AddUser>();
        }

        private void navBarControl2_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<AddSupplierForm>(false);
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<ListSupplierForm>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            barButtonItem3.Enabled = user.role == "admin";
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<ListUser>();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<AddPhieuNhap>(false);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<AddPhieuBan>(false);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddhangHoa addhangHoa = new AddhangHoa();
            addhangHoa.MdiParent = this;
            addhangHoa.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<DSPhieuNhapForm>();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<ListHangHoa>();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<DSPhieuBan>();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhThu danhThu = new DanhThu();
            danhThu.ShowPreview();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<InChiTietHangTon>();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<InTonKho>();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<InChamCOng>();

        }
    }
}