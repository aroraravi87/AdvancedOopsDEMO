using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoObjects
{
    class MultiThreading
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";


            //Task<string>[] taskArray ={Task<string>.Factory.StartNew(()=>DoOperation1("Thread 1 Called")),
            //                     Task<string>.Factory.StartNew(()=>DoOperation2("Thread 2 Called")),
            //                     Task<string>.Factory.StartNew(()=>DoOperation3("Thread 3 Called")),
            //                     Task<string>.Factory.StartNew(()=>DoOperation4("Thread 4 Called")),
            //                     Task<string>.Factory.StartNew(()=>DoOperation5("Thread 5 Called"))
            //                    };
            //Task.WaitAll(taskArray);

        //    Parallel.Invoke(() => DoOperation1("Thread 1 Called"),
        //        () => DoOperation2("Thread 2 Called"),
        //        () => DoOperation3("Thread 3 Called"),
        //        () => DoOperation4("Thread 4 Called"),
        //        () => DoOperation5("Thread 5 Called")
        //);

            Parallel.For(0,1,m => DoOperation1("Thread 1 Called"));
            Parallel.For(0,1,m  => DoOperation2("Thread 2 Called"));
             Parallel.For(0,1,m  => DoOperation3("Thread 3 Called"));
                //() => DoOperation4("Thread 4 Called"),
                //() => DoOperation5("Thread 5 Called")
        //);

        Console.WriteLine("Current Running Thread is {0}", Thread.CurrentThread.Name);
            Console.Read();
        }

        public static string DoOperation1(string param)
        {
            Console.WriteLine(param);
            //Thread.Sleep(3000);
            return param;
        }

        public static string DoOperation2(string param)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            ParallelProcessAsync(num.ToList());
            Console.WriteLine(param);

            return param;
        }

        public static string DoOperation3(string param)
        {
            Console.WriteLine(param);
            //Thread.Sleep(1000);

            return param;
        }

        public static string DoOperation4(string param)
        {
            Console.WriteLine(param);
            //Thread.Sleep(5000);

            return param;
        }

        public static string DoOperation5(string param)
        {
            Console.WriteLine(param);
            //Thread.Sleep(4000);

            return param;
        }

        public static async void ParallelProcessAsync(List<int> count)
        {
            await Task.Run(() => count.ForEach(m => Console.WriteLine(m)));
        }

    }
}

