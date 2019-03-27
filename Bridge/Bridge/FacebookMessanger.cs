using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class FacebookMessanger : IMessageService
    {
        public void SendFile(string file)
        {
            Console.Write("FacebookMessanger: ");
            Console.WriteLine(file);
        }

        public void SendMessage(string message)
        {
            Console.Write("FacebookMessanger: ");
            Console.WriteLine(message);
        }

        public void VideoCall()
        {
            Console.Write("FacebookMessanger: ");
            Console.WriteLine("video call");
        }

        public void VoiceCall()
        {
            Console.Write("FacebookMessanger: ");
            Console.WriteLine("voice call");
        }
    }
}
