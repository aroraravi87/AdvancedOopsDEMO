using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    interface IPosition
    {
        string Title { get; }
    }

    class Programmer : IPosition
    {
        string IPosition.Title
        {
            get
            {
                return "Programmer";
            }
            
        }
    }

    class TechnicalManager : IPosition
    {
        string IPosition.Title
        {
            get { return "TechnicalManager"; }
        }
    }

    class FinanceManager : IPosition
    {
        string IPosition.Title
        {
            get { return "FinanceManager"; }
        }
    }

    class FactoryPattern
    {

        public static IPosition Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new TechnicalManager();
                case 1:
                    return new FinanceManager();
                case 2:
                    return new Programmer();
                default:
                    return null;
            }
            
        }

        public static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Position ID is {0} and Name is {1}", i, FactoryPattern.Get(i).Title);
                
            }
            Console.Read();
        }
    }
}
