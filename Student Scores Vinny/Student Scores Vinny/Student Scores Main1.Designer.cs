namespace Student_Scores_Vinny
{
    partial class frmStudentScores
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.btnAddNewStudents = new System.Windows.Forms.Button();
            this.btnUpdateScores = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(15, 34);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(352, 212);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(12, 9);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(52, 13);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "Students:";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(246, 259);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(65, 13);
            this.lblScoreTotal.TabIndex = 2;
            this.lblScoreTotal.Text = "Score Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average:";
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(317, 256);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(50, 20);
            this.txtScoreTotal.TabIndex = 5;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(317, 308);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(50, 20);
            this.txtAverage.TabIndex = 6;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(317, 282);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(50, 20);
            this.txtScoreCount.TabIndex = 7;
            // 
            // btnAddNewStudents
            // 
            this.btnAddNewStudents.Location = new System.Drawing.Point(373, 37);
            this.btnAddNewStudents.Name = "btnAddNewStudents";
            this.btnAddNewStudents.Size = new System.Drawing.Size(155, 32);
            this.btnAddNewStudents.TabIndex = 8;
            this.btnAddNewStudents.Text = "Add New Students";
            this.btnAddNewStudents.UseVisualStyleBackColor = true;
            this.btnAddNewStudents.Click += new System.EventHandler(this.btnAddNewStudents_Click);
            // 
            // btnUpdateScores
            // 
            this.btnUpdateScores.Location = new System.Drawing.Point(373, 75);
            this.btnUpdateScores.Name = "btnUpdateScores";
            this.btnUpdateScores.Size = new System.Drawing.Size(155, 32);
            this.btnUpdateScores.TabIndex = 9;
            this.btnUpdateScores.Text = "Update Scores";
            this.btnUpdateScores.UseVisualStyleBackColor = true;
            this.btnUpdateScores.Click += new System.EventHandler(this.btnUpdateScores_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(373, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(441, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 32);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 348);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateScores);
            this.Controls.Add(this.btnAddNewStudents);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lstStudents);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Scores - Main";
            this.Load += new System.EventHandler(this.frmStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.Button btnAddNewStudents;
        private System.Windows.Forms.Button btnUpdateScores;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}

