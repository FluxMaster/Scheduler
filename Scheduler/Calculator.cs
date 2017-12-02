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
			StreamReader JobsReader = new StreamReader("./Jobs/Jobs.csv");
			List<Job> JobsList = new List<Job>();
			
			
			while(JobsReader.hasNextLine())
			{
				String name = new String();
				while(jobs.Reader.Peek() != ',')
				{
					name += (char)JobsReader.Read();
				}
				JobsReader.Read();
				
				String temp = new String();
				while(jobs.Reader.Peek() != ',')
				{
					temp += (char)JobsReader.Read();
				}
				JobsReader.Read();
				int day = Int32.parse(temp);
				
				String temp = new String();
				while(jobs.Reader.Peek() != ',')
				{
					temp += (char)JobsReader.Read();
				}
				JobsReader.Read();
				int time = Int32.parse(temp);
				
				String temp = new String();
				while(jobs.Reader.Peek() != ',')
				{
					temp += (char)JobsReader.Read();
				}
				JobsReader.Read();
				int length = Int32.parse(temp);
				
				JobsList.add(new Job(name,day, time, length));
			}
			
			//Jobs List now contains all the Jobs
			
            /** Parse People **/
			
			String[] PeopleFiles = Directory.GetFiles("../PeopleSchedules");
			List<Person> PeopleList = new List<Person>();
			
			foreach(String FileName in PeopleFiles)
			{
				StreamReader PersonReader = new StreamReader(FileName);
				
				//Parse 1 Person for Testing: Loop over all files later
				String name = "";
				String ID = "";
				
				for (int i = 0; i < 6; i++)
					PersonReader.Read();

				while (PersonReader.Peek() != ',')
				{
					name += (char)PersonReader.Read();
				}
				
				PersonReader.ReadLine();
				
				for (int i = 0; i < 13; i++)
					PersonReader.Read();
				
				while (PersonReader.Peek() != '\n')
				{
					ID += (char)PersonReader.Read();
				}
				
				//Skips the blank lines and junk
				PersonReader.ReadLine();
				PersonReader.ReadLine();
				PersonReader.ReadLine();
				
				bool[][] sched = new bool[7][];
				
				for(int i=0; i<7; i++)
				{
					sched[i] = new bool[24];
				}
				
				
				for(int i=0; i<24; i++)
				{
					while (PersonReader.Peek() != ',')
						PersonReader.Read();
					PersonReader.Read();
					for (int j=0; j<7; j++)
					{
						if(PersonReader.Peek() == ',')
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
				
				for(int i=0; i<7; i++)
				{
					week[i] = new Day(sched[i]);
					Debug.Write(week[i]);
					Debug.Write("\n");
				}
				
				Person temp = new Person(name, ID, week);
				PeopleList.add(temp);
				
				Debug.Write("\n");
				temp.ConsoleDebug();
				Out1 = temp.ToString();
				//End Parse One Person for Testing
			}
			
			//People List now Contains all the People.
			
            /** PreProcess **/
			/* For each job, add each person who can perform the job*/
			
			foreach(Job j in JobsList)
			{
				foreach(Person p in PeopleList)
				{
					if(p.CanDo(j))
					{
						j.AddPerson(p);
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
			Job offender;
			foreach(Job j in JobsList)
			{
				if(!j.Calculate())
				{
					flag = true;
					offender = j;
					break;
				}
			}
			
			if(flag)
			{
				Debug.write("Job \"" + offender.toString() + "\" does not have possible doers!\n");
			}
			else
			{
				/** WriteResult **/
				
				
			}

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