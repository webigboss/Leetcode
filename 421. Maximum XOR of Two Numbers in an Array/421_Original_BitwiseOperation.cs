public class Solution {
    public int FindMaximumXOR(int[] nums) {
        var maxXOR = 0;
        var mask = 0;
        var hs = new HashSet<int>();
        for(var i = 31; i >= 0; i--){
            mask = mask | (1 << i); // equals to mask |= (i << i);
            hs.Clear();
            foreach(var num in nums){
                var leftOnlyNum = num & mask;
                hs.Add(leftOnlyNum);
            }
            var greedyTarget = maxXOR | (1 << i);
            foreach(var leftOnlyNum in hs){
                var anotherNumForXOR = leftOnlyNum ^ greedyTarget;
                if(hs.Contains(anotherNumForXOR)){
                    maxXOR = greedyTarget;
                    //!!! important!!! the reason why we can break below is because now that we know 
                    //there exists a pair (could be more) that their leftOnlyNum can give us the max XOR result, 
                    //we don't care which exact pair and can break it right away sincw next iteration on the next bit, 
                    //those pairs that can give us the max XOR result will be definitely came of all the pair(s) from current iteration;
                    break;
                }
            }
        }
        return maxXOR;
    }
}