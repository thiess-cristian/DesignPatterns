using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class InstantMessenger:IMessageService
    {
        public IMessageService Service { get; set; }

        public InstantMessenger(IMessageService service)
        {
            Service = service;
        }

        public void SendFile(string file)
        {
            Service.SendFile(file);
        }

        public void SendMessage(string message)
        {
            Service.SendMessage(message);
        }

        public void VoiceCall()
        {
            Service.VoiceCall();
        }

        public void VideoCall()
        {
            Service.VideoCall();
        }
    }
}
