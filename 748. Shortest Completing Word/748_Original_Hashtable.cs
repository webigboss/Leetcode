public class Solution {
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        // var dict = new Dictionary<char, int>();
        var dict = new int[26];
        var cnt = 0;
        licensePlate = licensePlate.ToLower();
        foreach(var c in licensePlate){
            if(c-'a' >= 0 && c-'a' < 26){
                dict[c-'a']++;
                cnt++;
            }
        }
        
        // var sb = new StringBuilder();
        // for(var i = 0; i < dict.Length; ++i){
        //     sb.Append($"{(char)('a'+i)}:{dict[i]} ");
        // }
        // Console.WriteLine(sb.ToString());
        
        var ans = string.Empty;
        for(var i=0; i < words.Length; ++i){
            words[i] = words[i].ToLower();
            var curCnt = cnt;
            var curDict = new int[26];
            var isMatch = false;
            Array.Copy(dict, curDict, 26);
            foreach(var c in words[i]){
                if(curDict[c-'a'] > 0){
                    curDict[c-'a']--;
                    curCnt--;
                }
                if(curCnt == 0) {
                    isMatch = true;
                    break;
                }
            }
            
            if(isMatch){
                // Console.WriteLine($"Match Found: {words[i]}; ans: {ans}");
                if(string.IsNullOrEmpty(ans))
                    ans = words[i];
                else{
                    ans = ans.Length > words[i].Length ? words[i] : ans;
                }
            }
        }
        return ans;        
    }
}