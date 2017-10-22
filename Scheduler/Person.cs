using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Person : IComparable<Person>
    {
        private String name;
        private int avail;
        private int hours;
        private Day[] week;
        private List<Job> jobsList;

        public Person(String name)
        {
            this.name = name;
            this.avail = 0;
            this.hours = 0;
            jobsList = new List<Job>(0);
            week = new Day[7];
            for (int i = 0; i < 7; i++)
            {
                week[i] = new Day();
            }
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

            j.SetDoer(this);
            jobsList.Add(j);
            return true;
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

        public override string ToString()
        {
            String result = name + "\n";
            foreach(Job job in jobsList)
            {
                result += job.ToString() + "\n";
            }
            return result;
        }
    }
}
