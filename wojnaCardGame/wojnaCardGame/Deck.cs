using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wojnaCardGame
{
    class Deck
    {
        private static String[] suits = { "hearts", "spades", "diamonds", "clubs" };
        private static String[] faces = { "Ace", "7", "8", "9", "10", "Jack", "Queen", "King" };

        private static Random r = new Random();

        private List<Card> deckOfCardsToShuffle = new List<Card>();
        private Queue<Card> deckOfCardsToDraw = new Queue<Card>();

        public Queue<Card> halfOfDeckToDrawForComputer = new Queue<Card>();
        public Queue<Card> halfOfDeckToDrawForPlayer = new Queue<Card>();

        private static Deck instance;
        public static Deck Instance
        { 
            get
            {
                if (instance == null)
                {
                    instance = new Deck();
                }
                return instance;
            }
        }
        private Deck()
        {
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < faces.Length; j++)
                {
                    deckOfCardsToShuffle.Add(new Card(suits[i], faces[j]));
                }
            }

            this.Shuffle();
            for (int i = 0; i < deckOfCardsToDraw.Count/2; i++)
            {
                halfOfDeckToDrawForComputer.Enqueue(deckOfCardsToDraw.Dequeue());
            }

            for (int i = 0; i < deckOfCardsToDraw.Count; i++)
            {
                halfOfDeckToDrawForPlayer.Enqueue(deckOfCardsToDraw.Dequeue());
            }
        }

        public void Shuffle()
        {
            for (int n = deckOfCardsToShuffle.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Card temp = deckOfCardsToShuffle[n];
                deckOfCardsToShuffle[n] = deckOfCardsToShuffle[k];
                deckOfCardsToShuffle[k] = temp;
            }

            foreach (var card in deckOfCardsToShuffle)
            {
                deckOfCardsToDraw.Enqueue(card);
            }
        }
    }
}
