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
    public partial class frmUpdateStudentScores : Form
    {        
        public frmUpdateStudentScores()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form4 = new frmAddScore();
            DialogResult selectedButton = form4.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                string x = form4.Tag.ToString();
                lstScores.Items.Add(x);
                lstScores.SelectedIndex = 0;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int z = lstScores.SelectedIndex;
            if (z == -1)
            {
                MessageBox.Show("Please select an entry", "Error");            
            }
            else
            {
                Form form5 = new frmUpdateScore();
                string y = lstScores.Text;
                lstScores.Items.Remove(y);
                DialogResult selectedButton = form5.ShowDialog();
                if (selectedButton == DialogResult.OK)
                {
                    string x = form5.Tag.ToString();
                    lstScores.Items.Add(x);
                }
                if (selectedButton == DialogResult.Cancel)
                {
                    lstScores.Items.Add(y); 
                }
                lstScores.SelectedIndex = 0;
            }
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsPresent(lstScores))
            {
                lstScores.SelectedIndex = 0;
            }

            {
                DialogResult button = MessageBox.Show("Is the data for this person accurate?", "Done?", MessageBoxButtons.YesNo);
                
                if (button == DialogResult.Yes)
                {
                    string name = txtReadOnlyName.Text;
                    string b = "";
                    string allNums = "";
                    for (int i = 0; i < lstScores.Items.Count; i++)
                    {
                        b = Convert.ToString(lstScores.Items[i]);
                        allNums += b + " ";
                    }
                    string newData = name + "- " + allNums;
                    this.Tag = newData;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmUpdateStudentScores_Load(object sender, EventArgs e)
        {
            //grab data from selected index in listbox on main screen
            //parse it, stick it in the name and scores in a new list

            //make sure that the receiving form uses the 'this' property to grab the info from the tag.
            
            string x = this.Tag.ToString();  //grabbing the info from the primary screen
            string adjustData = x;

            adjustData = adjustData.Trim();
            string[] splitAdjustData = adjustData.Split('-');

            string name = splitAdjustData[0];
            txtReadOnlyName.Text = name;

            string digits = splitAdjustData[1];            
            digits = digits.Trim();            
            string [] rawUpdateDigits = digits.Split(' ');
                      

            foreach (string num in rawUpdateDigits)
            {
                lstScores.Items.Add(num);                
            }

            //lstScores.Items.RemoveAt(0);  //was creating an initial blank entry
            //modify for non-empty lists

                        
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            int z = lstScores.SelectedIndex;
            if (z == -1)
            {
                MessageBox.Show("Please select an entry", "Error");
            }

            else
            {
                DialogResult button = MessageBox.Show("Are you sure you want to delete this entry?", "Delete Entry?", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    string x = lstScores.Text;
                    lstScores.Items.Remove(x);
                }
                lstScores.SelectedIndex = 0;
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(lstScores))

            {
                DialogResult button = MessageBox.Show("Are you sure you want to delete all the scores?", "Delete All Scores?", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    lstScores.Items.Clear();
                }
                
            }
        }
    }
}
