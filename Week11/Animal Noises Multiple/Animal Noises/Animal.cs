using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        SharedToken sharedToken;

        public Animal(String soundFileName, SharedToken sharedToken)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.sharedToken = sharedToken;
        }

        public void speak()
        {
            while (true)
            {
                lock (sharedToken)
                {
                    soundPlayer.Play();
                    Thread.Sleep(500);
                }

            }
        }

    }
}
