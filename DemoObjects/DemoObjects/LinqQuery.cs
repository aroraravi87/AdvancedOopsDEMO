using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    class LinqQuery
    {
        public static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numbers2={2,4,6,8};
           //select index
            // var abc11 = numbers1.Select((x, index) => x + " => " + index);
            //select many 
            //var abc11 = numbers2
            //    .SelectMany(number => 
            //        numbers1.Select(x=>x),(number,x)=>
            //            new { numbers2 = number, numbers = x, customstring = number + " =>" + x });
            //select takewhile
            var abc11 = numbers1.SkipWhile(x=>x<=5).Select((x, index) => x + " => " + index);
            //

            abc11.ToList().ForEach(x => Console.WriteLine(x));
           

           
            Console.ReadKey();

        }
    }
}
