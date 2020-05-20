public class Solution {
    public int ExpressiveWords(string S, string[] words) {
        //
        var ans = 0;
        foreach(var w in words){
            if(CanStretch(S, w)) {
                ans++;
                Console.WriteLine(w);
            }
        }
        return ans;
    }
    
    bool CanStretch(string s, string w){
        if(s.Length < w.Length) return false;
        int j = 0, cnt = 0, wcnt = 1;
        for(var i = 0; i < s.Length; ++i){
            if(j == w.Length || s[i] != w[j]) {
                Console.WriteLine("1");
                return false;
            }
            cnt++;
            if(i < s.Length - 1 && s[i] != s[i+1]){
                if(cnt == 2 && wcnt != 2 || cnt < wcnt) {
                    Console.WriteLine($"i:{i}, j:{j}, cnt:{cnt}, wcnt:{wcnt}");
                    return false;
                }
                j++;
                cnt = 0;
                wcnt = 1;
            }
            else if(j < w.Length - 1 && w[j] == w[j+1]){
                j++;
                wcnt++;
            }
        }
        Console.WriteLine($"cnt:{cnt}, wcnt:{wcnt}");
        return cnt == 2 && wcnt != 2 || cnt < wcnt ? false : true;
    }
}