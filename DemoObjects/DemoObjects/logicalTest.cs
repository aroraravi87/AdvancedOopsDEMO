using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    class logicalTest
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int ptr = 0;
            int[] array1 = {2, 4, 8, 9,5};
            int[] array2 = { 3, 5, 8, 9,7,4,11,32 };
            List<int> arr = new List<int>();
            while (ptr < array2.Length)
            {

                   if (array1[i] != array2[ptr])
                    {

                        i++;
                       
                    }
                   else
                   {
                       ptr++;
                       i = 0;
                   }
                if (i == array1.Length)
                {
                    arr.Add(array2[ptr]);
                    ptr++;
                    i = 0;
                }

            }

            for (int k = 0; k < arr.Count; k++)
            {
                Console.WriteLine(arr[k]);
                
            }
            Console.ReadLine();
        }

    }
}
