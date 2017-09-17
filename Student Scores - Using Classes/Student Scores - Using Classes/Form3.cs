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
    public partial class Form3 : Form
    {
        string receivedData;
        List<int> sepGrades = new List<int>();
        string newData;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();            
            DialogResult button = form4.ShowDialog();
            //form isn't active until here, wait until close, then keep going            
            if (button == DialogResult.OK)
            {
                string x = form4.ReturnData();
                lstScores.Items.Add(x);
            }
            lstScores.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            string y = lstScores.Text;
            lstScores.Items.Remove(y);
            DialogResult button = form5.ShowDialog();
            //form isn't active until here, wait until close, then keep going
            if (button == DialogResult.OK)
            {
                string x = form5.ReturnData();
                lstScores.Items.Add(x);
            }
            lstScores.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtReadOnlyName.Text;
            string b = "";
            string allNums = "";
            for (int i = 0; i < lstScores.Items.Count; i++)
            {
                b = Convert.ToString(lstScores.Items[i]);
                allNums += b + " ";
            }
            newData = name + "- " + allNums;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string returnDataMain()
        {
            return newData;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string adjustData = receivedData; //SET data - right side

            adjustData = adjustData.Trim();
            string[] splitAdjustData = adjustData.Split('-');

            string name = splitAdjustData[0];
            txtReadOnlyName.Text = name;

            string digits = splitAdjustData[1];
            digits = digits.Trim();
            string[] rawUpdateDigits = digits.Split(' ');


            foreach (string num in rawUpdateDigits)
            {
                lstScores.Items.Add(num);
            }

            lstScores.SelectedIndex = 0;
        }
        public void GetData (string s)
        {
            receivedData = s; //GET data - left side
            //txtReadOnlyName.Text = receivedData; //SET data - right side
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string x = lstScores.Text;
            lstScores.Items.Remove(x);
            lstScores.SelectedIndex = 0;
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            lstScores.Items.Clear();
        }
    }
}
