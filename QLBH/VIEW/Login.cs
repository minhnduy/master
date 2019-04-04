using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.Helper;
using QLBH.MODEL;

namespace QLBH.VIEW
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = HashString.MD5Hash(txbPassword.Text);
            var user = DataProvider.Ins.DB.Users.FirstOrDefault(x => x.username == username);
            if (user != null && user.password == password)
            {
                this.Hide();
                MainForm mainForm = new MainForm(user);
                mainForm.FormClosed += mainFormClose;
                mainForm.Show();
            } else
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void mainFormClose(object sender, FormClosedEventArgs e)
        {
            txbPassword.Text = "";
            txbUsername.Text = "";
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}