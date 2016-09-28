using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    interface ICustomer
    {
        void Hello();
    }

    interface IDiscount 
    {
        void Add();
    }


    public class customer : ICustomer
    {
        public void Add()
        {
        }

        public void Hello()
        {

        }

    }


    class Solid
    {
        public static void Main(string[] args)
        {

        }
    }
}
