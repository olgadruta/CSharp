using System;
using System.Collections.Generic;

namespace DeckOfcards
{
    class Card
    {
        public string stringVal;
        public string Suit;
        public int Val;

        public Card(string strVal, string suit, int val)
        {
            stringVal = strVal;
            Suit = suit;
            Val = val;
        }
    }
    class Deck
    {
        public List<Card> ListCards;
        public Deck()
        {
            ListCards = new List<Card>();
            // {
            // };
        }
        public void CreateDeck()
        {
            Dictionary<string, int> TopCards = new Dictionary<string, int>();
            TopCards.Add("Ace", 1);
            TopCards.Add("2", 2);
            TopCards.Add("3", 3);
            TopCards.Add("4", 4);
            TopCards.Add("5", 5);
            TopCards.Add("6", 6);
            TopCards.Add("7", 7);
            TopCards.Add("8", 8);
            TopCards.Add("9", 9);
            TopCards.Add("10", 10);
            TopCards.Add("Jack", 11);
            TopCards.Add("Queen", 12);
            TopCards.Add("King", 13);
            foreach (KeyValuePair<string, int> card in TopCards)
            {
                Console.WriteLine(card.Key+"Clubs"+card.Value);
            }
            foreach (KeyValuePair<string, int> card in TopCards)
            {
                Console.WriteLine(card.Key+"Spades"+card.Value);
            }
            foreach (KeyValuePair<string, int> card in TopCards)
            {
                Console.WriteLine(card.Key+"Hearts"+card.Value);
            }
            foreach (KeyValuePair<string, int> card in TopCards)
            {
                Console.WriteLine(card.Key+"Diamonds"+card.Value);
            }
        }

    }
    class Player
    {
        public string Name;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.CreateDeck();
            // Console.WriteLine("Hello World!");
        }
    }
}
