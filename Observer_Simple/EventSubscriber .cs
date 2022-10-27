using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class EventSubscriber : IObserver
    {
        private string newsString;
        private IPublisher publisher;
        public EventSubscriber(IPublisher publisher)
        {
            this.publisher = publisher;
            publisher.Add(this);
        }
        public void update(string title, string news)
        {
            newsString = title + "\n-----------------\n" + news;
            display();
        }
        public void display()
        {
            Console.WriteLine("\n\n=====이벤트 유저======");
            Console.WriteLine("\n\n" + newsString);
        }
    }
}
