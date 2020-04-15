public class Solution {
    public bool CheckRecord(string s) {
        var countA = 0;
        var hasLessThan2ContinuesL = true;
        var countL = 0;

        foreach(var c in s){
            if(c == 'L') {
                countL++;
                if(countL > 2)
                    hasLessThan2ContinuesL = false;
            }
            else { 
                if(c == 'A') countA++;
                countL = 0;
            }
        }
        return countA <= 1 && hasLessThan2ContinuesL;
    }
}