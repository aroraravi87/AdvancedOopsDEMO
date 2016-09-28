using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.Interface;

namespace StrategyDesignPattern
{
    public class StrategyContext
    {
        private IStrategy _strategy;

        public StrategyContext(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public int executeStrategy(int num1, int num2)
        {
            return _strategy.doOperation(num1, num2);
        }
    }
}
