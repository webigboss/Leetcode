public class Solution {
    public int UniquePaths(int m, int n) {
        // Math Solution, it's essential a combination question, select m-1 (or n-1) element from total n + m - 2 elements
        // combination formula is (m + n - 2)! / (m-1)!*(n-1)! ==> (m+n)*(m+n-1)*...*(m+1) / n!
        if(n == 1 && m == 1)
            return 1;
        var result = 1l;
        for(var i = 1; i <= n - 1; i++){
            result =  result * (m - 1 + i) / i;
        }
        return (int)result;
    }
}