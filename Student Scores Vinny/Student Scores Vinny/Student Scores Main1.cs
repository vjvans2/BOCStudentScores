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
    public partial class frmStudentScores : Form
    {
                        
        public frmStudentScores()
        {
            InitializeComponent();
        }

        private void btnAddNewStudents_Click(object sender, EventArgs e)
        {
            Form form2 = new frmAddNewStudent();
            DialogResult selectedButton = form2.ShowDialog();
            //form 2 happened
            if (selectedButton == DialogResult.OK)
            {
                string x = form2.Tag.ToString();  //go the extra step of assigning a variable before adding to the list.
                lstStudents.Items.Add(x);
            }
        }

        private void btnUpdateScores_Click(object sender, EventArgs e)
        {
            Form form3 = new frmUpdateStudentScores();
            string x = lstStudents.Text;
            form3.Tag = x;

            //create dialog result that will grab the changed data from form3.

            DialogResult selectedButton = form3.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                string z = lstStudents.Text;
                lstStudents.Items.Remove(z);

                string y = form3.Tag.ToString();
                lstStudents.Items.Add(y);
                


            }

            // when creating the tags you need to tag the 'going to' form in first form and and
            // the 'this' property in the receiving form.

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
                this.Close();
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //find the numbers in the string, parse them out, add/count/average     
            int index = 0;
            index = lstStudents.SelectedIndex;
            if (index == -1)
            {
               
            }
            else
            {                
                    string indivData = lstStudents.Text;
                    indivData = indivData.Trim();
                    string[] splitData = indivData.Split('-');

                    string digits = splitData[1];
                    digits = digits.Trim();
                    string[] rawDigits = digits.Split(' ');

                    int raw = rawDigits.Count();

                    // create a loop to account for all indexes and instances of rawDigits

                    int sum = 0;
                    int average = 0;
                try
                {
                    for (int i = 0; i < ((rawDigits.Length)); i++)
                    {
                        int y = Convert.ToInt32(rawDigits[i]);  //int y = Convert.ToInt32(rawDigits[i])
                        sum += y;
                    }
                    average = sum / ((rawDigits.Length));

                    //final declarartions to textboxes

                    txtScoreTotal.Text = sum.ToString();
                    txtScoreCount.Text = raw.ToString();
                    txtAverage.Text = average.ToString();
                }
                catch (Exception)
                {
                    txtScoreTotal.Text = 0.ToString();
                    txtScoreCount.Text = 0.ToString();
                    txtAverage.Text = 0.ToString();
                }
            }
        }

        private void frmStudentScores_Load(object sender, EventArgs e)
        {
            string a = "John Cena - 94 93 92";
            lstStudents.Items.Add(a);
            lstStudents.SelectedIndex = 0;

            string b = "Steve Austin - 3 16";
            lstStudents.Items.Add(b);

            string c = "Vince McMahon - 55 43 99";
            lstStudents.Items.Add(c);

            string d = "The Rock - ";
            lstStudents.Items.Add(d);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you want to delete this entry?", "Delete Entry", MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
            {
                string x = lstStudents.Text;
                lstStudents.Items.Remove(x);
                txtScoreTotal.Clear();
                txtScoreCount.Clear();
                txtAverage.Clear();
            }
        }
    }
}
