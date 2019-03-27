using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            WhatsApp whatsApp = new WhatsApp();

            InstantMessenger messenger = new InstantMessenger(whatsApp);

            messenger.SendFile("file 1.txt");
           
            messenger.Service = new FacebookMessanger();

            messenger.VideoCall();

        }
    }
}
