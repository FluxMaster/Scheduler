using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Job: IComparable<Job>
    {
        private static int count;
        private String name;
        private int time;
        private int day;
        private int length;
        private List<Person> possibleWorkers;
        private int ID;
        private Person doer;

        public Job(String name, int day, int time, int length)
        {
            this.name = name;
            this.time = time;
            this.day = day;
            this.length = length;
            this.ID = count++;
            possibleWorkers = new List<Person>(0);
        }

        public void AddPerson(Person p)
        {
            this.possibleWorkers.Add(p);
        }
		
        public int SetDoer(Person p)
        {
            this.doer = p;
            return length;
        }
		
        public bool Conflicts(Job j)
        {
            if(ConDay(j.day) && ConTime(j.time,j.length))
            {
                return true;
            }
            return false;
        }

        public bool ConTime(int time, int length)
        {
            return  this.time == time
                    || (this.time - time < 0 && Math.Abs(this.time - time) < this.length)
                    || (this.time - time > 0 && Math.Abs(this.time - time) < length);
        }

        public bool ConDay(int day) { return this.day == day; }

		public bool CanDoHelper(Day[] week)
		{
			for(int i = this.time; i<this.time+length; i++)
			{
				if(week[this.day].getBlock(i))
					return false;
			}
			return true;
		}
		
		
		public bool Calculate()
		{
			bool flag = false;
			foreach(Person p in possibleWorkers)
			{
				if(p.AddJob(this))
				{
					flag = true;
					break;
				}
			}
			return flag;
		}
		
        public bool HoursChecker(int hours)
        {
            return this.length <= hours;
        }

		public void Sort()
		{
			this.possibleWorkers.Sort();
		}
		
        public override string ToString()
        {
            string result = name + " on " + Day.numberToDay(day) + " at " + time;
            return result;
        }

        public string Result()
        {
            if(this.doer != null)
                return this.ToString() +" "+ this.doer.ToString();
            return null;
        }

        public int CompareTo(Job other)
        {
            if(this.possibleWorkers.Count > other.possibleWorkers.Count)
            {
                return 1;
            }
            else if(this.possibleWorkers.Count < other.possibleWorkers.Count)
            {
                return -1;
            }
            return 0;
        }
    }
}
