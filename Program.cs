using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CHAR_TO_CODE_TO_CHAR_FRAMEWORK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge 1: output the ASCII codes for any string input

            //Challenge 2: ouput the Character for any input character codes

            Console.Write("Please enter character(s): ");
            string input = Console.ReadLine();
            foreach (char c in input)
            {
                Console.WriteLine(CharToCode(c));
            }
        }

        static Int32 CharToCode(char codeChar)
        {
            return Convert.ToInt32(codeChar);
        }

        static char CodeToChar(int charCode)
        {

            return Convert.ToChar(charCode);
        }

    }
}

