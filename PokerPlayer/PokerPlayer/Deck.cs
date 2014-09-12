using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPlayer
{
    class Deck
    {
        //STEP 1. Declare properties
        public List<Cards> CardList { get; set; }

        //STEP 2. Constructors
        public Deck()
        {
            CardList = new List<Cards>();

            for (int j = 1; j <= 4; j++)
            {

                for (int i = 2; i <= 14; i++)
                {
                    Cards card = new Cards((Rank)i, (Suit)j);

                    this.CardList.Add(card);
                }
            }
        }

        //STEP 3. Methods and Functions
        public void Shuffle()
        {
            Random shuffle = new Random();
            int totalCards = CardList.Count;
            while (totalCards > 1)
            {
                totalCards--;
                int randCard = shuffle.Next(0, totalCards);
                var x = CardList[randCard];
                CardList[randCard] = CardList[totalCards];
                CardList[totalCards] = x;
            }
        }

        public List<Cards> Deal(int numDealt)
        {
            List<Cards> dealCards = new List<Cards>();
            for (int i = 0; i < numDealt; i++)
            {
                dealCards.Add(CardList[i]);
            }
            for (int i = 0; i < dealCards.Count; i++)
            {
                CardList.Remove(dealCards[i]);
            }

            return dealCards;
        }
        public void PrintDeck()
        {
            foreach (var item in CardList)
            {
                item.DealFromDeck();
            }
        }


    }
}
