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
    public partial class Teams : Form
    {
        public Teams()
        {
            InitializeComponent();
        }
        ConnectDatabase kn = new ConnectDatabase();

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeamID.Text))
            {
                MessageBox.Show("Please import TeamID to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện xóa dữ liệu
            string TeamID = txtTeamID.Text;

            DialogResult result = MessageBox.Show("Do you want delete data with TeamID: " + TeamID + " ?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql_delete = "DELETE FROM Teams WHERE TeamID = @TeamID";

                    kn.Connect_Data(); // Mở kết nối
                    SqlCommand cmd = new SqlCommand(sql_delete, kn.cnn); // Sử dụng kết nối từ lớp ConnectDatabase
                    cmd.Parameters.AddWithValue("@TeamID", TeamID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Delete data successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Get_Data(); // Cập nhật dữ liệu sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Not found data with TeamID: " + TeamID, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    kn.Cancle_Connect(); // Đóng kết nối
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTeamID.Text = "";
            txtTeamName.Text = "";
            txtCoachName.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool v = string.IsNullOrEmpty(txtTeamID.Text);
            if (v)
            {
                MessageBox.Show("Please enter complete information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện thêm dữ liệu vào cơ sở dữ liệu sử dụng tham số
            string sql_insert = "INSERT INTO Teams (TeamID, TeamName, CoachName) VALUES (@TeamID, @TeamName, @CoachName)";

            kn.Connect_Data();
            SqlCommand cmd = new SqlCommand(sql_insert, kn.cnn);

            cmd.Parameters.AddWithValue("@TeamID", txtTeamID.Text);
            cmd.Parameters.AddWithValue("@TeamName", txtTeamName.Text);
            cmd.Parameters.AddWithValue("@CoachName", txtCoachName.Text);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert data successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Get_Data(); // Cập nhật dữ liệu sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kn.Cancle_Connect();
            }
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            Get_Data();
            txtTeamID.Text = "";
            txtTeamName.Text = "";
            txtCoachName.Text = "";
            txtTeamID.Focus();
        }
        public void Get_Data()
        {
            DataTable dta = new DataTable();
            dta = kn.Get_table("Select * from Teams");
            dtaResults.DataSource = dta;
            Show_Data();
        }
        public void Show_Data()
        {
            

            txtTeamID.DataBindings.Clear();
            txtTeamID.DataBindings.Add("Text", dtaResults.DataSource, "TeamID");

            txtTeamName.DataBindings.Clear();
            txtTeamName.DataBindings.Add("Text", dtaResults.DataSource, "TeamName");

            txtCoachName.DataBindings.Clear();
            txtCoachName.DataBindings.Add("Text", dtaResults.DataSource, "CoachName");

           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeamID.Text) )
            {
                MessageBox.Show("Please select a team to update.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện cập nhật dữ liệu trong cơ sở dữ liệu
            string sql_update = "UPDATE Teams SET   TeamName = @TeamName, CoachName = @CoachName WHERE TeamID = @TeamID";

            kn.Connect_Data(); // Mở kết nối
            SqlCommand cmd = new SqlCommand(sql_update, kn.cnn); // Sử dụng kết nối từ lớp ConnectDatabase
            

            cmd.Parameters.AddWithValue("@TeamName", txtTeamName.Text);
            cmd.Parameters.AddWithValue("@CoachName", txtCoachName.Text);
            cmd.Parameters.AddWithValue("@TeamID", txtTeamID.Text);
            

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update data successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Get_Data(); // Cập nhật dữ liệu sau khi cập nhật
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kn.Cancle_Connect(); // Đóng kết nối
            }

        }
    }
}
