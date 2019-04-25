using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ChatRoom : IChatRoom
    {
        private List<IUser> _users;

        public ChatRoom()
        {
            _users = new List<IUser>();
        }

        public bool Register(IUser user)
        {
            if (_users.Contains(user)) {
                return false;
            }
            _users.Add(user);
            _users.Last().ChatRoom = this;
            return true;
        }

        public void Send(string message, IUser sender, IUser receiver)
        {
            sender.Send(receiver, message);
            receiver.Receive(sender, message);
        }

        public void SendAll(string message)
        {
            foreach(var user in _users) {
                user.Receive(null, message);
            }
        }

        public bool UnRegister(IUser user)
        {
            if (_users.Contains(user)) {
                _users.Remove(user);
                return true;
            }
            return false;
        }
    }
}
