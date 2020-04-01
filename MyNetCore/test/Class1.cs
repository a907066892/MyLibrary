using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    public class Class1
    {
        AutoResetEvent e = new AutoResetEvent(true);
        public void ss() 
        {
          
            e.WaitOne();

            Thread start1 = new Thread(fun1);
            start1.Start();
            Thread start2= new Thread(fun2);
            start1.Start();

        }

        public void fun1() 
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            e.WaitOne();
            for (int i = 0; i < 50; i++)
            {

            }
            Console.WriteLine("完成");
        }

        public void fun2()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 50; i++)
            {

            }
            Console.WriteLine("完成2");
        }
    }
}
