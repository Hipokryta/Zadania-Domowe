using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wojnaCardGame
{
    class Program
    {
        private static bool isGameLauch = true;
        static Stack<Card> treasureOfCards = new Stack<Card>();
        public static Stack<Card> treasure
        {
            get { return treasureOfCards; }
            set { treasureOfCards = value; }
        } 
        public static bool gameState
        {
            get { return isGameLauch; }
            set { isGameLauch = value; }
        } 
        static void Main(string[] args)
        {
            Queue<Card> playerDeck = Deck.Instance.halfOfDeckToDrawForPlayer;
            Queue<Card> computerDeck = Deck.Instance.halfOfDeckToDrawForComputer;

            Player player = new Player("Gracz", playerDeck);
            Player computer = new Player("Komputer", computerDeck);

            GameLogic game = new GameLogic(player, computer);
           
            do
            {
                Console.WriteLine("Czy chcesz zagrac karte t/n ?");
                String answer = "t"; //Console.ReadLine();

                if (answer == "t")
                {
                    game.run();
                }
                    
                if (answer == "n")
                    gameState = false;

            } while (isGameLauch);
        }
 
    }
}
