using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Singleton
{
    class Server
    {

        public Server(String name,String ipAddress)
        {
            Name = name;
            IpAddress = IpAddress;
            MaxTime = 500;
            MinTime = 1000;
            NumOfRequests = 0;
        }

        public String Name { get; set; }
        public String IpAddress { get; set; }
        public int NumOfRequests { get; set; }
        public int MaxTime { get; set; }
        public int MinTime { get; set; }
        public int TotalTime { get; set; }

        public void ProcessRequest(int time)
        {
            NumOfRequests++;
            TotalTime += time;

            if (time < MinTime) {
                MinTime = time;
            }

            if (time > MaxTime) {
                MaxTime = time;
            }

            Thread.Sleep(time);
        }

        public String ServerToString()
        {
            return "Name: " + Name + " min: " + MinTime+" max: "+ MaxTime+ " total: "+TotalTime+" requests: "+NumOfRequests;
        }

    }
}
