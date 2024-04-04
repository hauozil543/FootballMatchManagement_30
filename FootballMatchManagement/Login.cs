using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FootballMatchManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection kn = new SqlConnection(@"Data Source=LAPTOP-N5TTVA9R;Initial Catalog=FootballMatchManagement;Integrated Security=True;");
        public void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }

        }

        public void Login_Load(object sender, EventArgs e)
        {

        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtUserName.Text;
            password = txtPassWord.Text;

            try
            {
                string SQL = "SELECT * FROM users WHERE username = @username AND password = @password";
                SqlCommand command = new SqlCommand(SQL, kn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = txtUserName.Text;
                    password = txtPassWord.Text;

                    //Page that needed to be load next
                    Menu menuform = new Menu();
                    DialogResult dr = MessageBox.Show("Logged in sucessfully. Do you want go to Menu?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        menuform.Show();
                        this.Hide();
                    }
                    else
                    {
                        DialogResult dr1 = MessageBox.Show("Do you want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            Application.ExitThread();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassWord.Clear();
                    //to forcus  username
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                kn.Close();
            }

        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassWord.Clear();

            txtUserName.Focus();
        }

        public void label4_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
