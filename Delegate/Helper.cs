using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //public delegate bool ConditionalFuncDelegate<T>(T x);

    internal class Helper<T>
    {
        public static List<T> GetElementsBasedOnPassedFunction(List<T> Element, Predicate<T> conditionalFunc)
        { 
        List<T> Result = new List<T>();
            if (Element is not null && conditionalFunc is not null)
                for (int i = 0; i < Element.Count; i++)
                    if (conditionalFunc(Element[i]))
                        Result.Add(Element[i]);

            return Result;
        }
        //public static List<int> GetEvenNumbers(List<int> Numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (Numbers is not null)
        //        for (int i = 0; i < Numbers.Count; i++)
        //            if (Numbers[i] % 2 != 1)
        //                Result.Add(Numbers[i]);

        //    return Result;
        //}
        //public static List<int> GetNumbersDivisibleBy7 (List<int> Numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (Numbers is not null)
        //        for (int i = 0; i < Numbers.Count; i++)
        //            if (Numbers[i] % 7 == 0)
        //                Result.Add(Numbers[i]);

        //    return Result;
        //}
    }
}
