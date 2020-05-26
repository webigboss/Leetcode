public class Solution {
    IList<int> result;
    public IList<int> SplitIntoFibonacci(string S) {
        result = new List<int>();
        Helper(S, 1, new string(S[0],1), new List<int>());
        return result;
    }
    
    bool Helper(string s, int index, string cur, IList<int> list){
        if(cur.Length > 1 && cur[0] == '0' || long.Parse(cur) > int.MaxValue) return false;
        
        if(index == s.Length){
            // Console.WriteLine($"cur: {cur}; list:[{string.Join(',', list)}]");
            if(list.Count >= 2 && list[list.Count-2] + list[list.Count-1] == int.Parse(cur)){
                list.Add(int.Parse(cur));
                result = new List<int>(list);
                list.RemoveAt(list.Count-1);
                // Console.WriteLine($"cur: {cur}; result:[{string.Join(',', result)}]");
                return true;
            }
            return false;
        }
    
        if(list.Count >= 2 && list[list.Count-2] + list[list.Count-1] == int.Parse(cur)
          || list.Count < 2){
            list.Add(int.Parse(cur));
            if(Helper(s, index+1, new string(s[index],1), list)) return true;
            list.RemoveAt(list.Count-1);
        }
        if(Helper(s, index+1, cur+s[index], list)) return true;
        return false;
    }
}