using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    internal class NUnitTesting
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        public bool PosOrNeg(int num)
        {
            bool PoNresult = num < 0 ? false : true;
            return PoNresult;
        }
        public int SumOfNatNum(int num)
        {
            int sum = (num * (num + 1)) / 2;
            return sum;
        }
        public bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }   

        
    }
}
