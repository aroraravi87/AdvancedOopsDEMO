using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoObjects
{
    class Logics
    {
        public static void Main(string[] args)
        {
            string str = "HELLOMADAMHOWAREYOUEMADAME";
            int leftindex = 0;
            int rightindex = 0;
            string current = "";
            string longest = "";
            for (int currentindex = 1; currentindex < str.Length - 1; currentindex++)
            {
                leftindex = currentindex - 1;
                rightindex = currentindex + 1;

                while (leftindex >= 0 && rightindex < str.Length)
                {
                    if (str[leftindex] != str[rightindex])
                    {
                        break;
                    }
                    current = str.Substring(leftindex, rightindex - leftindex + 1);
                    longest = current.Length > longest.Length ? current : longest;
                    leftindex--;
                    rightindex++;
                }

            }
            Console.WriteLine("Current string is {0} longest is {1}", current, longest);
            Console.Read();
        }
    }
}
