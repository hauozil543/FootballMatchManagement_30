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
    public class LoginTests
    {
        [TestMethod()]
        public void TestAuthenticatedLogin()
        {
            
           
            // Tạo một đối tượng form Login

            Login loginForm = new Login();

            // Nhập tên người dùng và mật khẩu hợp lệ
            loginForm.txtUserName.Text = "hauho";
            loginForm.txtPassWord.Text = "hauho";
            loginForm.btnLogin.PerformClick();
            bool isAuthenticated = AuthenticateUser(loginForm.txtUserName.Text, loginForm.txtPassWord.Text);

            Assert.IsTrue(isAuthenticated, "Login failed or form is not disposed.");



        }

        // Phương thức để đối chiếu thông tin đăng nhập với cơ sở dữ liệu
        private bool AuthenticateUser(string username, string password)
        {
            ConnectDatabase kn = new ConnectDatabase();

            string sql_insert = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            kn.Connect_Data();
            SqlCommand cmd = new SqlCommand(sql_insert, kn.cnn);
            // Tạo truy vấn SQL để kiểm tra thông tin đăng nhập


            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

                // Thực thi truy vấn và kiểm tra kết quả
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
