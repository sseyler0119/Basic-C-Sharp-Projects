using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; } // a dealer HAS-A Deck
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); // takes first card in the list and adds it to Hand
            string card = string.Format(Deck.Cards.First().ToString()); // write the card that was just added to the Hand to 
            Console.WriteLine(card);
            StreamWriter file = null;
            try
            {
                using (file = new StreamWriter(@"E:\Logs\log.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(card);
                }
            }
            finally
            {
                if (file != null)
                    file.Dispose();
            }
            
            Deck.Cards.RemoveAt(0); // remove card from top of deck (first in list)
        }
    }
}
