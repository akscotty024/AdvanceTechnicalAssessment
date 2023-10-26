public class HandEvaluator
{
    // This function checks if the hand of cards is One Pair
    public Boolean  isOnePair (Card[] hand)
    {
		int a,b,c,d,e;
		a = int.Parse(hand[0].ToString().Substring(0,1));
		b = int.Parse(hand[1].ToString().Substring(0,1));
		c = int.Parse(hand[2].ToString().Substring(0,1));
		d = int.Parse(hand[3].ToString().Substring(0,1));
		e = int.Parse(hand[4].ToString().Substring(0,1));

        if ( a==b || a==c || a==d || a==e || b==c || b==d || b==e || c==d || c==e || d==e){
			return true;	
		} else {
			return false;
		}
    }
    // This method is used to help assist determining a two pair.
    public Boolean checkThree(int x, int y, int z)
    {
        if (x == y || x == z || y==z){
		    return true;
	    } else {
		    return false;
	    }
    }
        // This function checks if the hand of cards is two pair
    public Boolean isTwoPair(Card[] hand)
    {
        int a,b,c,d,e;
		a = int.Parse(hand[0].ToString().Substring(0,1));
		b = int.Parse(hand[1].ToString().Substring(0,1));
		c = int.Parse(hand[2].ToString().Substring(0,1));
		d = int.Parse(hand[3].ToString().Substring(0,1));
		e = int.Parse(hand[4].ToString().Substring(0,1));

        if ( (a==b) && (checkThree(c,d,e) == true ) ){
			return true;
		}
		else if( (a==c) && (checkThree(b,d,e) == true ) ){
			return true;
		}
		else if( (a==d) && (checkThree(c,b,e) == true ) ){
			return true;
		}
		else if( (a==e) && (checkThree(b,c,d) == true ) ){
			return true;
		}
		else if( (b==c) && (checkThree(a,d,e) ==true ) ){
			return true;
		}
		else if( (b==d) && (checkThree(a,c,e) ==true ) ){
			return true;
		}
		else if( (b==e) && (checkThree(a,c,d) ==true ) ){
			return true;
		}
		else if( (c==d) && (checkThree(a,b,e) == true) ){
			return true;
		}
		else if( (c==e) && (checkThree(a,b,d) ==true ) ){
			return true;
		}
		else if( (d==e) && (checkThree(a,b,c) ==true ) ){
			return true;
		}
		else{
			return false;
		}
    }
	// This function checks if the hand is a Three of a Kind
    public Boolean isThreeOfAKind(Card[] hand){
		int a,b,c,d,e;
		a = int.Parse(hand[0].ToString().Substring(0,1));
		b = int.Parse(hand[1].ToString().Substring(0,1));
		c = int.Parse(hand[2].ToString().Substring(0,1));
		d = int.Parse(hand[3].ToString().Substring(0,1));
		e = int.Parse(hand[4].ToString().Substring(0,1));
		if ( (a==b && b==c) || (a==b && b==d) || (a==b && b==e) || (a==c && c==d) || (a==c && c==e) || (a==d && d==e) || (b==c && c==d) || (b==c && c==e) || (b==d && d==e) ||(c==d && d==e)){
			return true;
		}
		else{
			return false;
		}
	}

//function to check straight
public Boolean isStraight(Card[] hand){
		int a,b,c,d;
		a = int.Parse(hand[0].ToString().Substring(0,1))+4;
		b = int.Parse(hand[1].ToString().Substring(0,1))+3;
		c = int.Parse(hand[2].ToString().Substring(0,1))+2;
		d = int.Parse(hand[3].ToString().Substring(0,1))+1;
		if( a==b && b==c && c==d && d==int.Parse(hand[4].ToString().Substring(0,1))){
			return true;
		}
		else{
			return false;
		}
}
// This function checks if the hand is a flush
public Boolean isFlush(Card[] hand){
		string a,b,c,d;
		a = hand[0].ToString().Substring(1,1);
		b = hand[1].ToString().Substring(1,1);
		c = hand[2].ToString().Substring(1,1);
		d = hand[3].ToString().Substring(1,1);
		if( a==b && b==c && c==d && d==hand[4].ToString().Substring(1,1)){
			return true;
		}else{
			return false;
		}
}
// This function checks if the hand is a fullHouse
public Boolean isFullHouse(Card[] hand){
		if( (isThreeOfAKind(hand) == true) && (isOnePair(hand)==true) ){
			return true;
		}
		else{
			return false;
		}
}
// This function checks if the hand is a four of a kind
public Boolean isFourOfKind(Card[] hand){
		int a,b,c,d,e;
		a = int.Parse(hand[0].ToString().Substring(0,1));
		b = int.Parse(hand[1].ToString().Substring(0,1));
		c = int.Parse(hand[2].ToString().Substring(0,1));
		d = int.Parse(hand[3].ToString().Substring(0,1));
		e = int.Parse(hand[4].ToString().Substring(0,1));
		if ((a==b && b==c && c==d)||(b==c && c==d && d==e)|| (c==d && d==e && e==a) || (d==e && e==a && a==b) || (e==a && a==b && b==c)){
			return true;
		}
		else{
			return false;
		}
}
// This function checks if it is a straight flush
public Boolean isStraightFlush(Card[] hand){
		if ( (isFlush(hand) == true)&& isStraight(hand) == true){
			return true;
		}
		else{
			return false;
		}
}


// This function is used to determine whether the hand is straight flush,flush,two pair etc.
        public string determineHand(Card[] hand){
            string handResult = "High Cards";
			
            if(isStraightFlush(hand) == true){
                handResult = "Straight Flush";
            }
            else if(isFourOfKind(hand) == true){
                handResult = "Four of a Kind";
            }
            else if(isFullHouse(hand) == true){
                handResult = "Full House";
            }
            else if(isFlush(hand) == true){
                handResult = "Flush";
            }
            else if(isStraight(hand) == true){
                handResult = "Straight";
            }
            else if(isThreeOfAKind(hand) == true){
                handResult = "Three of a Kind";
            }
            else if(isTwoPair(hand) == true ){
                handResult = "Two Pair";
            }
            else if(isOnePair(hand) == true){
                handResult = "One Pair";
            }
            return handResult;	
        }
    

}