using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy
{
    public class Person
    {
        private int _month;

        public static string Name = "Daisy";
        public int Month 
        { 
        get { return _month; }
        set {
            if ((value < 0) || (value > 12))

            { 
              throw new ArgumentOutOfRangeException();
            }
            else
            {
                _month = value;
            }
            }   
        }

        public static string MonthString(int Month)
        {
            string s = "";
            s = Month.ToString();
            return s;
        }

    }
}
