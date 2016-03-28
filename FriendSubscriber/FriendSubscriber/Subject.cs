using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendSubscriber
{
    public class Subject : ISubject
    {
        //list of observers
        private List<IObserver> observerList;

        public Subject()
        {
            observerList = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }
            
        public void NotifyObservers(string status)
        {
            foreach (IObserver obv in observerList)
            {
                //updates observers based on parameters
                obv.getUpdate(status);
            }
        }

    }
}
