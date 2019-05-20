public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        var result = -1;
        var sumGas = 0;
        var sumCost = 0;
        var step = 0;
        for(var i = 0; i < gas.Length; i++){
            step = 0;
            sumGas = 0;
            sumCost = 0;
            while(true){
                sumGas += gas[(i + step) % gas.Length];
                sumCost += cost[(i + step) % gas.Length];
                if(sumGas < sumCost)
                    break;
                step++;
                if(step == gas.Length)
                    return i;
            }   
        }
        
        return result; 
    }
}