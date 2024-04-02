namespace FootballMatchManagement
{
    partial class Matches
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
            this.txtMatchID = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtaResult = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHomeTeamID = new System.Windows.Forms.TextBox();
            this.txtAwayTeamID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtHomeTeamScore = new System.Windows.Forms.TextBox();
            this.txtAwayTeamScore = new System.Windows.Forms.TextBox();
            this.txtFinalScore = new System.Windows.Forms.TextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matches";
            // 
            // txtMatchID
            // 
            this.txtMatchID.Location = new System.Drawing.Point(162, 56);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.Size = new System.Drawing.Size(92, 22);
            this.txtMatchID.TabIndex = 1;
            this.txtMatchID.TextChanged += new System.EventHandler(this.txtMatchID_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(661, 59);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(71, 28);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtaResult
            // 
            this.dtaResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaResult.Location = new System.Drawing.Point(90, 329);
            this.dtaResult.Name = "dtaResult";
            this.dtaResult.RowHeadersWidth = 51;
            this.dtaResult.RowTemplate.Height = 24;
            this.dtaResult.Size = new System.Drawing.Size(540, 150);
            this.dtaResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "MatchID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time";
            // 
            // txtHomeTeamID
            // 
            this.txtHomeTeamID.Location = new System.Drawing.Point(161, 174);
            this.txtHomeTeamID.Name = "txtHomeTeamID";
            this.txtHomeTeamID.Size = new System.Drawing.Size(289, 22);
            this.txtHomeTeamID.TabIndex = 7;
            this.txtHomeTeamID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAwayTeamID
            // 
            this.txtAwayTeamID.Location = new System.Drawing.Point(162, 202);
            this.txtAwayTeamID.Name = "txtAwayTeamID";
            this.txtAwayTeamID.Size = new System.Drawing.Size(289, 22);
            this.txtAwayTeamID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Venue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "HomeTeamID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "AwayTeamID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "HomeTeamScore";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "AwayTeamScore";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "FinalScore";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(161, 89);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 15;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(161, 122);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(200, 22);
            this.TimePicker.TabIndex = 16;
            this.TimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtHomeTeamScore
            // 
            this.txtHomeTeamScore.Location = new System.Drawing.Point(162, 231);
            this.txtHomeTeamScore.Name = "txtHomeTeamScore";
            this.txtHomeTeamScore.Size = new System.Drawing.Size(289, 22);
            this.txtHomeTeamScore.TabIndex = 18;
            this.txtHomeTeamScore.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAwayTeamScore
            // 
            this.txtAwayTeamScore.Location = new System.Drawing.Point(162, 264);
            this.txtAwayTeamScore.Name = "txtAwayTeamScore";
            this.txtAwayTeamScore.Size = new System.Drawing.Size(289, 22);
            this.txtAwayTeamScore.TabIndex = 19;
            // 
            // txtFinalScore
            // 
            this.txtFinalScore.Location = new System.Drawing.Point(162, 298);
            this.txtFinalScore.Name = "txtFinalScore";
            this.txtFinalScore.Size = new System.Drawing.Size(289, 22);
            this.txtFinalScore.TabIndex = 20;
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(162, 149);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(289, 22);
            this.txtVenue.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(661, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 28);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(661, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 28);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(661, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 28);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(661, 237);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 28);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRefresh
            // 
            this.txtRefresh.Location = new System.Drawing.Point(661, 25);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(71, 28);
            this.txtRefresh.TabIndex = 26;
            this.txtRefresh.Text = "Refresh";
            this.txtRefresh.UseVisualStyleBackColor = true;
            this.txtRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Matches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.txtRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.txtFinalScore);
            this.Controls.Add(this.txtAwayTeamScore);
            this.Controls.Add(this.txtHomeTeamScore);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAwayTeamID);
            this.Controls.Add(this.txtHomeTeamID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtaResult);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtMatchID);
            this.Controls.Add(this.label1);
            this.Name = "Matches";
            this.Text = "Matches";
            this.Load += new System.EventHandler(this.Matches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatchID;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dtaResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHomeTeamID;
        private System.Windows.Forms.TextBox txtAwayTeamID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.TextBox txtHomeTeamScore;
        private System.Windows.Forms.TextBox txtAwayTeamScore;
        private System.Windows.Forms.TextBox txtFinalScore;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button txtRefresh;
    }
}