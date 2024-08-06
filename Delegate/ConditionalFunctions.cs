using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class ConditionalFunctions
    {
        public static bool CheckOdd(int Number) 
        {
        return Number%2 == 1;
        }
        public static bool CheckEven(int Number)
        {
            return Number % 2 == 0;
        }
        public static bool CheckDivisibleBy7(int Number)
        {
            return Number % 7 == 0;
        }

        public static bool CheckstringLengthLessThan4(string str) 
        {
            return str.Length<4;
        }
    }
}
