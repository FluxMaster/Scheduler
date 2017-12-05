using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Person : IComparable<Person>
    {
        private String name;
        private String ID;
        private int avail;
        private int hours;
        private Day[] week;
        private List<Job> jobsList;

        public Person(String name, String ID, int hours)
        {
            this.name = name;
            this.ID = ID;
            this.avail = 0;
            this.hours = hours;
            jobsList = new List<Job>(0);
            week = new Day[7];
            for (int i = 0; i < 7; i++)
            {
                week[i] = new Day();
            }
        }

        public Person(String name, String ID, Day[] week, int hours)
        {
            this.name = name;
            this.ID = ID;
            this.avail = 0;
            this.hours = hours;
            jobsList = new List<Job>(0);
            this.week = week;
        }

        //returns true if successful add, false if not
        public bool AddJob(Job j)
        {
            //check for conflicts
            foreach (Job job in jobsList)
            {
                if (j.Conflicts(job))
                {
                    return false;
                }
            }

            if(!j.HoursChecker(this.hours))
            {
                return false;
            }

            int hours = j.SetDoer(this);
            DecHours(hours);
            jobsList.Add(j);
            return true;
        }
		
		//returns true if this person is initially
		//available for this job.
		public bool CanDo(Job j)
		{
			return j.CanDoHelper(this.week);
		}

        public int CompareTo(Person other)
        {
            if (this.avail > other.avail)
            {
                return 1;
            }
            else if(this.avail <other.avail)
            {
                return -1;
            }
            return 0;
        }

        public void IncAvail()
        {
            this.avail++;
        }

        public void DecHours(int hours)
        {
            this.hours -= hours;
        }

        public override string ToString()
        {
            String result = name + " " + ID;
            /*
            foreach (Job job in jobsList)
            {
                result += job.ToString() + "\n";
            }
            */
            return result;
        }

        public void ConsoleDebug()
        {
            for(int i=0; i<7; i++)
            {
               Debug.Write(this.week[i]+"\n");
            }
        }
    }
}
