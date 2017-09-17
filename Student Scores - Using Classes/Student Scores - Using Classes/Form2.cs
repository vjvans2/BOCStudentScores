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
    public partial class Form2 : Form
    {
        string finalStudentGrades;
        Student form2Student;
        List<int> grades = new List<int>();
        string finalNewStudentData;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string studentName = txtName.Text;
            form2Student = new Student(studentName, grades);

            string finalStudentName = form2Student.Name;
            foreach (int grade in form2Student.Grades)
            {
                finalStudentGrades += Convert.ToString(grade) + " ";
            }
            finalNewStudentData = 
                   finalStudentName + " - " + finalStudentGrades;
                      
            this.Close();
        }

        public string ReturnData()
        {
            return finalNewStudentData;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            int scoreValue;
            scoreValue = Convert.ToInt32(txtAddScore.Text);
            grades.Add(scoreValue);
            scoreValue = grades[0];
            string scoreString = "";
            foreach (int score in grades)
            {
                scoreString += score.ToString() + " ";
            }
            txtReadOnlyScores.Text = scoreString;
            txtAddScore.Text = "";
            txtAddScore.Focus();
        }
    }
}
