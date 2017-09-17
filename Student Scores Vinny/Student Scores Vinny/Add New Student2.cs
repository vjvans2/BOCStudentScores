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
    public partial class frmAddNewStudent : Form
    {
        List<int> scores = new List<int>();
        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            //creating the list of scores from inputs
            if (isValidDataDigits() && isValidDataName())
            {
                int scoreValue;
                scoreValue = Convert.ToInt32(txtScore.Text);
                scores.Add(scoreValue);
                scoreValue = scores[0];
                string scoreString = "";
                foreach (int score in scores)
                {
                    scoreString += score.ToString() + " ";
                }
                txtReadOnlyScores.Text = scoreString;
                txtScore.Text = "";
                txtScore.Focus();

                //combining the name with the score info
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (/*Validator.IsPresent(txtReadOnlyScores) &&*/ Validator.IsPresent(txtName))
            {
                string name2;
                name2 = txtName.Text;
                string finalScores = txtReadOnlyScores.Text;
                string name = name2 + " - ";
                string formInfo = name + finalScores;
                this.Tag = formInfo;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtName.Focus();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtName))
            {
                DialogResult button = MessageBox.Show("Are you sure you want to delete all of the entered scores?", "Delete All Scores?", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    txtName.Text = "";
                    txtScore.Text = "";
                    txtReadOnlyScores.Text = "";
                    scores.Clear();
                }
            }
        }

        private bool isValidDataDigits()
        {
            return Validator.IsPresent(txtScore) && 
                   Validator.IsInt32(txtScore) &&                   
                   Validator.IsWithinRange(txtScore, 0, 100);
        }

        private bool isValidDataName()
        {
            return Validator.IsPresent(txtName);
        }
    }
}
