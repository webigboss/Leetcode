public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        //DFS(recursion) with memo 
        return DfsHelper(s, wordDict, new Dictionary<string, IList<string>>());
    }
    
    private IList<string> DfsHelper(string s, IList<string> wordDict, Dictionary<string, IList<string>> dict){
        //if found in the dict, skip repeating the process of s, it's result already exists;
        if(dict.ContainsKey(s))
            return dict[s];
        
        if(string.IsNullOrEmpty(s)){
            return new List<string>{ "" }; //need to have an element to make foreach down below happen
        }
        
        var curResult = new List<string>();
        foreach(var word in wordDict){
            if(s.StartsWith(word)){
                var prevResult = DfsHelper(s.Substring(word.Length), wordDict, dict);
                foreach(var prev in prevResult){
                    curResult.Add(string.IsNullOrEmpty(prev) ? word : word + " " + prev);
                }
            }
        }
        dict[s] = curResult;
        // if s doesn't start with any string in the word dict, then return curResult will be empty list, which 
        // will not make the foreach happen all the way up. make the final result an empty list roo. meaning word is unbreakable
        return curResult;
    }
}