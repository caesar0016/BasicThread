using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicThread
{
    internal class MyThreadClass
    {
        public static void thread1()
        {

            for (int i = 0; i < 6; i++)
            {

                Thread thread1;
                thread1 = Thread.CurrentThread;
                Console.WriteLine("Name of the Thread: " + thread1.Name + " = " + i);
                Thread.Sleep(1500);


            }


        }
    }
}
