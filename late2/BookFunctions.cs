using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace late2
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            string result = "";
            for (int i = 0; i < B.Authors.Length; i++)
            {
                result += B.Authors[i];
                if (i < B.Authors.Length - 1)
                {
                    result += ", ";
                }
            }
            return result;
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString() + " EG";
        }
    }
}
