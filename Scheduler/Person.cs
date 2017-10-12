using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Person
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
            for (int i = 0; i < 7; i++)
            {
                week[i] = new Day();
            }
        }

        //returns true if successful add, false if not
        public bool addJob(Job j)
        {
            //check for conflicts
            foreach(Job job in jobsList)
            {
                if(j.conflicts(job))
                {
                    return false;
                }
            }
            jobsList.Add(j);
            j.addPerson(this);
            return true;
        }
    }
}
