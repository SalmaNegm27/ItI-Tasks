namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Duration
    {
        private decimal _hours;
        private decimal _minutes;
        private decimal _seconds;

        public decimal Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }


        public decimal Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }

        public decimal Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public Duration()
        {
            Seconds= 0;
            Minutes= 0;
            Hours= 0;
        }
        public Duration(decimal hours, decimal minutes, decimal second)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = second;
        }

        public Duration(int num)
        {
            _hours = (num / (60 * 60));
            _minutes = (num / 60) - (_hours * 60);
            _seconds = num - ((num / 60)*60);

        }

        //public Duration(float second)
        //{
        //    _hours = (decimal)(second / (60 * 60));
        //    _seconds = 0;
        //    _minutes = 0;
        //}

        //public Duration(int second)
        //{
        //    _hours = second / (60 * 60);
        //    _minutes = (second / 60) - _hours * 60;
        //    _seconds = 0;
        //}

        //public Duration(decimal second)
        //{
        //    _minutes = (int)second / 60;
        //    _seconds = second - (_minutes * 60);

        //}


        public string print()
        {
            return $"Hours: {Hours} , Minutes: {Minutes} , Second: {Seconds}";
        }

        public static Duration operator +(Duration d1, Duration d2)
        {

            return new Duration()
            {
                Seconds = d1.Seconds + d2.Seconds
            };

        }

        public static Duration operator +(Duration d1, int x)
        {

            return new Duration()
            {
                Seconds = d1.Seconds + x
            };

        }
        public static bool operator > (Duration d1, Duration d2)
        {
            return d1.Seconds > d2.Seconds;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.Seconds > d2.Seconds;
        }



    }
    }

