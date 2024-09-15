using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.Utilities
{
    internal class DatatypeConverter
    {
       public static int IntegerParse(string value)
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

        public static char CharParse(string value)
        {
            if (char.TryParse(value, out char character))
            {
                return character;
            }
            else
            {
                Console.WriteLine($"{value} is not a character");

                return ' ' ;
            }
        }
    }
}
