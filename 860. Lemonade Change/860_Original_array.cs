public class Solution {
    public bool LemonadeChange(int[] bills) {
        var hand = new int[2];
        for(var i = 0; i < bills.Length; ++i){
            if(bills[i] == 5)
                hand[0]++;
            else if(bills[i] == 10){
                if(hand[0] == 0) return false;
                hand[0]--;
                hand[1]++;
            }
            else{
                if(hand[1] > 0 && hand[0] > 0){
                    hand[0]--;
                    hand[1]--;
                }
                else if(hand[0] > 2){
                    hand[0] -= 3;
                }
                else 
                    return false;
            }
        }
        return true;
    }
}