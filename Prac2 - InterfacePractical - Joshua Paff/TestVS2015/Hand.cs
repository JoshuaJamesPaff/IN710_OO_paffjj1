using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVS2015
{
    public class Hand : IComparable<Hand>
    {
        public List<Card> CardsInHand { get; set; }
        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        //implementation of hand sort method based on HCP
        public int CompareTo(Hand that)
        {
            if (this.TotalHCP > that.TotalHCP) return -1;
            if (this.TotalHCP == that.TotalHCP) return 0;
            return 1;
        }

        //allows hand sort to be called
        public void SortHand()
        {
            CardsInHand.Sort();
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }

        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;

            return 0;
        }
    }
}