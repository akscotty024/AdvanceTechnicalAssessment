public class Card
{
    private string number;
    private string suit;

    public Card (string cardNumber, string cardSuit)
    {
        number = cardNumber;
        suit = cardSuit;

    }
    // Returns the string value of the card
    public override string ToString()
    {
        return number+suit;
    }
}