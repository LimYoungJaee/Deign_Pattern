using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class AnnualSubscriber:IObserver
    {
        private string newsString;
        private IPublisher publisher;

        public AnnualSubscriber(IPublisher publisher)
        {
            this.publisher = publisher;
            publisher.Add(this); // 여기서 추가
        }
        public void update(string title, string news)
        {
            this.newsString = title + "\n------------ \n" + news;
            display();
        }
        private void display()
        {
            Console.WriteLine("\n\n오늘의 뉴스\n===============\n\n" + newsString);
        }
    }
}
