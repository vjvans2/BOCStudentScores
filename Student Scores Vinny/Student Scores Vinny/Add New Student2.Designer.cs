namespace Student_Scores_Vinny
{
    partial class frmAddNewStudent
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtReadOnlyScores = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 55);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(12, 90);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(43, 13);
            this.lblScores.TabIndex = 2;
            this.lblScores.Text = "Scores:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 15);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(75, 52);
            this.txtScore.MaxLength = 3;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(103, 20);
            this.txtScore.TabIndex = 2;
            // 
            // txtReadOnlyScores
            // 
            this.txtReadOnlyScores.Location = new System.Drawing.Point(75, 87);
            this.txtReadOnlyScores.Name = "txtReadOnlyScores";
            this.txtReadOnlyScores.ReadOnly = true;
            this.txtReadOnlyScores.Size = new System.Drawing.Size(239, 20);
            this.txtReadOnlyScores.TabIndex = 5;
            this.txtReadOnlyScores.TabStop = false;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(197, 51);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(116, 20);
            this.btnAddScore.TabIndex = 3;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(197, 127);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(116, 20);
            this.btnClearScores.TabIndex = 4;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(62, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(116, 20);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(198, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 20);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNewStudent
            // 
            this.AcceptButton = this.btnAddScore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 201);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtReadOnlyScores);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtReadOnlyScores;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}