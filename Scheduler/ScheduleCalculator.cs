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
    public partial class ScheduleCalculator : Form
    {
        public ScheduleCalculator()
        {
            InitializeComponent();
        }

        private void Schedule_Calculator_Load(object sender, EventArgs e)
        {
          
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        //opens JobEditor form when clicked
        public void JobEditBtn_Click(object sender, EventArgs e)
        {
            JobEditor jbE = new JobEditor();
            jbE.ShowDialog();
        }

        //displays about info when clicked
        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program for UHV Software Engineering Class Fall 2017.\n Authors: Fransico Guerro, Andy Polasek, Jesse Silva.", "About");
        }
    }
}
