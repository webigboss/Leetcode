public class Solution {
    public string ReorganizeString(string S) {
        //hash table
        var dictCnt = new Dictionary<char, int>();
        var l = S.Length;
        var maxCount = 0;
        foreach(var c in S){
            if(!dictCnt.ContainsKey(c))
                dictCnt[c] = 1;
            else
                dictCnt[c]++;
            maxCount = Math.Max(maxCount, dictCnt[c]);
        }
        
        if(maxCount > (int)((l+1)/2))
            return string.Empty;
        
        //sort by length
        var arrsorted = dictCnt.ToArray();
        Array.Sort(arrsorted, (a,b)=>b.Value - a.Value);
        var sb = new StringBuilder();
        foreach(var kvp in arrsorted){
            sb.Append(new string(kvp.Key, kvp.Value));
        }
        var strSorted = sb.ToString();
        
        var ans = new char[l];
        
        for(var i = 0; i < l; ++i){
            if(i*2 < l){
                ans[i*2] = strSorted[i];
            }
            else{
                var index = l%2==0 ? (i*2)%l+1 : (i*2)%l;
                ans[index] = strSorted[i];
            }
        }
        
        return new String(ans);        
        

        
    }
}