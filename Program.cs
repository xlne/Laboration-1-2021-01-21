using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Laboration_1__2021_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! \nWe are going to print out the same string of code, and then highlight\na simple pattern in it, " +
                "substrings starting and ending with the same character!");

            Console.WriteLine();

            Console.WriteLine("\t[Press any key to see the strings!]");
            Console.ReadKey();

            //Initiate a string with values
            string rndStr = "1254548067892km12346579813";                           
            Console.WriteLine();

            //Using a list to save the substrings
            List<string> SubstrList = new List<string>();

            //Nested loops to go through the string and comparing each digit if matching
            for (int i = 0; i < rndStr.Length - 1; i++)                             
            {
                if (Char.IsDigit(rndStr[i]))
                {
                    for (int j = i + 1; j < rndStr.Length; j++)
                    {
                        if (rndStr[i] == rndStr[j])
                        {
                            string subString = rndStr.Substring(i, j - i + 1);
                            SubstrList.Add(subString);                              
                            PrintString(rndStr, i, j);                  //When finding substrings, calling the method to print the different parts in different colors
                            break;
                        }
                        else if (!Char.IsDigit(rndStr[j]))
                        {
                            break;
                        }
                    }
                }
                continue;
            }

            //Count the total of the substrings
            uint total = 0;
            total = (uint)SubstrList.Sum(i => Convert.ToInt64(i));                  

            Console.WriteLine();
            Console.WriteLine("\t[Press any key to see the summary of the substrings!]");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine($"The total sum of the substrings are: {total}");
            Console.ReadKey();
        }

        //The method that prints the substring and the seperate parts in different colors
        static void PrintString(string str, int start, int end)                     
        {
            string str1 = str.Substring(0, start);
            string str2 = str.Substring(start, end - start + 1);
            string str3 = str.Substring(end + 1);

            Console.Write(str1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(str2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(str3);
        }
    }
}

