public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        //optimal TC O(n) one pass solution, inspired by:
        //https://leetcode.com/problems/gas-station/discuss/42568/Share-some-of-my-ideas
        
        //note to my self:
        //this solution is based on the observaion:
        //starting from 0 index, if to a station A where the gas ran out,
        //the any stations in between 0 and A won't be the answer, because if we start from any
        //station in middle, the tank starts with 0, and if we start from 0, the tank remains will
        // also be either greater than 0 or at least equals to 0. 
        // also based on the unique 
        var start = 0;
        var sumGas = 0; 
        var sumCost = 0;
        var tankRemains = 0;
        for(var i = 0; i < gas.Length; i++){
            sumGas += gas[i];
            sumCost += cost[i];
            tankRemains += gas[i] - cost[i];
            if(tankRemains < 0){
                start = i + 1;
                tankRemains = 0;
            }
        }
        return sumGas < sumCost ? -1 : start;
    }
}