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
using System.Data.Entity;

namespace QLBH.VIEW
{
    public partial class ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        private User user;
        public ChangePassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            this.textEdit1.Text = user.username;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string oldPass = textEdit2.Text;
            string newPass = textEdit3.Text;
            string newPassConfirm = textEdit4.Text;
            if (newPass != newPassConfirm)
            {
                XtraMessageBox.Show("Mật khẩu mới và xác nhận MK mới không giống nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string temp = HashString.MD5Hash(oldPass);
                if (user.password != temp)
                {
                    XtraMessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    temp = HashString.MD5Hash(newPass);
                    user.password = temp;
                    DataProvider.Ins.DB.Users.Add(user);
                    DataProvider.Ins.DB.Users.Attach(user);
                    DataProvider.Ins.DB.Entry(user).State = EntityState.Modified;
                    DataProvider.Ins.DB.SaveChanges();
                    XtraMessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}