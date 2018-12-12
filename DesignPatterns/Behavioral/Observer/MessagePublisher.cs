using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class MessagePublisher : IPublisher
    {
        List<ISubscriber> subscribers = null;

        public MessagePublisher()
        {
            subscribers = new List<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifySubscribers(string message)
        {
            foreach (ISubscriber sub in subscribers)
            {
                sub.Update(message);
            }
        }
    }
}
