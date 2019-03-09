using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class LoadBalancer
    {
        private static LoadBalancer instance = null;
        private List<Server> servers=null;
        private bool randomAccess=true;

        private LoadBalancer()
        {
            int numOfServers=20;
            servers = new List<Server>(numOfServers);

            for (int i = 0; i < numOfServers; i++) {
                servers.Add(new Server("Server" + i, i.ToString()));
            }
        }

        public static LoadBalancer GetInstance()
        {
            if (instance==null) {
                instance = new LoadBalancer();
            }
            return instance;
        }

        public void ProcessRequest(int time)
        {
                Server server;
                if (randomAccess) {
                    Random rnd = new Random(Guid.NewGuid().GetHashCode());
                    int randomPosition = rnd.Next(0, servers.Count);
                    server = servers[randomPosition];                    
                } else {
                    server = GetMinRequestServer();
                }
                    server.ProcessRequest(time);           
        }

        public void ShowStats()
        {
            foreach(Server server in servers) {
                Console.WriteLine(server.ServerToString());
            }
        }
       
        private Server GetMinRequestServer()
        {
            Server minServer=null;
            int minRequests=int.MaxValue;
            foreach(Server server in servers){
                if (minRequests > server.NumOfRequests) {
                    minRequests = server.NumOfRequests;
                    minServer = server;
                }
            }
            return minServer;
        }


    }
}
