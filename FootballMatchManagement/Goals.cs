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
    public partial class Goals : Form
    {
        public Goals()
        {
            InitializeComponent();
        }
        ConnectDatabase kn = new ConnectDatabase();

        public void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            { }
        }

        public void Goals_Load(object sender, EventArgs e)
        {
            Get_Data();
            txtGoalID.Text = "";
            txtMatchID.Text = "";
            txtNamePlayer.Text = "";
            txtMinute.Text = "";
            txtGoalID.Focus();
        }
        public void Get_Data()
        {
            DataTable dta = new DataTable();
            dta = kn.Get_table("Select * from Goals");
            dta_Results.DataSource = dta;
            Show_Data();
        }

        public void Show_Data()
        {
            txtGoalID.DataBindings.Clear();
            txtGoalID.DataBindings.Add("Text", dta_Results.DataSource, "GoalID");

            txtMatchID.DataBindings.Clear();
            txtMatchID.DataBindings.Add("Text", dta_Results.DataSource, "MatchID");

            txtNamePlayer.DataBindings.Clear();
            txtNamePlayer.DataBindings.Add("Text", dta_Results.DataSource, "NamePlayer");

            txtMinute.DataBindings.Clear();
            txtMinute.DataBindings.Add("Text", dta_Results.DataSource, "Minute");
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            txtGoalID.Text = "";
            txtMatchID.Text = "";
            txtNamePlayer.Text = "";
            txtMinute.Text = "";
        }

        public void btnInsert_Click(object sender, EventArgs e)
        {
            bool v = string.IsNullOrEmpty(txtGoalID.Text);
            if (v)
            {
                MessageBox.Show("Please enter complete information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện thêm dữ liệu vào cơ sở dữ liệu sử dụng tham số
            string sql_insert = "INSERT INTO Goals (GoalID,MatchID, NamePlayer,Minute ) VALUES (@GoalID,@MatchID, @NamePlayer,@Minute)";

            kn.Connect_Data();
            SqlCommand cmd = new SqlCommand(sql_insert, kn.cnn);

            cmd.Parameters.AddWithValue("@MatchID", txtMatchID.Text);
            cmd.Parameters.AddWithValue("@NamePlayer", txtNamePlayer.Text);
            cmd.Parameters.AddWithValue("@Minute", txtMinute.Text);
            cmd.Parameters.AddWithValue("@GoalID",txtGoalID.Text);

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

        public void btnUpdate_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrEmpty(txtGoalID.Text))
                {
                    MessageBox.Show("Please select a GoalID to update.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem GoalID đã tồn tại trong cơ sở dữ liệu chưa
                string sql_check = "SELECT COUNT(*) FROM Goals WHERE GoalID = @GoalID";
                kn.Connect_Data();
                SqlCommand cmd_check = new SqlCommand(sql_check, kn.cnn);
                cmd_check.Parameters.AddWithValue("@GoalID", txtGoalID.Text);

                int count = (int)cmd_check.ExecuteScalar();
                kn.Cancle_Connect();

                // Nếu GoalID tồn tại, thực hiện truy vấn UPDATE, ngược lại thực hiện truy vấn INSERT
                if (count > 0)
                {
                    string sql_update = "UPDATE Goals SET MatchID = @MatchID, NamePlayer = @NamePlayer, Minute = @Minute WHERE GoalID = @GoalID";
                    kn.Connect_Data();
                    SqlCommand cmd_update = new SqlCommand(sql_update, kn.cnn);
                    cmd_update.Parameters.AddWithValue("@GoalID", txtGoalID.Text);
                    cmd_update.Parameters.AddWithValue("@MatchID", txtMatchID.Text);
                    cmd_update.Parameters.AddWithValue("@NamePlayer", txtNamePlayer.Text);
                    cmd_update.Parameters.AddWithValue("@Minute", txtMinute.Text);

                    try
                    {
                        cmd_update.ExecuteNonQuery();
                        MessageBox.Show("Update data successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Get_Data(); // Cập nhật dữ liệu sau khi cập nhật
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        kn.Cancle_Connect();
                    }
                }
                else
                {
                    MessageBox.Show("GoalID does not exist. Please use Insert button to add new data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGoalID.Text))
            {
                MessageBox.Show("Please import GoalID to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện xóa dữ liệu
            string GoalID = txtGoalID.Text;

            DialogResult result = MessageBox.Show("Do you want delete data with GoalID: " + GoalID + " ?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql_delete = "DELETE FROM Goals WHERE GoalID = @GoalID";

                    kn.Connect_Data(); // Mở kết nối
                    SqlCommand cmd = new SqlCommand(sql_delete, kn.cnn); // Sử dụng kết nối từ lớp ConnectDatabase
                    cmd.Parameters.AddWithValue("@GoalID", GoalID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Delete data successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Get_Data(); // Cập nhật dữ liệu sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Not found data with GoalID: " + GoalID, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
