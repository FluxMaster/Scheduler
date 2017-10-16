using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            //create new employee schedule maker form and display it when employee button is clicked
            ScheduleMaker schdulemkr = new ScheduleMaker();
            schdulemkr.ShowDialog();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            //create new schedule calculator form and display it if correct password in textbox
            if (passwrdTxtBox.Text == "123") 
            {
                ScheduleCalculator calculator = new ScheduleCalculator();
                calculator.ShowDialog();
            }
            //if incorrect password, show error message
            else
            {
                MessageBox.Show("Wrong password.");
            }
        }
    }
}
