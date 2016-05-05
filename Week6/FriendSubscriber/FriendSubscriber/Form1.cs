using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendSubscriber
{
    public partial class Form1 : Form
    {
        //creates 3 friends
        private Friend myProfile;
        private Friend friend1;
        private Friend friend2;

        public Form1()
        {
            InitializeComponent();
            myProfile = new Friend("Josh", listBoxMyFeed);
            friend1 = new Friend("John", listBoxFriend1Display);
            friend2 = new Friend("Jane", listBoxFriend2Display);
        }

        private void buttonUpdateMe_Click(object sender, EventArgs e)
        {
            string status = textBoxMyInput.Text;
            myProfile.PostStatus(status);

        }
        //adds friend 1 vice versa checking that he is not already added
        private void buttonAddFriend1_Click(object sender, EventArgs e)
        {

            myProfile.AddFriend(friend1);
            friend1.AcceptFriend(myProfile);

        }
        //adds friend 2 vice versa checking that he is not already added
        private void buttonAddFriend2_Click(object sender, EventArgs e)
        {

            myProfile.AddFriend(friend2);
            friend1.AcceptFriend(myProfile);
            
        }
        //friend 1 updates status
        private void buttonFriend1Update_Click(object sender, EventArgs e)
        {
            string status = textBoxFriend1Input.Text;
            friend1.PostStatus(status);
        }
        //friend2 updates status
        private void buttonFriend2Update_Click(object sender, EventArgs e)
        {
            string status = textBoxFriend2Input.Text;
            friend2.PostStatus(status);
        }
        //clears news feed
        private void buttonClearFeed_Click(object sender, EventArgs e)
        {
            myProfile.clearDisplay();
        }
    }
}
