using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //public delegate bool comparing<T>(T n1 , T n2);
    internal class SortingAlgorithms<T>
    {
    
        public static void BubbleSort(T[] array,Func<T,T,bool> compareFunc)
        {

            if (array is not null)
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                        if (compareFunc(array[j], array[j+1]))
                            SWAP(ref array[j], ref array[j + 1]);
        }
        public static void SWAP(ref T n1 , ref T n2) 
        {
        T temp = n1;
        n1 = n2;
        n2 = temp;
        }
    }
}
