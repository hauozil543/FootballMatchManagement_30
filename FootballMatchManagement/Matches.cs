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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FootballMatchManagement
{
    public partial class Matches : Form
    {
        public Matches()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        ConnectDatabase kn = new ConnectDatabase();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Matches_Load(object sender, EventArgs e)
        {
            Get_Data();
            txtMatchID.Text = "";
            datePicker.Text = "";
            TimePicker.Text = "";
            txtVenue.Text = "";
            txtHomeTeamID.Text = "";
            txtAwayTeamID.Text = "";
            txtHomeTeamScore.Text = "";
            txtAwayTeamScore.Text = "";
            txtFinalScore.Text = "";
            txtMatchID.Focus();
        }
        public void Get_Data() 
        { 
            DataTable dta = new DataTable();
            dta = kn.Get_table("Select * from Matches");
            dtaResult.DataSource = dta;
            Show_Data();
        }
        public void Show_Data()
        {
            txtMatchID.DataBindings.Clear();
            txtMatchID.DataBindings.Add("Text", dtaResult.DataSource, "MatchID");

            datePicker.DataBindings.Clear();
            datePicker.DataBindings.Add("Text", dtaResult.DataSource, "Date");

            TimePicker.DataBindings.Clear();
            TimePicker.DataBindings.Add("Text", dtaResult.DataSource, "Time");

            txtHomeTeamID.DataBindings.Clear();
            txtHomeTeamID.DataBindings.Add("Text", dtaResult.DataSource, "HomeTeamID");

            txtAwayTeamID.DataBindings.Clear();
            txtAwayTeamID.DataBindings.Add("Text", dtaResult.DataSource, "AwayTeamID");

            txtHomeTeamScore.DataBindings.Clear();
            txtHomeTeamScore.DataBindings.Add("Text", dtaResult.DataSource, "HomeTeamScore");

            txtAwayTeamScore.DataBindings.Clear();
            txtAwayTeamScore.DataBindings.Add("Text", dtaResult.DataSource, "AwayTeamScore");

            txtFinalScore.DataBindings.Clear();
            txtFinalScore.DataBindings.Add("Text", dtaResult.DataSource, "FinalScore");
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMatchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatchID.Text) || string.IsNullOrEmpty(txtHomeTeamID.Text) || string.IsNullOrEmpty(txtAwayTeamID.Text))
            {
                MessageBox.Show("Please enter complete information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện thêm dữ liệu vào cơ sở dữ liệu sử dụng tham số
            string sql_insert = "INSERT INTO Matches (MatchID, Date, Time,Venue, HomeTeamID, AwayTeamID, HomeTeamScore, AwayTeamScore, FinalScore) VALUES (@MatchID, @Date, @Time,@Venue , @HomeTeamID, @AwayTeamID, @HomeTeamScore, @AwayTeamScore, @FinalScore)";

            kn.Connect_Data();
            SqlCommand cmd = new SqlCommand(sql_insert, kn.cnn);
            cmd.Parameters.AddWithValue("@MatchID", txtMatchID.Text);
            cmd.Parameters.AddWithValue("@Date", datePicker.Value.Date);
            cmd.Parameters.AddWithValue("@Time", TimePicker.Value.TimeOfDay);
            cmd.Parameters.AddWithValue("@Venue", txtVenue.Text);
            cmd.Parameters.AddWithValue("@HomeTeamID", txtHomeTeamID.Text);
            cmd.Parameters.AddWithValue("@AwayTeamID", txtAwayTeamID.Text);
            cmd.Parameters.AddWithValue("@HomeTeamScore", txtHomeTeamScore.Text);
            cmd.Parameters.AddWithValue("@AwayTeamScore", txtAwayTeamScore.Text);
            cmd.Parameters.AddWithValue("@FinalScore", txtFinalScore.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            txtMatchID.Text = "";
            datePicker.Text = "";
            TimePicker.Text = "";
            txtVenue.Text = "";
            txtHomeTeamID.Text = "";
            txtAwayTeamID.Text = "";
            txtHomeTeamScore.Text = "";
            txtAwayTeamScore.Text = "";
            txtFinalScore.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMatchID.Text) || string.IsNullOrEmpty(txtHomeTeamID.Text) || string.IsNullOrEmpty(txtAwayTeamID.Text))
            {
                MessageBox.Show("Please select a match to update.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện cập nhật dữ liệu trong cơ sở dữ liệu
            string sql_update = "UPDATE Matches SET Date = @Date, Time = @Time,Venue = @Venue, HomeTeamID = @HomeTeamID, AwayTeamID = @AwayTeamID, HomeTeamScore = @HomeTeamScore, AwayTeamScore = @AwayTeamScore, FinalScore = @FinalScore WHERE MatchID = @MatchID";

            kn.Connect_Data(); // Mở kết nối
            SqlCommand cmd = new SqlCommand(sql_update, kn.cnn); // Sử dụng kết nối từ lớp ConnectDatabase
            cmd.Parameters.AddWithValue("@Date", datePicker.Value.Date);
            cmd.Parameters.AddWithValue("@Time", TimePicker.Value.TimeOfDay);
            cmd.Parameters.AddWithValue("@Venue", txtVenue.Text);

            cmd.Parameters.AddWithValue("@HomeTeamID", txtHomeTeamID.Text);
            cmd.Parameters.AddWithValue("@AwayTeamID", txtAwayTeamID.Text);
            cmd.Parameters.AddWithValue("@HomeTeamScore", txtHomeTeamScore.Text);
            cmd.Parameters.AddWithValue("@AwayTeamScore", txtAwayTeamScore.Text);
            cmd.Parameters.AddWithValue("@FinalScore", txtFinalScore.Text);
            cmd.Parameters.AddWithValue("@MatchID", txtMatchID.Text);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập MatchID hay chưa
            if (string.IsNullOrEmpty(txtMatchID.Text))
            {
                MessageBox.Show("Please import MatchID to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện xóa dữ liệu
            string matchID = txtMatchID.Text;

            DialogResult result = MessageBox.Show("Do you want delete data with MatchID: " + matchID + " No?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql_delete = "DELETE FROM Matches WHERE MatchID = @MatchID";

                    kn.Connect_Data(); // Mở kết nối
                    SqlCommand cmd = new SqlCommand(sql_delete, kn.cnn); // Sử dụng kết nối từ lớp ConnectDatabase
                    cmd.Parameters.AddWithValue("@MatchID", matchID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Delete data successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Get_Data(); // Cập nhật dữ liệu sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Not found data with MatchID: " + matchID, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
