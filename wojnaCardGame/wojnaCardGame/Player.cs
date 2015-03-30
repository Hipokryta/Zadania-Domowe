using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wojnaCardGame
{
    class Player
    {
        public virtual int sumOfCardsValue { get; set; }
        public Queue<Card> deck;
        public String name { get; set; }
        public Player(String name, Queue<Card> deck)
        {
            this.name = name;
            this.deck = deck;
        }

        public Card drawCard()
        {
            Console.WriteLine(name+" ilosc pozostalych kart: "+deck.Count());
            if (deck.Count != 0)
            {
                Card drawedCard = deck.Dequeue();
                return drawedCard;
            }
            else
            {
                Console.WriteLine(name+" Przegral cala gre !!!");
                Console.ReadKey();

                System.Environment.Exit(0);
                return null;
            }
        }



        internal void Push(Stack<Card> treasureOfCards)
        {
            foreach (var card in treasureOfCards)
            {
                deck.Enqueue(card);
            }
            treasureOfCards.Clear();
        }
    }
}
