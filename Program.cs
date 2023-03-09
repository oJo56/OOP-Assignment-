

Console.WriteLine("Which kind of shuffle would you like to do? 0 = No Shuffle, 1 = Fisher-Yates Shuffle, 2 = Riffle Shuffle"); // shows the user which inputs would correlate to which shuffle
int typeOfShuffle = Console.Read(); // reads the input

Deck deck = new Deck();
if (typeOfShuffle == 1)
{
    deck.FisherYatesShuffle(); // calls the function that attempts to complete the fisher-yates shuffle
}
foreach (Card x in deck.Cards) // outputs all the cards in the deck
{
    Console.WriteLine(x);
}
enum Suits // giving number value to the 4 suits
{
    Hearts,
    Clubs,
    Diamonds,
    Spades
}
class Card
{
    protected Suits suit;   
    protected string value;

    public Card(Suits secondSuit, string secondValue) // obtaining a second card value
    {
        suit = secondSuit;
        value = secondValue;
    }
    public override string ToString()
    {
        return string.Format("{0} of {1}", value, suit); // outputting the format for the card naming
    }
}



class Deck
{
    Card[] cards = new Card[52];
    string[] values = new string[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" }; // valuing all the different types of cards
    public Deck()
    {
        int j = 0;
        foreach (string i in values)
        {
            cards[j] = new Card(Suits.Hearts, i);  // names all of the cards, asssigning all 13 values of cards to each of the 4 suits
            j++;
        }
        foreach (string i in values)
        {
            cards[j] = new Card(Suits.Clubs, i);
            j++;
        }
        foreach (string i in values)
        {
            cards[j] = new Card(Suits.Diamonds, i);
            j++;
        }
        foreach (string i in values)
        {
            cards[j] = new Card(Suits.Spades, i);
            j++;
        }
    }

    public void FisherYatesShuffle()  // function to attempt a fisher yates shuffle
    {
        Random rand = new Random();
        for (int i = cards.Length - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
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