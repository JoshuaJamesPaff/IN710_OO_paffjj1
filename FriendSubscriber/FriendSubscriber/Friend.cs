using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendSubscriber
{
    public class Friend : IObserver
    {
        //manages pushing your statuses
        private Subject pushService;

        //your name and newsfeed
        private ListBox newsFeed;
        private string name;

        //sets name
        public Friend(string name, ListBox newsFeed)
        {
            this.name = name;
            this.newsFeed = newsFeed;
            pushService = new Subject();
        }
        //posts status to friends
        public void PostStatus(string status)
        {
            pushService.NotifyObservers(status);
        }
        // follows new friend
        public void AddFriend(Friend friend)
        {
            friend.Subject.AddObserver(this);
        }
        //lets someone follow you
        public void AcceptFriend(Friend friend)
        {
            pushService.AddObserver(friend);
        }
        //posts update to your newsfeed
        public void getUpdate(string status)
        {
            newsFeed.Items.Add(status);
        }
        //clears your news feed
        public void clearDisplay()
        {
            newsFeed.Items.Clear();
        }

        public Subject Subject
        {
            get { return pushService; }
            set { pushService = value; }
        }
    }
}
