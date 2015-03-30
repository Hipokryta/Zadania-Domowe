using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card21Game
{
    class Player
    {
        public virtual int sumOfCardsValue { get; set; }
        private List<Card> cardsOnHand = new List<Card>();

        
        
        public Player()
        {
            drawCard();
            drawCard();
        }

        public virtual Card drawCard()
        {
            Card drawedCard = Deck.Instance.deckOfCardsToDraw.Dequeue();
            sumOfCardsValue = sumOfCardsValue + drawedCard.getCardValue();
            cardsOnHand.Add(drawedCard);
            return drawedCard;
        }
        public void getCardsOnHand()
        {
            foreach (var card in cardsOnHand)
            {
                Console.WriteLine(String.Format("{0,-6}",card.ToString()));
            }
        }
        
        public void checkScores(int score)
        {
            Console.WriteLine("twoj wynik to: "+sumOfCardsValue+"\nwynik komputera: "+score);
            if ((sumOfCardsValue > 21 && score > 21) | (sumOfCardsValue == 21 && score == 21)|(score==sumOfCardsValue))
            {
                Console.WriteLine("REMIS");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
                
            if(sumOfCardsValue == 21)
                Console.WriteLine("Wygrales");

            if (score == 21)
                Console.WriteLine("Przegrales");

            if (sumOfCardsValue > 21)
            {
                Console.WriteLine("Przegrales");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

            if (score > 21)
            {
                Console.WriteLine("Wygrales");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
               
            if (score > sumOfCardsValue)
                Console.WriteLine("Przegrales");
            else
                Console.WriteLine("Wygrales");

            Console.ReadKey();
            System.Environment.Exit(0);
        }
    }
}
