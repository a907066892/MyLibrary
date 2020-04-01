using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static AutoResetEvent e = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Thread start1 = new Thread(fun1);
            start1.Start();
            Thread start2 = new Thread(fun2);
            start2.Start();
        }

        public static void fun1()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            e.WaitOne();
            for (int i = 0; i < 50; i++)
            {

            }
            Console.WriteLine("完成");
        }

        public static void fun2()
        {
            //排队
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 50; i++)
            {

            }
            Console.WriteLine("排队完成");
            e.Set();
            e.WaitOne();
         
        }
    }
}
