using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendSubscriber
{
    public interface IObserver
    {
        void getUpdate(string status);
        void clearDisplay();
    }
}
