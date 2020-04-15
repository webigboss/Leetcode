public class Solution {
    public int NextGreaterElement(int n) {
        var s = n.ToString();
        var prev = '0';
        var i = s.Length - 1;
        var nums = new List<int>();
        var sb = new StringBuilder();
        while(i >= 0 && s[i] - prev >= 0){
            nums.Add(s[i] - '0');
            prev = s[i];
            i--;
        }
        
        if(i == -1) 
            return -1;
        
        var j = 0;
        while(j < i)
            sb.Append(s[j++]);
        
        nums.Sort();
        j = 0;
        for(var k = 0; k < nums.Count; ++k){
            if(nums[k] > (s[i] - '0')){
                j = k;
                break;
            }
        }
        sb.Append(nums[j]);
        nums.RemoveAt(j);
        nums.Add(s[i] - '0');
        nums.Sort();
        
        foreach(var num in nums){
            sb.Append(num);
        }
        var result = long.Parse(sb.ToString());
        return result > int.MaxValue ? -1: (int)result;
    }
}