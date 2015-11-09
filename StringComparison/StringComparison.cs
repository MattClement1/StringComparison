/*
* Created by: Matthew Clement
* Created on: 9-Nov-2015
* Created for: Unit #4-06
* This program compares 2 strings and says if they are the same
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringComparison
{
    public partial class frmStringComparison : Form
    {

        public bool CheckIfSame(string stringOne, string stringTwo)
        {

            //This function converts strings to caps and compare them

            bool sameString = false;

            //Convert strings to caps
            stringOne = stringOne.ToUpper();
            stringTwo = stringTwo.ToUpper();

            //Compare strings
            if (stringOne == stringTwo)
            {
                sameString = true;
            }
            else
            {
                sameString = false;
            }

            //Return bool
            return sameString;

        }

        public frmStringComparison()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //String inputs
            string stringInputOne = this.txtStringOne.Text;
            string stringInputTwo = this.txtStringTwo.Text;

            bool answer;

            //Call function and pass strings
            answer = CheckIfSame(stringInputOne, stringInputTwo);

            //Display if the strings are the same or not
            if (answer == true)
            {
                MessageBox.Show("The strings are the same!");
            }
            else
            {
                MessageBox.Show("The strings are not the same!");
            }

        }
    }
}
