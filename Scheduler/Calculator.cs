using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    static class Calculator
    {
        public static String Out1;
        public static String Out2;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static void Calculate()
        {
            /** Parse Jobs **/

            /** Parse People **/
            StreamReader sr = new StreamReader("../../../PeopleSchedules/test13.csv");


            //Parse 1 Person for Testing: Loop over all files later
            String name = "";
            String ID = "";

            for (int i = 0; i < 6; i++)
                sr.Read();

            while (sr.Peek() != ',')
            {
                name += (char)sr.Read();
            }

            sr.ReadLine();

            for (int i = 0; i < 13; i++)
                sr.Read();

            while (sr.Peek() != '\n')
            {
                ID += (char)sr.Read();
            }

            //Skips the blank lines and junk
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();

            bool[][] sched = new bool[7][];

            for(int i=0; i<7; i++)
            {
                sched[i] = new bool[24];
            }


            for(int i=0; i<24; i++)
            {
                while (sr.Peek() != ',')
                    sr.Read();
                sr.Read();
                for (int j=0; j<7; j++)
                {
                    if(sr.Peek() == ',')
                    {
                        sched[j][i] = false;
                    }
                    else
                    {
                        sched[j][i] = true;
                    }

                    while (sr.Peek() != ',')
                        sr.Read();
                    sr.Read();
                }
                sr.ReadLine();
            }

            Day[] week = new Day[7];

            for(int i=0; i<7; i++)
            {
                week[i] = new Day(sched[i]);
                Debug.Write(week[i]);
                Debug.Write("\n");
            }

            Person temp = new Person(name, ID, week);

            Debug.Write("\n");
            temp.ConsoleDebug();

            Out1 = temp.ToString();
            //End Parse One Person for Testing


            /** PreProcess **/
            /** Calculate **/
            /** WriteResult **/


            /* Testing for job collision
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
            */
        }
    }
}