using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card21Game
{
    class Card
    {
        String suit;
        public String face { get; set; }
        public Card(String suit, String face)
        {
            this.suit = suit;
            this.face = face;
        }
        public int getCardValue()
        {
            int cardValue;
            try
            {
                cardValue = Convert.ToInt32(this.face);
            }
            catch
            {
                cardValue = (int)(Enum.Parse(typeof(Faces), this.face));
            }
            return cardValue;
        }

        public override string ToString()
        {
            return String.Format("{0,-12}{1,8}",suit,face);
        }
    }

    public enum Faces
    {
        Ace = 11,
        Jack = 2,
        Queen = 3,
        King = 4
    }
}
