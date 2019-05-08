using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class OnlineStore : IOnlineStore
    {
        private List<Product> _products;
        private List<ISubscriber> _subscribers;

        public OnlineStore()
        {
            _products = new List<Product>();
            _subscribers = new List<ISubscriber>();
        }


        public void AddProducts(List<Product> products)
        {
            List<Product> newProducts = new List<Product>();
            foreach(var product in products) {
                if (!_products.Contains(product)) {
                    newProducts.Add(product);
                    _products.Add(product);
                } else {
                    var p = _products.Find(x => x == product);
                    p.Count++;
                }
            }

            if (newProducts.Count > 0) {
                Notify(newProducts);
            }
        }

        public void Invetory()
        {
            foreach(var product in _products) {
                Console.WriteLine(product.ToString());
            }
        }

        public void Notify(List<Product> products)
        {
            foreach(var subscriber in _subscribers) {
                subscriber.Update(products);
            }
        }

        public bool Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
            return true;
        }

        public bool Unsubscribe(ISubscriber subscriber)
        {
            return _subscribers.Remove(subscriber);
        }
    }
}
