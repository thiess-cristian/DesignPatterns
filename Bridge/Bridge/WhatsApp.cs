using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class WhatsApp : IMessageService
    {
        public void SendFile(string file)
        {
            Console.Write("WhatsApp: ");
            Console.WriteLine(file);
        }

        public void SendMessage(string message)
        {
            Console.Write("WhatsApp: ");
            Console.WriteLine(message);
        }

        public void VideoCall()
        {
            Console.Write("WhatsApp: ");
            Console.WriteLine("video call");
        }

        public void VoiceCall()
        {
            Console.Write("WhatsApp: ");
            Console.WriteLine("voice call");
        }
    }
}
