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


namespace FootballMatchManagement.Tests
{
    [TestClass()]
    public class LoginTests
    {
        [TestMethod()]
        public void TestValidLogin()
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
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = @"Data Source=LAPTOP-N5TTVA9R;Initial Catalog=FootballMatchManagement;Integrated Security=True;";

            // Mở kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo truy vấn SQL để kiểm tra thông tin đăng nhập
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                // Thực thi truy vấn và kiểm tra kết quả
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}