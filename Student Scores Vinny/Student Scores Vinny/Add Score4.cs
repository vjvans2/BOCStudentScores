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
    public partial class frmAddScore : Form
    {
        public frmAddScore()
        {
            InitializeComponent();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                string addedNum;
                addedNum = txtAddScore.Text;
                this.Tag = addedNum;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtAddScore.Text = "";
                txtAddScore.Focus();
            }
        }

        private void btnCancelAddScore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddScore_Load(object sender, EventArgs e)
        {
            txtAddScore.Focus();
        }
        private bool isValidData()
        {
            return Validator.IsPresent(txtAddScore) && 
                   Validator.IsInt32(txtAddScore) &&                    
                   Validator.IsWithinRange(txtAddScore, 0, 100);
        }
    }
}
