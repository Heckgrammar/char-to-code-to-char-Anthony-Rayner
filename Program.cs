using Microsoft.SqlServer.Server;
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
            //Challenge 2: ouput the Character for any input character codes
            // Choose between conversions
            Console.WriteLine("[A] Convert codes to characters.\n[B] Convert characters to codes.");
            string input = Console.ReadLine().ToLower();


            if (input == "a")
            {
                // Get input
                Console.Write("Please enter code(s), seperated with spaces: ");
                input = Console.ReadLine();

                // Convert
                int i = 0;
                char c = input[0];
                string codeString;
                int codeInt = 0;
                string translation = "";

                while (true)
                {
                    codeString = "";
                    while (c != ' ')
                    {
                        codeString += c;

                        i++;
                        if (i >= input.Length)
                        {
                            break;
                        }
                        c = input[i];
                    }
                    codeInt = Convert.ToInt32(codeString);
                    translation += (char)codeInt;
                    if (i >= input.Length)
                    {
                        break;
                    }
                    i++;
                    c = input[i];
                }

                Console.WriteLine(translation);
            }
            else
            {
                // Get input
                Console.Write("Please enter character(s): ");
                input = Console.ReadLine();

                // Convert
                foreach (char c in input)
                {
                    Console.WriteLine(CharToCode(c));
                }
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

