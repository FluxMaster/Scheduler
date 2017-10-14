using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    static class Calculator
    {
        public static String result1;
        public static String result2;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Calculate()
        {
            Person andy = new Person("Andy");
            Job clean = new Job("clean", 0, 2, 1);
            Job clean2 = new Job("clean", 0, 1, 1);

            if (andy.AddJob(clean))
            {
                result1 = "Success";
            }
            else
            {
                result1 = "Failure";
            }

            if (andy.AddJob(clean2))
            {
                result2 = "Success";
            }
            else
            {
                result2 = "Failure";
            }
        }
    }
}