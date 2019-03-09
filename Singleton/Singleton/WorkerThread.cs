using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Singleton
{
    class WorkerThread
    {
        public static void PostRequest()
        {
            LoadBalancer loadBalancer = LoadBalancer.GetInstance();
            Random random = new Random(Guid.NewGuid().GetHashCode());

            int timeToProcess = random.Next(500, 1000);
            loadBalancer.ProcessRequest(timeToProcess);
           
        }
    }
}
