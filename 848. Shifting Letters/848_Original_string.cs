public class Solution {
    public string ShiftingLetters(string S, int[] shifts) {
        var totalShifts = new int[S.Length];
        for(var i = S.Length - 1; i >= 0; --i){
            totalShifts[i] = shifts[i] % 26;
            if(i < S.Length - 1)
                totalShifts[i] += totalShifts[i+1]%26;
        }
        
        var arr = S.ToCharArray();
        for(var i = 0; i < arr.Length; ++i){
            arr[i] = (char)((arr[i] - 97 + totalShifts[i])%26 + 97);
        }
        return new string(arr);
    }
}