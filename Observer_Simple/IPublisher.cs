using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IPublisher
    {
        void Add(IObserver observer);
        void Delete(IObserver observer);
        void NotifyObserver();
    }
}
