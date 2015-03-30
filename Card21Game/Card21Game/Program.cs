using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card21Game
{
    class Program
    {
        private static bool isGameLauch = true;

        public static bool gameState
        {
            get { return isGameLauch; }
            set { isGameLauch = value; }
        } 
        
        static void Main(string[] args)
        {

            Player player = new Player();
            Computer computer = new Computer();
            Card playerCard,computerCard;

            Console.WriteLine("Twoje karty na rece");
            player.getCardsOnHand();

            do
            {
                Console.WriteLine("Czy Chcesz Dobrac Karte ? t/n");
                String answer = Console.ReadLine();
                computerCard = computer.drawCard();

                if (answer == "t")
                {
                    playerCard = player.drawCard();
                    Console.WriteLine("Twoje karty na rece");
                    player.getCardsOnHand();
                }

                if (answer == "n")
                {
                    while (computer.drawCard() != null) ;
                    gameState = false;
                }
                    

            } while (isGameLauch);

            Console.WriteLine("Karty na rece komputera ");
            computer.getCardsOnHand();

            Console.WriteLine("Twoje karty na rece");
            player.getCardsOnHand();

            player.checkScores(computer.sumOfCardsValue);
            Console.ReadKey();
        }

    }
}
