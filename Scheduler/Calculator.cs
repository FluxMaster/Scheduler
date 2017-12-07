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

        public static void Calculate(int hours)
        {

            /** Parse Jobs **/
            StreamReader JobsReader = new StreamReader("../../Jobs/Jobs.csv");
            List<Job> JobsList = new List<Job>();


            while (!JobsReader.EndOfStream)
            {
                String name = "";
                while (JobsReader.Peek() != ',')
                {
                    name += (char)JobsReader.Read();
                }
                Debug.WriteLine(name);
                JobsReader.Read();

                String temp = "";
                while (JobsReader.Peek() != ',')
                {
                    temp += (char)JobsReader.Read();
                }
                JobsReader.Read();
                Debug.WriteLine(temp);
                int day = Int32.Parse(temp);

                temp = "";
                while (JobsReader.Peek() != ',')
                {
                    temp += (char)JobsReader.Read();
                }
                JobsReader.Read();
                Debug.WriteLine(temp);
                int time = Int32.Parse(temp);

                temp = "";
                while (JobsReader.Peek() != '\n')
                {
                    temp += (char)JobsReader.Read();
                }
                JobsReader.Read();
                Debug.WriteLine(temp);
                int length = Int32.Parse(temp);

                JobsList.Add(new Job(name, day, time, length));
            }

            //Jobs List now contains all the Jobs

            /** Parse People **/

            String[] PeopleFiles = Directory.GetFiles("../../../PeopleSchedules");
            List<Person> PeopleList = new List<Person>();

            foreach (String FileName in PeopleFiles)
            {
                StreamReader PersonReader = new StreamReader(FileName);

                String name = "";
                String ID = "";

                for (int i = 0; i < 6; i++)
                    PersonReader.Read();

                while (PersonReader.Peek() != '\n' && PersonReader.Peek() != 13)
                {
                    name += (char)PersonReader.Read();
                }

                PersonReader.ReadLine();

                for (int i = 0; i < 13; i++)
                    PersonReader.Read();

                while (PersonReader.Peek() != '\n' && PersonReader.Peek() != 13)
                {
                    ID += (char)PersonReader.Read();
                }
                Debug.WriteLine(name + " " + ID);
                //Skips the blank lines and junk
                Debug.WriteLine(PersonReader.ReadLine());
                Debug.WriteLine(PersonReader.ReadLine());
                Debug.WriteLine(PersonReader.ReadLine());

                bool[][] sched = new bool[7][];

                for (int i = 0; i < 7; i++)
                {
                    sched[i] = new bool[24];
                }


                for (int i = 0; i < 24; i++)
                {
                    while (PersonReader.Peek() != ',')
                        PersonReader.Read();
                    PersonReader.Read();
                    for (int j = 0; j < 7; j++)
                    {
                        if (PersonReader.Peek() == ',')
                        {
                            sched[j][i] = false;
                        }
                        else
                        {
                            sched[j][i] = true;
                        }

                        while (PersonReader.Peek() != ',')
                            PersonReader.Read();
                        PersonReader.Read();
                    }
                    PersonReader.ReadLine();
                }

                Day[] week = new Day[7];

                for (int i = 0; i < 7; i++)
                {
                    week[i] = new Day(sched[i]);
                }

                Person temp = new Person(name, ID, week, hours);
                PeopleList.Add(temp);

                Debug.Write("\n");
                temp.ConsoleDebug();
                //Out1 = temp.ToString();
                //End Parse One Person for Testing
            }

            //People List now Contains all the People.

            /** PreProcess **/
            /* For each job, add each person who can perform the job*/

            foreach (Job j in JobsList)
            {
                foreach (Person p in PeopleList)
                {
                    if (p.CanDo(j))
                    {
                        j.AddPerson(p);
                        Debug.WriteLine(p + " can do " + j);
                        p.IncAvail(); // increase the availability score
                    }
                }
                // For each job, sort possible workers by availability score
                j.Sort();
            }
            // sort all jobs
            JobsList.Sort();

            //Now The JobsList is ready for calculating who does what

            /** Calculate **/
            bool flag = false;
            Job offender = null;
            foreach (Job j in JobsList)
            {
                if (!j.Calculate())
                {
                    flag = true;
                    offender = j;
                }
                if (flag)
                {
                    Debug.Write("Job \"" + offender.ToString() + "\" does not have possible doers!\n");
                }
            }


            /** WriteResult **/

            StreamWriter file = new StreamWriter("../../../Results.txt", false);

            foreach (Job j in JobsList)
            {
                if (j.Result() != null)
                {
                    Debug.WriteLine(j.Result());
                    file.WriteLine(j.Result());
                }
                else
                {
                    Debug.WriteLine(j + " Needs Filling");
                    file.WriteLine(j + " Needs Filling");
                }
            }

            Debug.WriteLine("\nPeople who need assignments.");
            file.WriteLine("\nPeople who need assignments.");

            foreach(Person p in PeopleList)
            {
                if(!p.IsFull())
                {
                    Debug.WriteLine(p + " needs " + p.HoursNeeded() + " hours.");
                    file.WriteLine(p + " needs " + p.HoursNeeded() + " hours.");
                }
            }

            file.Close();
        }
    }
}