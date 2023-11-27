using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
     partial class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        static int count;

        private readonly int ID;
        private const string name="Time";

        static Time()
        {
            count = 0;
        }

        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    hours = value;
                }
                else
                {
                    Console.WriteLine("Неверный диапазон");
                }
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minutes = value;
                }
                else
                {
                    Console.WriteLine("Неверный диапазон");
                }
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    seconds = value;
                }
                else
                {
                    Console.WriteLine("Неверный диапазон");
                }
            }

        }

        public Time()
        {
           
            hours = 0;
            minutes = 0;
            seconds = 0;

            count++;

            ID = GetHashCode();
        }

        public Time(int hours, int minutes, int seconds)
        {
        
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;

            count++;

            ID = GetHashCode();
        }

        public Time(int hours, int minutes)
        {
            
            Hours = hours;
            Minutes = minutes;
            Seconds = 0;

            count++;

            ID = GetHashCode();
        }


        private Time(int hours)
        {
            Hours = hours;
            Minutes = 0;
            Seconds = 0;

            count++;

            ID = GetHashCode();
        }

        public void Convert(ref Time time, out int minutes)
        {
            minutes = time.hours * 60 + time.minutes;
        }

        public static void Info()
        {
            Console.WriteLine("count: " + count);
        }

        

    }

    partial class Time
    {
        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";

        }

        public override bool Equals(object? obj)
        {
            if (obj is Time time)
            {
                if (time.hours != hours)
                    return false;

                if (time.minutes != minutes)
                    return false;

                if (time.seconds != seconds)
                    return false;

                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            
            return ToString().GetHashCode();
        }

    }
}

