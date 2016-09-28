using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoObjects
{
    internal interface IBase
    {
       string  Name { get; set; }
       void CallingMethod();
    }

    static class staticS1 
    {
        public static int values { get; set; }
        static staticS1()
        {
            values = 30;
        }

    }


    class Xcls : IBase
    {
        private static Xcls _xcls_instance=null;
        private static readonly object padlock=new object();
        public static Xcls Xcls1
        {
            get
            {
                lock (padlock)
                {
                    if (_xcls_instance == null)
                    {
                        _xcls_instance = new Xcls();
                    }
                    return _xcls_instance;
                }
            }
            set { _xcls_instance = value; }
        }
        
        private Xcls()
        {
        }


        public void MethodPvt()
        {
            Console.WriteLine("This is private method of singleton class is {0}");
        }


        public void CallingMethod()
        {
            Console.WriteLine("This is calling method of singleton class thorugh interface");
        }

        public string Name
        {
            get { return "Hello"; }
            set { Name = value;}
        }
    }


    class SingleVsSingleton
    {
        //  StaticClass s1 = new StaticClass();
        // StaticClass s2 = new StaticClass();


        public static void Main(string[] args)
        {
            Xcls.Xcls1.MethodPvt();
            Xcls.Xcls1.CallingMethod();
            Console.WriteLine("value is {0}",staticS1.values);
            Console.Read();
        }
    }
}
