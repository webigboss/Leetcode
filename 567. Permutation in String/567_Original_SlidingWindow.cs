public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        //sliding windows, note that I define the windows starts with lo+1 to hi, so lo's initial value is -1;
        var lo = -1;
        var hi = 0;
        var dict = new Dictionary<char, int>();
        foreach(var c in s1){
            if(dict.ContainsKey(c))
                dict[c]++;
            else{
                dict[c] = 1;
            }
        }
        
        //sliding window
        while(true){          
            //keep advancing the hi if current char is found in the dict
            while(hi < s2.Length){
                if(dict.ContainsKey(s2[hi])){ 
                    dict[s2[hi]]--;
                    if(dict[s2[hi]] == 0)
                        dict.Remove(s2[hi]);
                    if(dict.Count == 0)
                        return true;
                    hi++;
                }
                else break;
            }
            
            //if current char isn't found in the dict, then advance lo by 1 step, and add char at lo back to dict
            if(hi == s2.Length) return false;
            lo++;
            if(hi < lo) {
                hi = lo;
                continue;
            }
            if(dict.ContainsKey(s2[lo]))
                dict[s2[lo]]++;
            else
                dict[s2[lo]] = 1;
        }
        
        return false;
    }
}