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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            Matches matches = new Matches();
            matches.Show();
            this.Hide();

        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            Teams teams = new Teams();
            teams.Show();
            this.Hide();
        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            Goals goals = new Goals();
            goals.Show();
            this.Hide();
        }

        private void btnSearchMatches_Click(object sender, EventArgs e)
        {
            SearchMatches matches = new SearchMatches();
            matches.Show();
            this.Hide();
        }
    }
}
