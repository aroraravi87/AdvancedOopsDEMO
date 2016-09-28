using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoObjects
{
    class Tasks
    {
        const int SLEEP_TIME_T1 = 3000;
        const int SLEEP_TIME_T2 = 2000;
            
        public static void Main(string[] args)
        {
            

            Console.WriteLine("Task Started");
            Console.WriteLine("=================================================");

            Task t1 = Task.Factory.StartNew(() => TaskStart(1)).ContinueWith((prevTask) => TaskEnd(1));
            Task t2 = Task.Factory.StartNew(() => { TaskStart(2); }).ContinueWith((prevTask) => TaskEnd(2));
            Task t3 = Task.Factory.StartNew(delegate { TaskStart(3); }).ContinueWith((prevTask) => TaskEnd(3));
            Task t4 = Task.Factory.StartNew(delegate { TaskStart(4); }).ContinueWith((prevTask) => TaskEnd(4)); 

            
            Task.WaitAll(new Task[] { t1, t2,t3,t4 });
            Console.WriteLine("=================================================");
           
            Console.WriteLine("Task Completed");
            Console.Read();
        }

        private static void TaskStart(int id)
        {
            Console.WriteLine("Task {1} starting work at {0} ", DateTime.Now.ToString(), id);
            Thread.Sleep(SLEEP_TIME_T1);
            Console.WriteLine("Task {1} complete work at {0}", DateTime.Now.ToString(), id);
        }

        private static void TaskEnd(int id)
        {
            Console.WriteLine("Task {1} starting more work at {0} ", DateTime.Now.ToString(), id);
            Thread.Sleep(SLEEP_TIME_T2);
            Console.WriteLine("Task {1} complete more work at {0}", DateTime.Now.ToString(), id);
        }
    }
}
