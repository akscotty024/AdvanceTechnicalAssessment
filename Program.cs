// Advance Technical Assessment
namespace AdvanceTechnicalAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM_OF_CARD_IN_HAND = 5;
            
            Deck deck = new Deck();
            HandEvaluator handEvaluator = new HandEvaluator();
            Card[] hand = new Card[NUM_OF_CARD_IN_HAND];
            Card[] printHand = new Card[NUM_OF_CARD_IN_HAND];
            deck.shuffleDeck();
            Console.Write("\nYour hand: ");
            for(int i = 0; i < NUM_OF_CARD_IN_HAND; i++){
                hand[i] = deck.DealCard();
                printHand[i] = hand[i];
                // Replacing the value from the deck to the correct char to print out correctly
                // for Ace,King Queen and Jack.
                if(printHand[i].ToString().Substring(0,1) == "1"){
                    printHand[i].ToString().Substring(0,1).Replace("1","A");
                } else if(printHand[i].ToString() == "11"){
                    printHand[i].ToString().Substring(0,1).Replace("11","J");
                } else if (printHand[i].ToString() == "12"){
                    printHand[i].ToString().Substring(0,1).Replace("12","Q");
                } else if (printHand[i].ToString() == "13")
                    printHand[i].ToString().Substring(0,1).Replace("13","K");
                Console.Write(printHand[i] +" ");
            }
            Console.WriteLine("\nYour have: " + handEvaluator.determineHand(hand));
            
        }
    } 

}