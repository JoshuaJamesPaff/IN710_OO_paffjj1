using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDashBoard
{
    public class SubjectSpeedMonitor : ISubject
    {
        private List<IObserver> observerList;

        public SubjectSpeedMonitor()
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
            
        public void NotifyObservers(int currentSpeed)
        {
            foreach (IObserver obv in observerList)
            {
                //updates observers based on speed property and displays their output value
                obv.Update(currentSpeed);
            }
        }
    }
}
