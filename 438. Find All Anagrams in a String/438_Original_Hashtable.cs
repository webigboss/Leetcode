public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var dict = new Dictionary<char, int>();
        var result = new List<int>();
        var i = 0;
        foreach(var c in p)
            AddToDict(dict, c);
        
        while(i < s.Length){
            if(i < p.Length){
                RemoveFromDict(dict, s[i]);
                i++;
                if(i == p.Length && dict.Count == 0)
                    result.Add(0);
                continue;
            }   
            var start = i - p.Length + 1;
            //this is the tricky part, try to think it via an example
            //basically it's a sliding window of fixed width, sliding from left to right
            //the right element to be added to the window, when there is same char found in the dict, remove it, otherwise add it
            //the left lement to be removed from the window, when this char can be found in the dict, remove it, otherwise add it back, it means it must be removed earlier if we cannot find it.
            RemoveFromDict(dict, s[i]);
            RemoveFromDict(dict, s[start - 1]);
            if(dict.Count == 0)
                result.Add(start);
            i++;
        }
        return result;
    }
    
    private void AddToDict(Dictionary<char, int> dict, char c){
        if(dict.ContainsKey(c))
            dict[c]++;
        else
            dict[c] = 1;
    }
    
    private void RemoveFromDict(Dictionary<char, int> dict, char c){ 
        if(dict.ContainsKey(c)){
            dict[c]--;
            if(dict[c] == 0)
                dict.Remove(c);
        }
        else // special logic, if char doesn't exist in the dict, add it back
            dict[c] = 1;
            
    }
}