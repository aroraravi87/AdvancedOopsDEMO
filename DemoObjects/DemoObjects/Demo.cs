using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    public class A
    {
        private static A _ClsObj;

        public static A ClsObj
        {
            get
            {
                if (_ClsObj == null)
                {
                    _ClsObj = new A();
                }
                return _ClsObj;
            }

        }


        private A()
        {

            Console.WriteLine("private Constructor");

        }

        public void Hello(int a)
        {
            Console.WriteLine("Hello called " + a);

        }

        public void Hello(ref int a)
        {
            a = 10;
            //b = 20;
            Console.WriteLine("Hello called " + (a));
            
        }

    }


    public class Demo
    {
        public static void Main(string[] args)
        {
            int refObj = 10;
            int a, b;
            //A objA = A.ClsObj;
            //objA.Hello(ref refObj);
            //objA.Hello(a=100);

            object obj = "string";
            Console.WriteLine(obj.GetType());
           
            Console.WriteLine(obj+" abc ");

            Console.ReadKey();
        }
    }
}
