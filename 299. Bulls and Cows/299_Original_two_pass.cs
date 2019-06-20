public class Solution {
    public string GetHint(string secret, string guess) {
        var bull = 0;
        var cow = 0;
        var secretDigitCount = new int[10];
        var guessDigitCount = new int[10];
        for(var i = 0; i < secret.Length; i++){
            secretDigitCount[secret[i] - '0']++;
            guessDigitCount[guess[i] - '0']++;
            if(secret[i] == guess[i])
                bull++;
        }
        
        for(var i = 0; i < secretDigitCount.Length; i++)
            cow += Math.Min(secretDigitCount[i], guessDigitCount[i]);
        cow -= bull;
        return bull.ToString() + "A" + cow.ToString() + "B";
    }
}