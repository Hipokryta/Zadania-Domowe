using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card21Game
{
    class Computer : Player
    {
        public override int sumOfCardsValue { get; set; }
        private List<Card> cardsOnHand = new List<Card>();

        
        public override Card drawCard() {
            if (sumOfCardsValue < 17)
            {
                Card drawedCard = Deck.Instance.deckOfCardsToDraw.Dequeue();
                sumOfCardsValue = sumOfCardsValue + drawedCard.getCardValue();
                cardsOnHand.Add(drawedCard);

                return drawedCard;
            }
            return null;
        }
        public void getCardsOnHand()
        {
            foreach (var card in cardsOnHand)
            {
                Console.WriteLine(String.Format("{0,-6}", card.ToString()));
            }
        }
        
    }
}
