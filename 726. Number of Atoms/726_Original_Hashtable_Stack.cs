public class Solution {
    public string CountOfAtoms(string formula) {
        var st = new Stack<Dictionary<string, int>>();
        var strsb = new StringBuilder();
        var numsb = new StringBuilder();
        var curDict = new Dictionary<string, int>();
        var ele = string.Empty;
        var isPclosing = false;
        for(var i=0; i < formula.Length; ++i){
            var c = formula[i];
            if(c == '('){
                Check(curDict, st, strsb, numsb, isPclosing);
                isPclosing = false;
                st.Push(curDict);
                curDict = new Dictionary<string, int>();
            }
            else if(c == ')'){
                Check(curDict, st, strsb, numsb, isPclosing);
                isPclosing = true;
                // st.Push(curDict);
                // curDict = new Dictionary<string, int>();
            }
            else if(Char.IsDigit(c)){
                numsb.Append(c);
            }
            else if(c >= 65 && c <= 90){//[A-Z] 65-90
                Check(curDict, st, strsb, numsb, isPclosing);
                isPclosing = false;
                strsb.Append(c);
            }
            else if(c >= 97 && c <= 122){//[a-z] 97-122
                strsb.Append(c);
            }
        }
        Check(curDict, st, strsb, numsb, isPclosing);
        
        // Console.WriteLine($"st.Count:{st.Count}; curDict.Count: {curDict.Count}");
        // foreach(var kvp in curDict){
        //     Console.WriteLine($"{kvp.Key}->{kvp.Value}");
        // }
        
        var list = curDict.ToList();
        list.Sort((a,b) => String.Compare(a.Key, b.Key));
        var sb = new StringBuilder();
        foreach(var kvp in list){
            sb.Append(kvp.Key);
            if(kvp.Value > 1)
                sb.Append(kvp.Value.ToString());
        }
        return sb.ToString();
    }
    
    private void Check(Dictionary<string, int> dict, Stack<Dictionary<string, int>> st, StringBuilder strsb, StringBuilder numsb, bool isPclosing){
        var num = numsb.Length == 0 ? 1 : int.Parse(numsb.ToString());
        //Console.WriteLine($"Check(): strsb: {strsb.ToString()}, num: {num}, st.Count:{st.Count}");
        if(strsb.Length == 0){// closing parentheses case
            if(st.Count == 0 || !isPclosing) return;
            var top = st.Pop();
            Multiply(dict, num);
            Merge(dict, top);
        }
        else{
            var ele = strsb.ToString();

            if(!dict.ContainsKey(ele))
                dict[ele] = num;
            else
                dict[ele] += num;
        }
        strsb.Clear();
        numsb.Clear();
    }
    
    private void Multiply(Dictionary<string, int> dict, int factor){
        if(factor == 1 || factor == 0) return;
        var keys = new List<string>(dict.Keys);
        foreach(var key in keys){
            dict[key] *= factor;
        }
    }
    
    private void Merge(Dictionary<string, int> dictTo, Dictionary<string, int> dictFrom){
        foreach(var kvp in dictFrom){
            if(!dictTo.ContainsKey(kvp.Key))
                dictTo[kvp.Key] = kvp.Value;
            else
                dictTo[kvp.Key] += kvp.Value;
        }
    }
}