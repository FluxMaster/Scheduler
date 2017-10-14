using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Day
    {
        //If person is blocked at "time i" then time[i]==true
        //24 hour clock where 0000 hours = time[0], 0100 hours == time[1], ..., 2300 hours == time[23]
        //Only 1 hour increments for now.
        private bool[] time; 

        public Day()
        {
            time = new bool[24];
            for(int i=0; i<time.Length; i++)
            {
                time[i] = false;
            }
        }

        public Day(bool[] times)
        {
            time = new bool[24];
            if (times.Length == 24)
            {
                this.time = times;
            }
            else
            {
                for (int i = 0; i < time.Length; i++)
                {
                    time[i] = false;
                }
            }
        }
    }
}