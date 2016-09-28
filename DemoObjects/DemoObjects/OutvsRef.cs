using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    class OutvsRef
    {
        public static void Main(string[] args)
        {
            //call the function using out function 
            int add;
            int sub;
            int div;
            int mul;

            mathOut(10, 20, out add, out sub, out div, out mul);

            //call the function using ref function
 
            int addRef = 0;
            int subRef = 0;
            
            int divRef = 0;
            int mulRef = 0;

            mathRef(10, 20, ref addRef, ref subRef, ref divRef, ref mulRef);
        }

        private static void mathOut(int p1, int p2, out int add, out int sub, out int div, out int mul)
        {
           
            add = p1 + p2;
            sub = p1 - p2;
            div = p1/p2;
            mul = p1*p2;

        }

        private static void mathRef(int p1, int p2, ref int addRef, ref int subRef, ref int divRef, ref int mulRef)
        {
            p1 = 30;
            p2 = 40;
            addRef = p1 + p2;
            subRef = p1 - p2;
            divRef = p1 / p2;
            //mulRef = p1 * p2;

        }
    }
}
