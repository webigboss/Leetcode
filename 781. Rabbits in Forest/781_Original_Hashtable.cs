public class Solution {
    public int NumRabbits(int[] answers) {
        var dict = new Dictionary<int, int>();
        foreach(var a in answers){
            if(!dict.ContainsKey(a))
                dict[a] = 1;
            else
                dict[a]++;
        }
        var ans = 0;
        foreach(var kvp in dict){
            ans += (kvp.Key + 1) * 
                ((kvp.Value % (kvp.Key+1))==0 ? (kvp.Value / (kvp.Key+1)) : (kvp.Value / (kvp.Key+1)) + 1);
        }
        return ans;
    }
}