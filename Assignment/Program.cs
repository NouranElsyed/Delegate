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

            List<int> numbers = new List<int>() { 1,2,3,4};
            numbers.Exists();
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
