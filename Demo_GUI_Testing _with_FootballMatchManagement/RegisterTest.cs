using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballMatchManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Demo_GUI_Testing__with_FootballMatchManagement
{
    [TestClass()]
    public class RegisterTest
    {
        ConnectDatabase kn = new ConnectDatabase();
        [TestMethod()]
        public void TestEmptyUsernameAndPassword()
        {
            // Tạo một đối tượng form Register
            Register registerForm = new Register();

            // Gọi sự kiện Click của nút Register
            registerForm.btnRegister.PerformClick();

            // Kiểm tra xem có hộp thoại cảnh báo hiển thị không
            Assert.IsTrue( MessageBox.Show("Please enter both username and password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning).Equals(DialogResult.OK));
        }

        [TestMethod()]
        public void TestExistingUsername()
        {
            // Tạo một đối tượng form Register
            Register registerForm = new Register();

            // Nhập tên người dùng đã tồn tại
            registerForm.txtUserName.Text = "admin";
            registerForm.txtPassword.Text = "admin";

            // Gọi sự kiện Click của nút Register
            registerForm.btnRegister.PerformClick();

            // Kiểm tra xem có hộp thoại cảnh báo hiển thị không
            
            Assert.IsTrue(MessageBox.Show("Username already exists. Please choose another username.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning).Equals(DialogResult.OK));
        }

        [TestMethod()]
        public void TestValidRegistration()
        {
            // Tạo một đối tượng form Register
            Register registerForm = new Register();

            // Nhập tên người dùng mới và mật khẩu hợp lệ
            registerForm.txtUserName.Text = "123";
            registerForm.txtPassword.Text = "123";

            // Gọi sự kiện Click của nút Register
            registerForm.btnRegister.PerformClick();

            // Kiểm tra xem có hộp thoại thông báo đăng ký thành công hiển thị không

            Assert.IsTrue(MessageBox.Show("Registered successfully! Please login again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK));

            
        }

    }

}

