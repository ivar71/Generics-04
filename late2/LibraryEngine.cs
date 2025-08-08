using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace late2
{
    internal class LibraryEngine
    {
        // 1) User Defined Delegate
        public delegate string BookFunctionPointer(Book b);

        public static void ProcessBooks(List<Book> BList, BookFunctionPointer fPtr)
        {
            foreach (Book B in BList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        // 2) BCL Delegate (Func<Book,string>)
        //public static void ProcessBooks(List<Book> BList, Func<Book, string> fPtr)
        //{
        //    foreach (Book B in BList)
        //    {
        //        Console.WriteLine(fPtr(B));
        //    }
        //}
    }
}
