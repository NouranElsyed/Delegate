using System.Collections.Generic;

namespace Assignment
{
    public delegate string bookFuncDelegate(Book B);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //bookFuncDelegate fPtr;
            //fPtr = new bookFuncDelegate(BookFunctions.GetTitle);
            //Func<Book, string> Func01;
            ////Get ISBN
            //Func01 = delegate (Book B) { throw new NotImplementedException(); };
            ////Get PublicationDte
            //Func<Book, string> Func02;
            //Func02 = (X) => X.ToString();

            #endregion
            #region Part02

            ImplementedList<int> numbers = new ImplementedList<int>();



            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            Console.WriteLine(numbers.Exist(x => x == 2));

            Console.WriteLine(numbers.Find(x => x > 2));

            List<int> all = new List<int>();
            all = numbers.FindAll(x => x % 2 == 0);
            Console.WriteLine(numbers.FindIndex(x => x == 3));
            Console.WriteLine(numbers.FindLast(x => x < 4));
            Console.WriteLine(numbers.FindLastIndex(x => x < 4));

            numbers.Foreach(x => Console.Write($"{x} "));
            Console.WriteLine();

            Console.WriteLine(numbers.TrueForAll(x => x > 0));

            #endregion


        }

    }

  



    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _publicationDate, decimal _Price)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();

        }

    }
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            throw new NotImplementedException();
        }
        public static string GetAuthor(Book B)
        {
            throw new NotImplementedException();
        }
        public static string GetPrice(Book B)
        {
            throw new NotImplementedException();
        }



    }
    public class LibraryEngine
    {
     
        public static void ProcessBooks(List<Book> bList, bookFuncDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

    }
}
