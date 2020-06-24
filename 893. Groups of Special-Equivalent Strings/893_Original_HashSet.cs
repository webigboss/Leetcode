public class Solution {
    public int NumSpecialEquivGroups(string[] A) {
        var hs = new HashSet<string>();
        for(var i = 0; i < A.Length; ++i){
            var str = GetString(A[i]);
            hs.Add(str);
        }
        return hs.Count;
    }
    
    string GetString(string s){
        var isEven = true;
        var listE = new List<Char>();
        var listO = new List<Char>();
        for(var i = 0; i < s.Length; ++i){
            if(isEven)
                listE.Add(s[i]);
            else
                listO.Add(s[i]);
            isEven = !isEven;
        }
        var sb = new StringBuilder();
        listE.Sort();
        listO.Sort();
        foreach(var c in listE)
            sb.Append(c);
        sb.Append('|');
        foreach(var c in listO)
            sb.Append(c);
        return sb.ToString();
    }
}