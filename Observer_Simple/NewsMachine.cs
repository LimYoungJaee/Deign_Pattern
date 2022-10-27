using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class NewsMachine:IPublisher
    {
        private List<IObserver> observers;
        private string title;
        private string news;

        public NewsMachine()
        {
            observers = new List<IObserver>();
        }
        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Delete(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach(IObserver observer in observers)
            {
                observer.update(title, news);
            }
        }
        public void setNewsInfo(string title, string news)
        {
            this.title = title;
            this.news = news;
            NotifyObserver();
        }
        public String getTitle()
        {
            return title;
        }
        public string getNews()
        {
            return news;
        }
    }
}
