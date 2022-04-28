﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck() // constructor
        {
            Cards = new List<Card>();
            for(int i = 0; i < 13;i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        // function to randomly shuffle cards in deck
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>(); // create temporary list to hold cards
                Random random = new Random(); // create random object

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); // get random index from deck
                    TempList.Add(Cards[randomIndex]); // add to temp deck
                    Cards.RemoveAt(randomIndex); // delete from list of cards
                }
                this.Cards = TempList; // copy temporary deck to deck of cards
            }
        }
    }
}
