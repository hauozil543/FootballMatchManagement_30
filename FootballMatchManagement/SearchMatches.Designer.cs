namespace FootballMatchManagement
{
    partial class SearchMatches
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
            this.label2 = new System.Windows.Forms.Label();
            this.optHomeTeamID = new System.Windows.Forms.RadioButton();
            this.optAwayTeamID = new System.Windows.Forms.RadioButton();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.dtaResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MATCHES";
            // 
            // optHomeTeamID
            // 
            this.optHomeTeamID.AutoSize = true;
            this.optHomeTeamID.Location = new System.Drawing.Point(102, 87);
            this.optHomeTeamID.Name = "optHomeTeamID";
            this.optHomeTeamID.Size = new System.Drawing.Size(185, 20);
            this.optHomeTeamID.TabIndex = 2;
            this.optHomeTeamID.TabStop = true;
            this.optHomeTeamID.Text = "Search with HomeTeamID";
            this.optHomeTeamID.UseVisualStyleBackColor = true;
            this.optHomeTeamID.CheckedChanged += new System.EventHandler(this.optHomeTeamID_CheckedChanged);
            // 
            // optAwayTeamID
            // 
            this.optAwayTeamID.AutoSize = true;
            this.optAwayTeamID.Location = new System.Drawing.Point(102, 139);
            this.optAwayTeamID.Name = "optAwayTeamID";
            this.optAwayTeamID.Size = new System.Drawing.Size(181, 20);
            this.optAwayTeamID.TabIndex = 3;
            this.optAwayTeamID.TabStop = true;
            this.optAwayTeamID.Text = "Search with AwayTeamID";
            this.optAwayTeamID.UseVisualStyleBackColor = true;
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(304, 101);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(255, 22);
            this.txtSearch1.TabIndex = 4;
            this.txtSearch1.TextChanged += new System.EventHandler(this.txtSearch1_TextChanged);
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(635, 110);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 23);
            this.btnSearch1.TabIndex = 5;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click_1);
            // 
            // btnBack1
            // 
            this.btnBack1.Location = new System.Drawing.Point(635, 391);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(138, 23);
            this.btnBack1.TabIndex = 6;
            this.btnBack1.Text = "Back to Menu";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click_1);
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(102, 380);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(75, 34);
            this.btnExit1.TabIndex = 7;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click_1);
            // 
            // dtaResults
            // 
            this.dtaResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaResults.Location = new System.Drawing.Point(102, 205);
            this.dtaResults.Name = "dtaResults";
            this.dtaResults.RowHeadersWidth = 51;
            this.dtaResults.RowTemplate.Height = 24;
            this.dtaResults.Size = new System.Drawing.Size(572, 150);
            this.dtaResults.TabIndex = 8;
            this.dtaResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaResults_CellContentClick);
            // 
            // Matches
            // 
            this.ClientSize = new System.Drawing.Size(845, 475);
            this.Controls.Add(this.dtaResults);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.txtSearch1);
            this.Controls.Add(this.optAwayTeamID);
            this.Controls.Add(this.optHomeTeamID);
            this.Controls.Add(this.label2);
            this.Name = "Matches";
            this.Load += new System.EventHandler(this.Matches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        
        
        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optHomeTeamID;
        private System.Windows.Forms.RadioButton optAwayTeamID;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.DataGridView dtaResults;
    }
}