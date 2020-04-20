using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15._1ConsumingAPIs.Models
{
    public class Deal
    {
        public string deckID { get; set; }
        public Card[] Cards { get; set; }

    }

    public class Card
    {
        public Uri Image { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
    }
}
