public class Solution {
    private bool isAdditiveNumber = false;
    public bool IsAdditiveNumber(string num) {
        for(var i = 0; i < num.Length / 2; i++){
            for(var j = i + 1; Math.Max(i + 1, j - i) <= num.Length - j - 1; j++){
                var strPre = num.Substring(0, i + 1);
                var strCur = num.Substring(i + 1, j - i);
                if(strPre[0] == '0' && strPre.Length > 1 || strCur[0] == '0' && strCur.Length > 1)
                    continue;
                var pre = long.Parse(strPre);
                var cur = long.Parse(strCur);
                BacktrackingHelper(num, pre, cur, j + 1);
            }
        }
        return isAdditiveNumber;
    }
    
    private void BacktrackingHelper(string num, long pre, long cur, int isum){
        if(isAdditiveNumber)
            return;
        var sum = pre + cur;
        var sumLength = sum.ToString().Length;
        if(isum + sumLength > num.Length)
            return;
        if(num.Substring(isum, sumLength) == sum.ToString()){
            if(isum + sumLength == num.Length){
                isAdditiveNumber = true;
                return;
            }
            BacktrackingHelper(num, cur, sum, isum + sumLength);
        }
    }
}