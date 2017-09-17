namespace Student_Scores_Vinny
{
    partial class frmAddScore
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
            this.txtAddScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCancelAddScore = new System.Windows.Forms.Button();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddScore
            // 
            this.txtAddScore.Location = new System.Drawing.Point(64, 20);
            this.txtAddScore.MaxLength = 3;
            this.txtAddScore.Name = "txtAddScore";
            this.txtAddScore.Size = new System.Drawing.Size(148, 20);
            this.txtAddScore.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(11, 23);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score: ";
            // 
            // btnCancelAddScore
            // 
            this.btnCancelAddScore.Location = new System.Drawing.Point(116, 53);
            this.btnCancelAddScore.Name = "btnCancelAddScore";
            this.btnCancelAddScore.Size = new System.Drawing.Size(96, 36);
            this.btnCancelAddScore.TabIndex = 2;
            this.btnCancelAddScore.Text = "Cancel";
            this.btnCancelAddScore.UseVisualStyleBackColor = true;
            this.btnCancelAddScore.Click += new System.EventHandler(this.btnCancelAddScore_Click);
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(14, 53);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(96, 36);
            this.btnAddScore.TabIndex = 1;
            this.btnAddScore.Text = "Add";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // frmAddScore
            // 
            this.AcceptButton = this.btnAddScore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 101);
            this.Controls.Add(this.txtAddScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnCancelAddScore);
            this.Controls.Add(this.btnAddScore);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Score";
            this.Load += new System.EventHandler(this.frmAddScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCancelAddScore;
        private System.Windows.Forms.Button btnAddScore;
    }
}