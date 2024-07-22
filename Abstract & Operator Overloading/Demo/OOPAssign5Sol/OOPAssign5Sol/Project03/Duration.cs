using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign5Sol.Project03
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public static int H { get; private set; }

        public override string ToString()
        {
            if (Hours == 0)
                return $"Minutes: {Minutes} , Seconds: {Seconds}";
            return $"Hours: {Hours} , Minutes: {Minutes} , Seconds: {Seconds}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            else if (obj.GetType() != GetType()) return false;
            else
            {
                Duration Dur = (Duration)obj;
                return (Dur.Hours == Hours && Minutes == Dur.Minutes && Seconds == Dur.Seconds);
            }
        }

        public override int GetHashCode()
        {
            return (Hours, Minutes, Seconds).GetHashCode();
        }

        public Duration(int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
        }

        public Duration() : this(0, 0, 0)
        {
        }

        public Duration(int h, int m) : this(h, m, 0)
        {

        }

        public Duration(int C) : this(C / 3600, ((C - 3600 * (C / 3600))) / 60, C - (((C / 3600) * 3600) + ((((C - 3600 * (C / 3600))) / 60) * 60)))
        {

        }

        public static Duration operator +(Duration D1, Duration D2)
        {
            return new Duration()
            {
                Hours = D1.Hours + D2.Hours,
                Minutes = D1.Minutes + D2.Minutes,
                Seconds = D1.Seconds + D2.Seconds
            };
        }

        public static Duration operator +(Duration D1, int D2)
        {
            return new Duration()
            {
                Hours = D1.Hours,
                Minutes = D1.Minutes,
                Seconds = D1.Seconds + D2
            };
        }

        public static Duration operator +(int D2, Duration D1)
        {
            return new Duration()
            {
                Hours = D1.Hours,//+ (D2 / 3600),
                Minutes = D1.Minutes, // + (D2 - (D2 / 3600) * 3600) / 60,
                Seconds = D1.Seconds + D2// + (D2 - (((D2 / 3600) * 3600) + (((D2 - (D2 / 3600) * 3600) / 60) * 60)))
            };
        }

        public static Duration operator ++(Duration D1)
        {
            return new Duration()
            {
                Hours = D1.Hours,
                Minutes = D1.Minutes + 1,
                Seconds = D1.Seconds
            };
        }

        public static Duration operator --(Duration D1)
        {
            return new Duration()
            {

                Hours = ((D1.Hours * 60) - 60) / 60,
                Minutes = (D1.Hours * 60) - (((D1.Hours * 60) - 60) / 60) * 60 - 1,
                Seconds = D1.Seconds
            };
        }

        public static Duration operator -(Duration D1, Duration D2)
        {
            int totalSeconds1 = D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds;
            int totalSeconds2 = D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds;
            return new Duration()
            {
                Hours = 0,
                Minutes = 0,
                Seconds = Math.Max(totalSeconds1 - totalSeconds2, totalSeconds2 - totalSeconds1)
            };
        }

        public static bool operator >(Duration D1, Duration D2)
        {
            return (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds) > (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
        }

        public static bool operator <(Duration D1, Duration D2)
        {
            return (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds) < (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
        }

        public static bool operator <=(Duration D1, Duration D2)
        {
            return (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds) <= (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
        }

        public static bool operator >=(Duration D1, Duration D2)
        {
            return (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds) >= (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
        }

        //public static explicit operator DateTime(Duration D)
        //{
        //    TimeSpan t = new TimeSpan(D.Hours, D.Minutes, D.Seconds);
        //    DateTime d = Convert.ToDateTime(t);
        //    return d;
        //    // return new DateTime( D.Hours, D.Minutes, D.Seconds);
        //}

    }
}
