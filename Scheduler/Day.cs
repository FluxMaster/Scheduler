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
            this.time = times;
        }

        public bool[] getTime()
        {
            return time;
        }

        public bool getBlock(int block)
        {
            return time[block];
        }

        public void setTime(bool[] time)
        {
            this.time = time;
        }

        public void setBlock(int block, bool state)
        {
            time[block] = state;
        }

        public static String numberToDay(int x)
        {
            String day = "";
            switch (x)
            {
                case 0:
                    day = "Sunday";
                    break;
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                default:
                    day = "Error: No such day exists.";
                    break;
            }
            return day;
        }

        public static int dayToNumber(String x)
        {
            int num;
            switch (x)
            {
                case "Sunday":
                    num = 0;
                    break;
                case "Monday":
                    num = 1;
                    break;
                case "Tuesday":
                    num = 1;
                    break;
                case "Wednesday":
                    num = 0;
                    break;
                case "Thursday":
                    num = 0;
                    break;
                case "Friday":
                    num = 0;
                    break;
                case "Saturday":
                    num = 0;
                    break;
                default:
                    num = -1;
                    break;
            }
            return num;
        }

        private static String[] timeList = { "12AM", "1AM", "2AM", "3AM", "4AM", "5AM", "6AM", "7AM", "8AM", "9AM", "10AM", "11AM", "12PM", "1PM", "2PM", "3PM", "4PM", "5PM", "6PM", "7PM", "8PM", "9PM", "10PM", "11PM" };

        public static String numberToTime(int x)
        {
            return timeList[x];
        }

        public static int timeToNumber(String time)
        {
            for (int i = 0; i < timeList.Length; i++)
            {
                if (time.Equals(timeList[i]))
                    return i;
            }
            return -1;
        }

        public override string ToString()
        {
            String output = "";
            for(int i=0; i<24; i++)
            {
                output += this.time[i] + ",";
            }
            return output;
        }
    }
}