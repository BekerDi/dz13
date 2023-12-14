using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz13
{
    class MyThread
    {
        public string ThreadName { get; set; }

        public MyThread(string threadName)
        {
            ThreadName = threadName;
        }

        public void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{ThreadName}: {i}");
                Thread.Sleep(100);
            }
        }
    }
}
