using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class CompareFunctions
    {
        public static bool ArraneNumbersAscending(int n1 , int n2) 
        {
            return n1 > n2;
        }
        public static bool ArraneNumbersDescending(int n1, int n2)
        {
            return n1 < n2;
        }
        public static bool ArrageStringLengthAscending(string A,string B)
        {
        return A.Length > B.Length;
        }
        public static bool ArrageStringLengthDescending(string A, string B)
        {
            return A.Length < B.Length;
        }
    }
}
