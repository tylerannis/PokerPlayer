using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPlayer
{
    public enum PokerHands
    {
        HighCard,
        OnePair,
        TwoPairs,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse,
        FourOfAKind,
        StraightFlush,
        RoyalFlush
    }

    class PokerPlayer
    {
        //STEP 1. Delcare Properties
        public List<Cards> hand { get; set; }

        //STEP 2. Constructors
        public PokerPlayer() 
        { 
        
        }

        //STEP 3. Methods and Functions
        public void DrawHand()
        {
            //delcare new deck
            var Deck = new Deck();
            //shuffle the cards
            Deck.Shuffle();
            //deal cards
            List<Cards> ListofCards = new List<Cards>();
            ListofCards = Deck.Deal(5);
            Console.WriteLine("Dealt Cards: ");
            foreach (var item in ListofCards)
            {
                item.DealFromDeck();
            }

        }

        public bool HasFlush()
        {
            //how to select just one property of an object and get only unique (distinct) values
            //selects only the suits of our cards, takes only the distinct values, and counts them.
            //if there is only 1 suit, it must be a flush
        //.Select > Suit .Distint > .Count(only 1) = true
            return this.hand.Select(x => x.Suit).Distinct().Count() == 1;

        }

        public bool HasOnePair()
        {
            //Grouping cards by rank. The Rank is then stored in the Key

            return this.hand.Select(x => x.Rank).Distinct().Count() == 4;
        }

        public bool ThreeOfAKind()
        {
            //Grouping cards by rank. The Rank is then stored in the Key value
            //Then ordering the cards by descending order by the number of occurences of each rank

            //filter the tmp list to find a group where there are three instances of a single value.
            //The .Any() returns a boolean value on if there is a value in the filtered list
            
            //GroupBy(x=>x.Rank)
            //IEnum (int, Card)
            //Key - 7, 5, 8  Values - 7D, 7C, 7S, 5H, 8D
            // 7 = 7D, 7C, 7S
            // 5 = 5H
            // 8 = 8D

            //Group.Where(x => x.Count == 3)

            //Group.Any(x => x.Count ==3)

            IEnumerable<IGrouping<Rank, Cards>> groupRankList = this.hand.GroupBy(x => x.Rank);
            return groupRankList.Where(x => x.Count() == 3).Any();
        }


            //return this
            public bool RoyalFlush
            {
               this.hand.Where(x=> x.)Select(x => x.Suit).Distinct().Count() == 1 && this.hand.OrderByDescending(x => x.First == Ace).Last == Ten);
	{
		 return true;
	}
                

            }

    
    }
}
