using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare & Initialize variable
            string letterGrade = ""; 

            double numberGrade = 0;

          //If else statement to set letter grade

            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // Display letter grade in the letter grade text box

            txtLetterGrade.Text = letterGrade;
            //Focus back to  number Grade
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            //Close the form

            this.Close();
        }
    }
}
