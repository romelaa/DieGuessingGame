namespace Assignment2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLost = new System.Windows.Forms.Label();
            this.lblWon = new System.Windows.Forms.Label();
            this.lblPlayed = new System.Windows.Forms.Label();
            this.numLost = new System.Windows.Forms.Label();
            this.numWon = new System.Windows.Forms.Label();
            this.numPlayed = new System.Windows.Forms.Label();
            this.enterGuess = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.dicePB = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.clmnFace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNumOfGuess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warningLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblLost);
            this.groupBox1.Controls.Add(this.lblWon);
            this.groupBox1.Controls.Add(this.lblPlayed);
            this.groupBox1.Controls.Add(this.numLost);
            this.groupBox1.Controls.Add(this.numWon);
            this.groupBox1.Controls.Add(this.numPlayed);
            this.groupBox1.Location = new System.Drawing.Point(154, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Info";
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Location = new System.Drawing.Point(194, 99);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(35, 13);
            this.lblLost.TabIndex = 5;
            this.lblLost.Text = "label1";
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Location = new System.Drawing.Point(194, 66);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(35, 13);
            this.lblWon.TabIndex = 4;
            this.lblWon.Text = "label1";
            // 
            // lblPlayed
            // 
            this.lblPlayed.AutoSize = true;
            this.lblPlayed.Location = new System.Drawing.Point(194, 32);
            this.lblPlayed.Name = "lblPlayed";
            this.lblPlayed.Size = new System.Drawing.Size(35, 13);
            this.lblPlayed.TabIndex = 3;
            this.lblPlayed.Text = "label1";
            // 
            // numLost
            // 
            this.numLost.AutoSize = true;
            this.numLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLost.Location = new System.Drawing.Point(17, 99);
            this.numLost.Name = "numLost";
            this.numLost.Size = new System.Drawing.Size(152, 15);
            this.numLost.TabIndex = 2;
            this.numLost.Text = "Number of Times Lost:";
            // 
            // numWon
            // 
            this.numWon.AutoSize = true;
            this.numWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWon.Location = new System.Drawing.Point(17, 66);
            this.numWon.Name = "numWon";
            this.numWon.Size = new System.Drawing.Size(153, 15);
            this.numWon.TabIndex = 1;
            this.numWon.Text = "Number of Times Won:";
            // 
            // numPlayed
            // 
            this.numPlayed.AutoSize = true;
            this.numPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlayed.Location = new System.Drawing.Point(17, 32);
            this.numPlayed.Name = "numPlayed";
            this.numPlayed.Size = new System.Drawing.Size(168, 15);
            this.numPlayed.TabIndex = 0;
            this.numPlayed.Text = "Number of Times Played:";
            // 
            // enterGuess
            // 
            this.enterGuess.AutoSize = true;
            this.enterGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterGuess.Location = new System.Drawing.Point(171, 207);
            this.enterGuess.Name = "enterGuess";
            this.enterGuess.Size = new System.Drawing.Size(163, 16);
            this.enterGuess.TabIndex = 1;
            this.enterGuess.Text = "Enter your guess (1-6):";
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(351, 207);
            this.guessBox.MaxLength = 1;
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(48, 20);
            this.guessBox.TabIndex = 2;
            // 
            // dicePB
            // 
            this.dicePB.Location = new System.Drawing.Point(174, 246);
            this.dicePB.Name = "dicePB";
            this.dicePB.Size = new System.Drawing.Size(100, 104);
            this.dicePB.TabIndex = 3;
            this.dicePB.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(316, 259);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(83, 28);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(316, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 28);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersHeight = 30;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnFace,
            this.clmnFrequency,
            this.clmnPercent,
            this.clmnNumOfGuess});
            this.dataGrid.Location = new System.Drawing.Point(73, 411);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(416, 173);
            this.dataGrid.TabIndex = 6;
            // 
            // clmnFace
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnFace.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmnFace.HeaderText = "Face";
            this.clmnFace.Name = "clmnFace";
            this.clmnFace.ReadOnly = true;
            this.clmnFace.Width = 50;
            // 
            // clmnFrequency
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnFrequency.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmnFrequency.HeaderText = "Frequency";
            this.clmnFrequency.Name = "clmnFrequency";
            this.clmnFrequency.ReadOnly = true;
            // 
            // clmnPercent
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnPercent.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmnPercent.HeaderText = "Percent";
            this.clmnPercent.Name = "clmnPercent";
            this.clmnPercent.ReadOnly = true;
            this.clmnPercent.Width = 70;
            // 
            // clmnNumOfGuess
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnNumOfGuess.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmnNumOfGuess.HeaderText = "Number of Times Guessed";
            this.clmnNumOfGuess.Name = "clmnNumOfGuess";
            this.clmnNumOfGuess.ReadOnly = true;
            this.clmnNumOfGuess.Width = 150;
            // 
            // warningLbl
            // 
            this.warningLbl.AutoSize = true;
            this.warningLbl.ForeColor = System.Drawing.Color.Maroon;
            this.warningLbl.Location = new System.Drawing.Point(171, 376);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(35, 13);
            this.warningLbl.TabIndex = 7;
            this.warningLbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(570, 626);
            this.Controls.Add(this.warningLbl);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.dicePB);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.enterGuess);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Die Guess Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label numLost;
        private System.Windows.Forms.Label numWon;
        private System.Windows.Forms.Label numPlayed;
        private System.Windows.Forms.Label enterGuess;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.PictureBox dicePB;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFace;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNumOfGuess;
        private System.Windows.Forms.Label warningLbl;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Label lblPlayed;
    }
}

