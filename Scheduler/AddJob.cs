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
    public partial class AddJob : Form
    {

        CheckBox[] boxes; //array of checkboxes

        public AddJob()
        {
            InitializeComponent();
            boxes = new CheckBox[] {sunChkBox, monChkBox,tuesChkBox, wedChkBox, thursChkBox, fridayChkBox,satChkBox };
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            String job = jobTxtBox.Text;
            String numWorkersString = workersTxtBox.Text;
            String hoursString = hoursTxtBox.Text;
            string time = timeBox.Text;

            int numWorkers=0;
            int hours=0;

            if (String.IsNullOrEmpty(job))  //input validation, checks for nonempty string
            {
                MessageBox.Show("Enter the job name.", "Error");
            }
            else if (!int.TryParse(numWorkersString, out numWorkers))   //input validation, checks for int
            {
                MessageBox.Show("Only integer values for number of workers.", "Error");
                return;
            }
            else if (!int.TryParse(hoursString, out hours)) //input validation, checks for int
            {
                MessageBox.Show("Only integer values for number of hours.", "Error");
                //hours = outHours;
                return;
            }
            else if (string.IsNullOrEmpty(time))    //checks that one thing is selected in dropdown list
            {
                MessageBox.Show("Pick a time range.", "Error");
            }
            else if (!(monChkBox.Checked || tuesChkBox.Checked || wedChkBox.Checked || thursChkBox.Checked || fridayChkBox.Checked
                || satChkBox.Checked || sunChkBox.Checked)) //checks that at least one weekday checkbox is selected
            {
                MessageBox.Show("Pick a day of the week.", "Error");
            }
            else
            {
                JobEditor jobfrm = (JobEditor)Application.OpenForms["JobEditor"];   //create reference to open jobeditor form so one can change its values in this form
                string temp = "";

                for (int i = 0; i < 7; i++) //loops for each day of week
                {
                    if (boxes[i].Checked)
                    {//if that day of week checkbox is checked, repeats for number of workers input
                        for (int j = numWorkers; j > 0; j--)
                        {
                            //adds input data to temporary string variable
                            temp += job + "," + Day.numberToDay(i) + "," +Day.numberToTime(timeIndex((String)timeBox.Text)) + "," + hours + "\r\n";
                        }
                    }
                }
                //appends temp data to existing data in JobEditor forms textbox
                jobfrm.TextBoxValue = jobfrm.TextBoxValue + temp;
            }
        }

        //close addjob form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //converts string time (12AM,1PM, etc) to an int value
        public int timeIndex(String time)
        {
            for (int i = 0; i < Day.timeList.Length; i++)
            {
                if (time.Equals(Day.timeList[i]))
                    return i;
            }
            return -1;
        }
    }
}
