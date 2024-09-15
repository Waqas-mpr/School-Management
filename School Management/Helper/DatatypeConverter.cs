using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.Helper
{
    internal class DatatypeConverter
    {
       public static int integerParse(string value)
        {
            if (int.TryParse(value, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine($"{value} is not a number");

                return 0;
            }
        }
    }
}
