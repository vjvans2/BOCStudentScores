namespace Student_Scores_Vinny
{
    partial class frmUpdateStudentScores
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
            this.frmName = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.lstScores = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtReadOnlyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // frmName
            // 
            this.frmName.AutoSize = true;
            this.frmName.Location = new System.Drawing.Point(17, 31);
            this.frmName.Name = "frmName";
            this.frmName.Size = new System.Drawing.Size(38, 13);
            this.frmName.TabIndex = 0;
            this.frmName.Text = "Name:";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(12, 72);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(43, 13);
            this.lblScores.TabIndex = 1;
            this.lblScores.Text = "Scores:";
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.Location = new System.Drawing.Point(63, 72);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(190, 173);
            this.lstScores.TabIndex = 2;
            this.lstScores.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(259, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(259, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(259, 144);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(259, 180);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(81, 30);
            this.btnClearScores.TabIndex = 4;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(172, 251);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 30);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtReadOnlyName
            // 
            this.txtReadOnlyName.Location = new System.Drawing.Point(65, 28);
            this.txtReadOnlyName.Name = "txtReadOnlyName";
            this.txtReadOnlyName.ReadOnly = true;
            this.txtReadOnlyName.Size = new System.Drawing.Size(275, 20);
            this.txtReadOnlyName.TabIndex = 9;
            this.txtReadOnlyName.TabStop = false;
            // 
            // frmUpdateStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 306);
            this.Controls.Add(this.txtReadOnlyName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstScores);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.frmName);
            this.Name = "frmUpdateStudentScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Student_Scores";
            this.Load += new System.EventHandler(this.frmUpdateStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmName;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtReadOnlyName;
    }
}