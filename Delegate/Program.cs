namespace Delegate
{
    //public delegate int StringFuncDelegate(string str);


    internal class Program
    {
        static void Main(string[] args)
        {
            //StringFuncDelegate stringFuncDelegate;
            //stringFuncDelegate = new StringFuncDelegate(StringFunctions.CountUpperChar);
            //int Result = stringFuncDelegate("Hi,I'm Nouran");
            //Console.WriteLine(Result);
            //stringFuncDelegate += new StringFuncDelegate(StringFunctions.CountLowerChar);
            //Result = stringFuncDelegate("Hi,I'm Nouran");
            //Console.WriteLine(Result);

            //int[] Numbers = { 10, 12, 3, 8, 20, 17 };
            //SortingAlgorithms<int>.BubbleSort(Numbers, CompareFunctions.ArraneNumbersAscending);
            //foreach (int i in Numbers)
            //    Console.WriteLine(i);
            //SortingAlgorithms<int>.BubbleSort(Numbers, CompareFunctions.ArraneNumbersDescending);
            //foreach (int i in Numbers)
            //    Console.WriteLine(i);


            //string[] Names = { "Nouran", "Amr", "Hala", "Samar", "Mai", "Aliaa" };
            //Func<string, string, bool> NamesFunc = CompareFunctions.ArrageStringLengthAscending;
            //SortingAlgorithms<string>.BubbleSort(Names, NamesFunc);
            //foreach (string i in Names)
            //    Console.WriteLine(i);
            //SortingAlgorithms<string>.BubbleSort(Names, CompareFunctions.ArrageStringLengthDescending);
            //foreach (string i in Names)
            //    Console.WriteLine(i);


            // List<int> Numbers = Enumerable.Range(1, 100).ToList(); 

            //List<int> OddNumbers =  Helper.GetOddNumbers(Numbers);
            // foreach (int i in OddNumbers)
            // {
            //     Console.Write($"{i} ");
            // }
            // Console.WriteLine("\n");

            // List<int> EvenNumbers = Helper.GetEvenNumbers(Numbers);
            // foreach (int i in EvenNumbers)
            // {
            //     Console.Write($"{i} ");
            // }
            // Console.WriteLine("\n");
            // List<int> NumbersCanDividedBy7 = Helper.GetNumbersDivisibleBy7(Numbers);
            // foreach (int i in NumbersCanDividedBy7)
            // {
            //     Console.Write($"{i} ");
            // }

            //List<int> Numbers = Enumerable.Range(1, 100).ToList();
            //Predicate<int> oddNumberFunc = ConditionalFunctions.CheckOdd;
            //List<int> OddNumbers = Helper<int>.GetElementsBasedOnPassedFunction(Numbers,oddNumberFunc);
            //foreach (int i in OddNumbers)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine("\n");


            //Predicate<int> evenNumberFunc = ConditionalFunctions.CheckEven;
            //List<int> EvenNumbers = Helper<int>.GetElementsBasedOnPassedFunction(Numbers, evenNumberFunc);
            //foreach (int i in EvenNumbers)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine("\n");

            //Predicate<int> NumbercanDivisibleBy7Func = ConditionalFunctions.CheckDivisibleBy7;
            //List<int> NumbercanDivisibleBy7 = Helper<int>.GetElementsBasedOnPassedFunction(Numbers, NumbercanDivisibleBy7Func);
            //foreach (int i in NumbercanDivisibleBy7)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine("\n");
            //List<string> Names = new List<string>{ "Nouran", "Amr", "Hala", "Samar", "Mai", "Aliaa", "Mazen","Hanan","Asmaa","Nourhan" };
            //List<string> NamesLengthLessthan4 = Helper<string>.GetElementsBasedOnPassedFunction(Names,ConditionalFunctions.CheckstringLengthLessThan4);
            //foreach (string i in NamesLengthLessthan4)
            //    Console.Write($"{i} ");


            //Predicate<int> predicate;
            //predicate = TestingFunction.Test01;
            //predicate.Invoke(10);      

            //Func<int, string> func;
            //func = TestingFunction.Test02;
            //func.Invoke(5);

            //Action<string> action;
            //action = delegate (string str) { Console.WriteLine($"Helo {str}"); };
            //action("Yomy");
            //Action<int> action;


        }
        
    }
    class TestingFunction

    {


        public static bool Test01(int X) 
        {
            return X > 0;
        }


        public static string Test02(int X)
        {
            return X.ToString();
        }

        //public static void Test03() 
        //{
        //    Console.WriteLine("Hello");
        //}

    }
}
