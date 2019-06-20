public class Solution {
    public string GetHint(string secret, string guess) {
        var bull = 0;
        var cow = 0;
        var digitCount = new int[10];
        for(var i = 0; i < secret.Length; i++){
            if(secret[i] == guess[i])
                bull++;
            else{
                if(digitCount[secret[i] - '0'] > 0) cow++; 
                if(digitCount[guess[i] - '0'] < 0) cow++;
                digitCount[secret[i] - '0']--;
                digitCount[guess[i] - '0']++;
            }
        }
        return bull.ToString() + "A" + cow.ToString() + "B";
    }
}