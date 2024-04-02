namespace FootballMatchManagement
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatches = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchMatches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to FootballMatchManagement Application";
            // 
            // btnMatches
            // 
            this.btnMatches.Location = new System.Drawing.Point(129, 150);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(106, 53);
            this.btnMatches.TabIndex = 1;
            this.btnMatches.Text = "Matches";
            this.btnMatches.UseVisualStyleBackColor = true;
            this.btnMatches.Click += new System.EventHandler(this.btnMatches_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Location = new System.Drawing.Point(320, 150);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(106, 53);
            this.btnTeams.TabIndex = 2;
            this.btnTeams.Text = "Teams";
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnGoals
            // 
            this.btnGoals.Location = new System.Drawing.Point(537, 150);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(106, 53);
            this.btnGoals.TabIndex = 3;
            this.btnGoals.Text = "Goals";
            this.btnGoals.UseVisualStyleBackColor = true;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(333, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 53);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchMatches
            // 
            this.btnSearchMatches.Location = new System.Drawing.Point(145, 267);
            this.btnSearchMatches.Name = "btnSearchMatches";
            this.btnSearchMatches.Size = new System.Drawing.Size(121, 53);
            this.btnSearchMatches.TabIndex = 5;
            this.btnSearchMatches.Text = "Search Matches";
            this.btnSearchMatches.UseVisualStyleBackColor = true;
            this.btnSearchMatches.Click += new System.EventHandler(this.btnSearchMatches_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchMatches);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoals);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.btnMatches);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchMatches;
    }
}