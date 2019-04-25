using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class User : IUser
    {
        public string Name { get ; set ; }
        public IChatRoom ChatRoom { get ; set ; }

        public User(string name)
        {
            Name = name;
        }

        public void Receive(IUser user, string message)
        {
            if (user != null) {
                Console.WriteLine(Name+" received from " + user.Name + " : " + message);
            } else {
                Console.WriteLine(Name + " received from chatroom : " + message);
            }
        }

        public void Send(IUser user, string message)
        {
            Console.WriteLine(Name+" sent to " + user.Name + " : " + message);            
        }
    }
}
