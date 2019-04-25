using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom chatRoom = new ChatRoom();

            User user1 = new User("user1");
            User user2 = new User("user2");
            User user3 = new User("user3");
            chatRoom.Register(user1);
            chatRoom.Register(user2);
            chatRoom.Register(user3);

            chatRoom.Send("hello", user1, user2);
            user1.Send(user2, "hello 2");
            Console.WriteLine(" ");
            chatRoom.SendAll("hello all");

            
        }
    }
}
