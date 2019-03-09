using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++) {
                ThreadStart threadStart = new ThreadStart(WorkerThread.PostRequest);
                Thread thread = new Thread(threadStart);
                thread.Start();
               // Thread.Sleep(500);
            }


            LoadBalancer loadBalancer = LoadBalancer.GetInstance();

            loadBalancer.ShowStats();

        }
    }
}
