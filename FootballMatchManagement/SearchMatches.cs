using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMatchManagement
{
    public partial class SearchMatches : Form
    {
        public SearchMatches()
        {
            InitializeComponent();
        }
        ConnectDatabase kn = new ConnectDatabase();

        private void btnBack1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSearch1_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql_search;
            
            if (optHomeTeamID.Checked == true)
            {
                sql_search = string.Format("Execute  GetMatchesWithTeamNames '%{0}%'", txtSearch1.Text);
                dta = kn.Get_table(sql_search);
            }

            if (optAwayTeamID.Checked == true)
            {
                sql_search = string.Format("Execute  GetMatchesWithTeamNames1 '%{0}%'", txtSearch1.Text);
                dta = kn.Get_table(sql_search);


                dtaResults.DataSource = dta;
                //  String key_word = txtSearch.Text;
                //  Search(key_word);
            }
            optHomeTeamID.Focus();
        }

        private void Matches_Load(object sender, EventArgs e)
        {

        }

        private void btnExit1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void btnBack1_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch1_Click_1(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql_search;
            if (optHomeTeamID.Checked == true)
            {
                sql_search = string.Format("Execute  GetMatchesWithTeamNames '%{0}%'", txtSearch1.Text);
                dta = kn.Get_table(sql_search);
            }

            if (optAwayTeamID.Checked == true)
            {
                sql_search = string.Format("Execute  GetMatchesWithTeamNames1 '%{0}%'", txtSearch1.Text);
                dta = kn.Get_table(sql_search);


                
                //  String key_word = txtSearch.Text;
                //  Search(key_word);
            }
            dtaResults.DataSource = dta;
        }

        private void dtaResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void optHomeTeamID_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

