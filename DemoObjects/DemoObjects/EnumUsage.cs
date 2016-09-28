using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    class Enums
    {
        [Flags]
      public enum Colors
        {
            Blue = 1,
            Red = 2, 
            Green = 3,
            Yellow =  4, 
            Black= 5
        };
    }



    class EnumUsage:Enums
    {
        public static void Main(string[] args)
        {
            Colors color = (Colors)2;
            switch (color)
            {
                case Colors.Red:
                    Console.WriteLine(Colors.Red);
                    break;

                case Colors.Blue:
                    Console.WriteLine(Colors.Blue);
                    break;

                case Colors.Black:
                    Console.WriteLine(Colors.Black);
                    break;

            }
            Console.ReadLine();
        }
    }
}
