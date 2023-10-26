public class Deck
{
    private Card[] deck;
    private int currentCard;
    private const int NUM_OF_CARDS = 52;
    private Random randomNumber;

    public Deck ()
    {
        // Needed so that the correct symbols for clubs,spade, hearts and diamonds get printed in the app
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // the values start \u is the UTF values for the spades,hearts,diamonds and clubs
        string[] suits = {"\u2660","\u2665","\u2666","\u2663"};
        string[] numbers = {"1","2","3","4","5","6","7","8","9","10","11","12","13"};
        
        deck = new Card[NUM_OF_CARDS];
        currentCard = 0;
        randomNumber = new Random();        
        for(int i = 0; i < deck.Length; i++)
        {
            deck[i] = new Card(numbers[i % 11], suits[i/13]);
        }

    }
    // Shuffles the deck sort algorithm used to sort the deck
    public void shuffleDeck()
    {
        currentCard = 0;
        for(int first = 0; first < deck.Length; first++)
        {
            int second = randomNumber.Next(NUM_OF_CARDS);
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
        Console.Write("Shuffling ... Shuffling ... Shuffling ...");

    }
    // Return the next card in the deck of cards
    public Card DealCard() {

        return deck[currentCard++];
    }
}