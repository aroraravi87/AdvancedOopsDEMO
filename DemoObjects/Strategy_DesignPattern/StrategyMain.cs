using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DesignPattern
{
    class StrategyMain
    {
        public static void Main(string[] args)
        {
            StrategyContext objContext = new StrategyContext(new clsAdd());
            
            Console.WriteLine("Sum is {0}",objContext.executeStrategy(10, 10));
            
            objContext = new StrategyContext(new clsMul());
            Console.WriteLine("Mul is {0}", objContext.executeStrategy(10, 10));
            
            objContext = new StrategyContext(new clsSub());
            Console.WriteLine("Sub is {0}", objContext.executeStrategy(10, 10));
            Console.ReadKey();
        }
    }
}
