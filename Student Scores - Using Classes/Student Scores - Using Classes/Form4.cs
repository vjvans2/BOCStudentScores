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
    public partial class Form4 : Form
    {
        string addedNum;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addedNum = txtAddScore.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string ReturnData()
        {
            return addedNum;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
