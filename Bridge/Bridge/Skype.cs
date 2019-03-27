using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Skype : IMessageService
    {
        public void SendFile(string file)
        {
            Console.Write("skype: ");
            Console.WriteLine(file);
        }

        public void SendMessage(string message)
        {
            Console.Write("skype: ");
            Console.WriteLine(message);
        }

        public void VideoCall()
        {
            Console.Write("skype: ");
            Console.WriteLine("video call");
        }

        public void VoiceCall()
        {
            Console.Write("skype: ");
            Console.WriteLine("voice call");
        }
    }
}
