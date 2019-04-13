public class Solution {
    public string GetPermutation(int n, int k) {
        var farray = new int[n + 1];
        var nums = new List<int>();
        var result = new List<int>();
        farray[0] = 1;
        var factorial = 1;
        for(var i = 1; i <= farray.Length - 1; i++){
            factorial = factorial * i;
            farray[i] = factorial;
            nums.Add(i);
        }
        
        GetPermutationHelper(n, k, nums, farray, result);
        var sb = new StringBuilder();
        foreach(var i in result){
            sb.Append(i);
        }
        return sb.ToString();
    }
    
    private void GetPermutationHelper(int n, int k, IList<int> nums, int[] farray, List<int> result){
        if(n == 0)
            return;
        if(k == farray[n]){
            result.AddRange(new List<int>(nums.Reverse()));
            return;
        }
        else{ 
            //k < farray[n]
            if(k <= farray[n - 1]){
                result.Add(nums[0]);
                nums.RemoveAt(0);
                GetPermutationHelper(n - 1, k, nums, farray, result);
            }
            else{
                // farray[n - 1] < k < farray[n]
                var quotient = k / farray[n - 1];
                var remainder = k % farray[n - 1];
                var advance = remainder == 0 ? quotient - 1 : quotient;
                result.Add(nums[advance]);
                nums.RemoveAt(advance);
                GetPermutationHelper(n - 1, k - advance * farray[n - 1], nums, farray, result);
            }
        }
    }
}