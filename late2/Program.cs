namespace late2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
            new Book("111", "C# Basics", new string[] { "Ali", "Omar" }, new DateTime(2004, 11, 22), 150),
            new Book("222", "Advanced C#", new string[] { "Sara" }, new DateTime(2021, 3, 15), 200)
             };

            Console.WriteLine("=== User Defined Delegate ===");
            LibraryEngine.ProcessBooks(books, new LibraryEngine.BookFunctionPointer(BookFunctions.GetTitle));

            Console.WriteLine("\n=== BCL Delegate (Func) ===");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);

            Console.WriteLine("\n=== Anonymous Method ===");
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

            Console.WriteLine("\n=== Lambda Expression ===");
            LibraryEngine.ProcessBooks(books, b => b.PublicationDate.ToShortDateString());
        }
    }
}
