using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    interface IUser
    {
        string Name { get; set; }
        IChatRoom ChatRoom { get; set; }

        void Send(IUser user,string message);
        void Receive(IUser user, string message);
   
    }
}
