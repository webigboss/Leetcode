public class Solution {
    public int[] ConstructArray(int n, int k) {
        //official sol 2, left and right index getting 
        var l = 1;
        var r = k + 1;
        var ans = new int[n];
        for(var j = 0; j < n; ++j)
            ans[j] = j+1;
        var i = 0;
        var isLeft = true;
        while(i <= k){
            if(isLeft)
                ans[i++] = l++;
            else
                ans[i++] = r--;
            isLeft = !isLeft;
        }
        return ans;
    }
}