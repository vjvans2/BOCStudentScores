namespace Student_Scores_Vinny
{
    partial class frmUpdateScore
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
            this.btnUpdateScore = new System.Windows.Forms.Button();
            this.btnCancelUpdateScore = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtUpdateScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateScore
            // 
            this.btnUpdateScore.Location = new System.Drawing.Point(15, 49);
            this.btnUpdateScore.Name = "btnUpdateScore";
            this.btnUpdateScore.Size = new System.Drawing.Size(96, 36);
            this.btnUpdateScore.TabIndex = 2;
            this.btnUpdateScore.Text = "Update";
            this.btnUpdateScore.UseVisualStyleBackColor = true;
            this.btnUpdateScore.Click += new System.EventHandler(this.btnUpdateScore_Click);
            // 
            // btnCancelUpdateScore
            // 
            this.btnCancelUpdateScore.Location = new System.Drawing.Point(117, 49);
            this.btnCancelUpdateScore.Name = "btnCancelUpdateScore";
            this.btnCancelUpdateScore.Size = new System.Drawing.Size(96, 36);
            this.btnCancelUpdateScore.TabIndex = 3;
            this.btnCancelUpdateScore.Text = "Cancel";
            this.btnCancelUpdateScore.UseVisualStyleBackColor = true;
            this.btnCancelUpdateScore.Click += new System.EventHandler(this.btnCancelUpdateScore_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: ";
            // 
            // txtUpdateScore
            // 
            this.txtUpdateScore.Location = new System.Drawing.Point(65, 16);
            this.txtUpdateScore.MaxLength = 3;
            this.txtUpdateScore.Name = "txtUpdateScore";
            this.txtUpdateScore.Size = new System.Drawing.Size(148, 20);
            this.txtUpdateScore.TabIndex = 1;
            // 
            // frmUpdateScore
            // 
            this.AcceptButton = this.btnUpdateScore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 101);
            this.Controls.Add(this.txtUpdateScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnCancelUpdateScore);
            this.Controls.Add(this.btnUpdateScore);
            this.Name = "frmUpdateScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Score";
            this.Load += new System.EventHandler(this.frmUpdateScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateScore;
        private System.Windows.Forms.Button btnCancelUpdateScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtUpdateScore;
    }
}