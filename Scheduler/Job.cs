using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Job
    {
        private static int count;
        private String name;
        private int time;
        private int day;
        private int length;
        private List<Person> people;
        private int ID;
        private Person doer;

        public Job(String name, int day, int time, int length)
        {
            this.name = name;
            this.time = time;
            this.day = day;
            this.length = length;
            this.ID = count++;
            people = new List<Person>(0);
        }

        public void addPerson(Person p)
        {
            this.people.Add(p);
        }

        public bool conflicts(Job j)
        {
            if(conDay(j.day) && conTime(j.time,j.length))
            {
                return true;
            }
            return false;
        }

        public bool conTime(int time, int length)
        {
            return  this.time == time
                    || (this.time - time < 0 && Math.Abs(this.time - time) <= this.length)
                    || (this.time - time > 0 && Math.Abs(this.time - time) <= length);
        }

        public bool conDay(int day) { return this.day == day; }
    }
}
