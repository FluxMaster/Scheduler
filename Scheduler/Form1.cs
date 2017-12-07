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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "How Many Hours should Each Worker Work?";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Calculator.Calculate(Int32.Parse(textBox1.Text));
            MessageBox.Show("Finished Calculating. Check Results.txt", "Complete");
            this.Close();
        }
    }
}
