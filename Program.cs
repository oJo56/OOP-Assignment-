using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("how many times would you like to shuffle?");

        Deck deck = new Deck();
        foreach (Card x in deck.Cards)
        {
            Console.WriteLine(x);
        }
    }
}

class Card
{
    protected Suits suit;
    protected string value;

    public Card(Suits secondSuit, string secondValue)
    {
        suit = secondSuit;
        value = secondValue;
    }
    public override string ToString()
    {
        return string.Format("{0} of {1}", value, suit);
    }
}

enum Suits
{
    Hearts,
    Clubs,
    Diamonds,
    Spades
}

class Deck
{
    Card[] cards = new Card[52];
    string[] values = new string[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
    public Deck()
    {
        int j = 0;
        foreach (string s in values)
        {
            cards[j] = new Card(Suits.Hearts, s);
            j++;
        }
        foreach (string s in values)
        {
            cards[j] = new Card(Suits.Clubs, s);
            j++;
        }
        foreach (string s in values)
        {
            cards[j] = new Card(Suits.Diamonds, s);
            j++;
        }
        foreach (string s in values)
        {
            cards[j] = new Card(Suits.Spades, s);
            j++;
        }
    }

    public Card[] Cards
    {
        get
        {
            return cards;
        }
    }
}