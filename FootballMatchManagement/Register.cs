using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMatchManagement
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        ConnectDatabase kn = new ConnectDatabase();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter both username and password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem tên người dùng đã tồn tại trong cơ sở dữ liệu chưa
                string sql_check = "SELECT COUNT(*) FROM users WHERE username = @username";
                kn.Connect_Data();
                SqlCommand cmd_check = new SqlCommand(sql_check, kn.cnn);
                cmd_check.Parameters.AddWithValue("@username", txtUserName.Text);

                int count = (int)cmd_check.ExecuteScalar();
                kn.Cancle_Connect();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose another username.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu tên người dùng chưa tồn tại, thêm dữ liệu vào cơ sở dữ liệu
                string sql_insert = "INSERT INTO users (username, password) VALUES (@username, @password)";
                kn.Connect_Data();
                SqlCommand cmd_insert = new SqlCommand(sql_insert, kn.cnn);
                cmd_insert.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd_insert.Parameters.AddWithValue("@password", txtPassword.Text);

                try
                {
                    cmd_insert.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully!" +
                        " Please login again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    kn.Cancle_Connect();
                }
            }

        }
    }

