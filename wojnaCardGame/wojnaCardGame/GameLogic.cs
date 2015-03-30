using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace wojnaCardGame
{
    class GameLogic
    {
        Player player, computer;
        String playerName, computerName;
        static Stack<Card> treasureOfCards = Program.treasure;
        public GameLogic(Player player, Player computer)
        {
            this.computer = computer;
            this.player = player;
            this.playerName = player.name;
            this.computerName = computer.name;

        }
        public void run()
        {
        begining: 
            Card computerCard = computer.drawCard();
            Card playerCard = player.drawCard();

            Console.WriteLine(String.Format("{0,-14}{1,6}\n{2,-14}{3,6}", computerName, computerCard.ToString(), playerName, playerCard.ToString())); 
            Console.WriteLine();

            treasureOfCards.Push(computerCard);
            treasureOfCards.Push(playerCard);

            
            if (playerCard.getCardValue() == computerCard.getCardValue())
            {
                Console.WriteLine("REMIS - WOJNA !!!");

                Card computerBackflipCard = computer.drawCard();
                Card playerBackflipCard = player.drawCard();

                treasureOfCards.Push(computerBackflipCard);
                treasureOfCards.Push(playerBackflipCard);

                Card computerTopCard = computer.drawCard();
                Card playerTopCard = player.drawCard();

                treasureOfCards.Push(computerTopCard);
                treasureOfCards.Push(playerTopCard);

                Console.WriteLine();
                Console.WriteLine(String.Format("{0,-14}{1,6}\n{2,-14}{3,6}", computerName, computerTopCard.ToString(), playerName, playerTopCard.ToString())); 
            
                if (computerTopCard.getCardValue()==playerTopCard.getCardValue())
                {
                    Console.WriteLine("Remis\n");
                    goto begining;
                }
                else if (computerTopCard.getCardValue() > playerTopCard.getCardValue())
                {
                    Console.WriteLine(computerName + " Wygrywa !!!\n");
                    computer.Push(treasureOfCards);
                    return;
                }
                else
                {
                    Console.WriteLine(playerName + " Wygrywa !!!\n");
                    player.Push(treasureOfCards);
                    return;
                }
            }
            
            if (playerCard.getCardValue() > computerCard.getCardValue())
            {
                Console.WriteLine(playerName + " Wygrywa !!!\n");
                player.Push(treasureOfCards);
            }
            else
            {
                Console.WriteLine(computerName + " Wygrywa !!!\n");
                computer.Push(treasureOfCards);
            }
  
        }
    }
}
