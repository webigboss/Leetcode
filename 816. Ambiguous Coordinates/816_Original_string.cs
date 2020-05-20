public class Solution {
    public IList<string> AmbiguousCoordinates(string S) {
        S = S.Substring(1, S.Length-2);
        var hs = new HashSet<string>();
        for(var i = 0; i < S.Length-1; ++i){
            var a = S.Substring(0, i+1);
            var b = S.Substring(i+1);
            var list = Check(a, b);
            foreach(var s in list)
                hs.Add(s);
        }
        
        return hs.ToList();
    }
    
    
    IList<string> Check(string a, string b){
        Console.WriteLine($"a:{a}, b:{b}");
        
        if(!IsValid(a) || !IsValid(b)) return new List<string>();
        
        var lista = AddDecimalPoint(a);
        var listb = AddDecimalPoint(b);
        
        var ans = new List<string>();
        for(var i = 0; i < lista.Count; ++i){
            for(var j = 0; j < listb.Count; ++j){
                ans.Add($"({lista[i]}, {listb[j]})");
            }
        }
        return ans;
    }
    
    bool IsValid(string a){
        if(a.Length == 1) return true;
        if(a[0] == '0' && a[a.Length-1] == '0') return false;
        return true;
    }
    
    List<string> AddDecimalPoint(string a){
        var ans = new List<string>();
        if(a[a.Length-1] == '0' || a.Length == 1){
            ans.Add(a);
            return ans;
        }
        if(a[0] == '0'){
            ans.Add("0."+ a.Substring(1));
            return ans;
        }

        ans.Add(a);
        for(var i = 0; i < a.Length-1; ++i){
            ans.Add(a.Substring(0, i+1) + '.' + a.Substring(i+1));
        }
        return ans;
    }
    
}