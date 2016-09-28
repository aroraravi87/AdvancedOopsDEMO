using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class StrategyMain
    {
        public static void Main(string[] args)
        {
            StrategyContext objContext = new StrategyContext(new clsAdd());
            
            Console.WriteLine("Sum is {0}",objContext.executeStrategy(10, 10));
            Console.WriteLine("Mul is {0}", objContext.executeStrategy(10, 10));
            Console.WriteLine("Sub is {0}", objContext.executeStrategy(10, 10));
            Console.ReadKey();
        }
    }
}
