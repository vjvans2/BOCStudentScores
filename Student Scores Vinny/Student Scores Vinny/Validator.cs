using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Scores_Vinny
{
    public static class Validator
    {
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " You are missing a required field.");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPresent(ListBox listBox)
        {
            if (listBox.Text == "")
            {
                MessageBox.Show("No Data Given.  Please have one valid entry.");
                return false;
            }
            return true;
        }
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " Score must be an integer.");
                textBox.Focus();
                return false;
            }
        }
        public static bool IsWithinRange(TextBox textBox, int min, int max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " Score must be between " + min
                    + " and " + max + ".");
                textBox.Focus();
                return false;
            }
            return true;
        }

    }
}
