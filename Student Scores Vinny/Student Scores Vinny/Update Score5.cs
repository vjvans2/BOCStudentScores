using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Scores_Vinny
{
    public partial class frmUpdateScore : Form
    {
        public frmUpdateScore()
        {
            InitializeComponent();
        }

        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                string updatedNum = txtUpdateScore.Text;
                this.Tag = updatedNum;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtUpdateScore.Text = "";
                txtUpdateScore.Focus();
            }
        }

        private void btnCancelUpdateScore_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmUpdateScore_Load(object sender, EventArgs e)
        {
            txtUpdateScore.Focus();
        }

        private bool isValidData()
        {
            return Validator.IsPresent(txtUpdateScore) && 
                   Validator.IsInt32(txtUpdateScore) &&                   
                   Validator.IsWithinRange(txtUpdateScore, 0, 100);
        }
    }
}
