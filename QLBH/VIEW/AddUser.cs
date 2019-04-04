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
using QLBH.Helper;

namespace QLBH.VIEW
{
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        private User user;
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string username = textEdit1.Text;
            string password = textEdit3.Text;
            string passwordConfirm = textEdit4.Text;
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(passwordConfirm))
            {
                XtraMessageBox.Show("Tên người dùng hoặc mật khẩu chưa được điền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                User user = DataProvider.Ins.DB.Users.FirstOrDefault(x => x.username == username);
                if (user != null)
                {
                    XtraMessageBox.Show("Tên người dùng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    if (password != passwordConfirm)
                    {
                        XtraMessageBox.Show("Mật khẩu và xác nhận MK không giống nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        user = new User();
                        user.username = username;
                        user.password = HashString.MD5Hash(password);
                        user.role = "admin";
                        DataProvider.Ins.DB.Users.Add(user);
                        DataProvider.Ins.DB.SaveChanges();
                        XtraMessageBox.Show("Thêm người dùng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}