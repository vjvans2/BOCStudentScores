using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Scores___Using_Classes
{
    public partial class Form1 : Form
    {
        string finalExampleList;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNewStudents_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            //jumps over to form2 - returns on form close
            string x = form2.ReturnData();
            lstStudents.Items.Add(x);
        }

        private void btnUpdateScores_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1) { }
            else
            {
                Form3 form3 = new Form3();  //instantiation of form
                form3.GetData(lstStudents.Text); //method of form3 is active, able to grab, pass the list data through parameter
                DialogResult button = form3.ShowDialog(); //form isn't active until here
                                                          //anything after would come here
                if (button == DialogResult.OK)
                {
                    string x = form3.returnDataMain();
                    string y = lstStudents.Text;
                    lstStudents.Items.Remove(y);
                    lstStudents.Items.Add(x);
                }
                lstStudents.SelectedIndex = 0;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string exampleName = "Example A";
            List<int> exampleGrades = new List<int> {100, 90, 80};
            Student exampleStudent = new Student(exampleName, exampleGrades);
            string finalExampleName = exampleStudent.Name;

            //take values from list and put in a foreach loop to grab each string
            
            foreach (int grade in exampleStudent.Grades)
            {
                finalExampleList += Convert.ToString(grade) + " ";        
            } 

            string finalExampleWholeData = finalExampleName + " - " + finalExampleList;
            lstStudents.Items.Add(finalExampleWholeData);
            lstStudents.SelectedIndex = 0;
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                for (int i = 0; i < ((rawDigits.Length)); i++)
                {
                    int y = Convert.ToInt32(rawDigits[i]);
                    sum += y;
                }
                average = sum / ((rawDigits.Length));

                //final declarartions to textboxes

                txtScoreTotal.Text = sum.ToString();
                txtScoreCount.Text = raw.ToString();
                txtAverage.Text = average.ToString();
            }
        }
    }
}
