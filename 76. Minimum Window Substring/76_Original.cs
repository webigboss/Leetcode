public class Solution {
    public string MinWindow(string s, string t) {
        var dict = new Dictionary<char, int>();
        var left = 0;
        var right = 0;
        var minLeft = 0;
        var minRight = int.MaxValue; 
        foreach(var c in t){
            if(dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);
        }
        var counter = dict.Count;
        
        //sliding window logic
        while(right < s.Length){
            //right 
            if(dict.ContainsKey(s[right])){
                dict[s[right]]--;
                if(dict[s[right]] == 0){
                    counter--;
                }
            }
            if(counter == 0){
                //valid answer found, contract left
                while(left <= right){
                    if(counter > 0)
                        break;
                    if(right - left < minRight - minLeft){
                        minRight = right;
                        minLeft = left;
                    }
                    if(dict.ContainsKey(s[left])){
                        dict[s[left]]++;
                        if(dict[s[left]] > 0){
                            counter++;
                        }
                    }
                    left++;
                }
            }
            right++;   
        }
        
        if(minRight == int.MaxValue)
            return string.Empty;
        return s.Substring(minLeft, minRight - minLeft + 1);
        
    }
}