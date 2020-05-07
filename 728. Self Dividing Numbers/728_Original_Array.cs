public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        var ans = new List<int>();
        for(var i = left; i <= right; ++i){
            var arr = i.ToString().ToCharArray();
            var isSelfDiv = true;
            foreach(var c in arr){
                if(c == '0' || i%(c-'0') != 0){
                    isSelfDiv = false;
                    break;
                }
            }
            if(!isSelfDiv) continue;
            ans.Add(i);
        }
        return ans;
    }
}