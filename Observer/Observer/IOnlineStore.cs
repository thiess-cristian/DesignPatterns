using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IOnlineStore
    {
        bool Subscribe(ISubscriber subscriber);
        bool Unsubscribe(ISubscriber subscriber);
        void Notify(List<Product> products);
        void AddProducts(List<Product> products);
        void Invetory();
        

    }
}
