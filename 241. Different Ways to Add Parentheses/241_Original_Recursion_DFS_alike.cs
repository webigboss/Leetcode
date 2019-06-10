public class Solution {
    public IList<int> DiffWaysToCompute(string input) {
        // DFS recursion solution
        
        var result = new List<int>();
        var operatorFound = false;
        for(var i = 0; i < input.Length; i++){
            if(input[i] == '+'|| input[i] == '-' || input[i] == '*'){
                operatorFound = true;
                var left = DiffWaysToCompute(input.Substring(0, i));
                var right = DiffWaysToCompute(input.Substring(i + 1));
                
                foreach(var l in left){
                    foreach(var r in right){
                        if(input[i] == '+')
                            result.Add(l + r);
                        if(input[i] == '-')
                            result.Add(l - r);
                        if(input[i] == '*')
                            result.Add(l * r);
                    }
                }
            }
        }
        //if the input is a number, doesn't have operator, return this a list with only this input as int
        if(!operatorFound)
            result.Add(int.Parse(input));
        
        return result;
    }
}