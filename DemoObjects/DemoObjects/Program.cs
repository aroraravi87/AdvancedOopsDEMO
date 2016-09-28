using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    interface ITest
    {
        void ITestMethod();
    }

    class absClassA
    {
        public virtual  void IAbstractMethod()
        {
            Console.WriteLine("absClassA IAbstractMethod Called");
            Console.WriteLine("============================");
        }
    }

    abstract class baseclass :absClassA, ITest
    {

        public virtual string Name { get; set; }
        public static int Age { get; set; }
        public abstract string Address { get; set; }

        static baseclass()
        {
            Console.WriteLine("Baseclass static Constructur Called");
            Console.WriteLine("============================");

        }

        public baseclass()
        {
            Console.WriteLine("Baseclass Constructur Called");
            Console.WriteLine("============================");
        }


        public static void Hello()
        {
            Console.WriteLine("Class A called");
            Console.WriteLine("============================");
        }

        public virtual void Display()
        {
            Console.WriteLine("Class A Virtual called");
            Console.WriteLine("============================");
        }

        public void MainMethod()
        {
            Console.WriteLine("Class A Override called");
            Console.WriteLine("============================");
        }

        public override void IAbstractMethod()
        {
            Console.WriteLine("Abstract Method called inside abstract class");
            Console.WriteLine("============================");
        }

        public abstract void Output();


        public void ITestMethod()
        {
            Console.WriteLine("ITestMethod called");
            Console.WriteLine("============================");
        }

    }
    class derivedclass : baseclass
    {
        static derivedclass()
        {

            Console.WriteLine("Derivedclass static Constructur Called");
            Console.WriteLine("============================");

        }
        public derivedclass()
        {
            Console.WriteLine("Derivedclass Constructur Called");
            Console.WriteLine("============================");
            base.Display();
            ITestMethod();

        }

        public void Hello()
        {
            Console.WriteLine("Class B called");
            Console.WriteLine("============================");
        }

        public new virtual void Display()
        {
            Console.WriteLine("Class A virtual-override called");
            Console.WriteLine("============================");

        }

        public string _Address;

        public override string Address
        {
            get { return _Address; }
            set { _Address = value; }

        }

        public void MainMethod()
        {
            Console.WriteLine("Class B Override called");
            Console.WriteLine("============================");

        }

        public override void Output()
        {
            Console.WriteLine("Class A output method-override");
            Console.WriteLine("============================");
        }

    }

    

    class mainclass 
    {

         public static void Main(string[] args)
        {

            derivedclass objA = new derivedclass();
            baseclass.Hello();
            objA.MainMethod();
            objA.IAbstractMethod();
            objA.Hello();
            objA.Display();
        
            Console.ReadKey();

        }

    }
}
