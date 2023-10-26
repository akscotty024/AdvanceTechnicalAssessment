namespace PokerTests
{

[TestClass]
public class PokerTests
{

    [TestMethod]
    public void testIsStraightFlush()
    {
        HandEvaluator evaluator = new HandEvaluator();
        Card[] hand = new Card[5];
        hand[0].ToString().Replace("2","\u2665");
        hand[1].ToString().Replace("5","\u2665");
        hand[2].ToString().Replace("3","\u2665");
        hand[3].ToString().Replace("7","\u2665");
        hand[4].ToString().Replace("9","\u2665");
       
        Assert.AreEqual(true, evaluator.isFlush(hand));

    }
}
}