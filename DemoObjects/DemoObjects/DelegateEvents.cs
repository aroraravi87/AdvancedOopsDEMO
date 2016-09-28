using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoObjects
{
    class clsHugeTask
    {
        public string DoHugetask()
        {
            Thread.Sleep(5000);
            return "Task Completed";
        }
    }

    class DelegateEvents
    {
        public delegate string delegateMethod();


        public static void Main(string[] args)
        {
            clsHugeTask objclsHugeTask = new clsHugeTask();
            delegateMethod objdelegateMethod = new delegateMethod(objclsHugeTask.DoHugetask);
            objdelegateMethod.BeginInvoke(new AsyncCallback(callbackmethod), objdelegateMethod);
            Console.WriteLine("Waiting in main method");
            Console.ReadKey();
        }

        public static void callbackmethod(IAsyncResult result)
        {
            delegateMethod objdelegate = result.AsyncState as delegateMethod;
            string strvalue = objdelegate.EndInvoke(result);
            Console.WriteLine(strvalue);
        }
    }


}
