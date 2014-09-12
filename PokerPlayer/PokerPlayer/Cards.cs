using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPlayer
{
    public enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    public enum Suit
    {
        Spades = 1,
        Clubs,
        Hearts,
        Diamonds
    }

    class Cards
    {
        //STEP 1. Declare properties
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        //STEP 2. Constructors
        public Cards(Rank rank, Suit suit)
        {
            //initialize the properties
            this.Rank = rank;
            this.Suit = suit;
        }

        //STEP 3. Methods and Functions
        public void DealFromDeck()
        {
            Console.WriteLine(this.Rank + " of " + this.Suit + "\n");
        }
    }

}
