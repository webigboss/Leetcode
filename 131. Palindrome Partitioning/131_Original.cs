public class Solution {
    public IList<IList<string>> Partition(string s) {
        var result = new List<IList<string>>();
        PartitionBacktracking(s, 0, new List<string>(), result);
        return result;
    }
    
    private void PartitionBacktracking(string s, int start, IList<string> list, IList<IList<string>> result){
        if(start == s.Length){
            result.Add(new List<string>(list));
            return;
        }       
        
        for(var i = start; i < s.Length; i++){
            if(!IsPalindrome(s, start, i))
                continue;
            list.Add(s.Substring(start, i - start + 1));
            PartitionBacktracking(s, i + 1, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
    
    private bool IsPalindrome(string s, int l, int r){
        if(r - l == 0)
            return true;
        while(l < r){
            if(s[l] != s[r])
                return false;
            l++;
            r--;
        }
        return true;
    }
}