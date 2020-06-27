public class Solution {
    public int KthFactor(int n, int k) {
        int sqrt = (int)Math.Sqrt(n) + 1;
        var factors = new HashSet<int>();
        for(var i = 1; i <= sqrt; ++i){
            if(n % i == 0){
                factors.Add(i);
                factors.Add(n/i);
            }
        }
        var list = factors.ToList();
        list.Sort();
        if(list.Count < k) return -1;
        return list[k-1];
    }
}