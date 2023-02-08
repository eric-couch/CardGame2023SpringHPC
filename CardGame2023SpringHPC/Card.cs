using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame2023SpringHPC
{
    internal class Card
    {
        public string suit { get; set; }
        public string rank { get; set; }
        public int val { get; set; }

        /// <summary>
        /// This is a card class
        /// </summary>
        /// <param name="suit">spades, hearts, clubs, diamonds (Use ASCII code:♥,♦,♣,♠)</param>
        /// <param name="rank">A, K, Q, J, 10, 9...</param>
        /// <param name="val">Standard value of the card</param>
        public Card(string suit, string rank, int val)
        {
            this.suit = suit;
            this.rank = rank;
            this.val = val;
        }

        public override string? ToString()
        {
            return $"{rank}{suit}";
        }
    }
}
