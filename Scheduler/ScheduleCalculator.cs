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

        private void jobEditBtn_Click(object sender, EventArgs e)
        {
            JobEditor jbE = new JobEditor();
            jbE.ShowDialog();
        }
    }
}
