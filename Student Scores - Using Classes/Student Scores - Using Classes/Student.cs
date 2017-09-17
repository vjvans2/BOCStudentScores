using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Scores___Using_Classes
{
    public class Student
    {
        //Fields
        private string name;
        private List<int> grades = new List<int>();

        //Public Properties
        public string Name { get; set; }

        public List<int> Grades { get; set; }

        //Constructors
        public Student() { }
        public Student(string name, List<int> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }

        //Methods
        public string GetDisplayText(string sep)
        {
            return name + sep + Convert.ToString(grades);
        }
        public string GetDisplayText()
        {
            return name + " " + Convert.ToString(grades);
        }
    }
}
