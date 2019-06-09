//it doesn't quite fit for this problem because it will generate duplicates, but the code is still worth revisiting
// Input:
// "2*3-4*5"
// Output:
// [10,-14,-10,-10,-14,-34]
// Expected:
// [-34,-14,-10,-10,10]
public class Solution {
    public IList<int> DiffWaysToCompute(string input) {
        //BFS solution
        var result = new List<int>();
        var q = new Queue<string>();
        q.Enqueue(input);
        q.Enqueue("+");
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            var pn = q.Dequeue(); //Positive or Negative
            var operatorFound = false;
            for(var i = 0; i < cur.Length; i++){
                if(cur[i] == '+' || cur[i] == '-' || cur[i] == '*'){
                    operatorFound = true;
                    var mid = 0;
                    var leftNumber = FindPreviousLength(cur, i);
                    var rightNumber = FindNextLength(cur, i);
                    var left = i - leftNumber.Length - 1 < 0 ? string.Empty : cur.Substring(0, i - leftNumber.Length);
                    var right = i + rightNumber.Length + 1 > cur.Length - 1 ? string.Empty : cur.Substring(i + rightNumber.Length + 1);
                    if(cur[i] == '+'){
                        mid = int.Parse(leftNumber) + int.Parse(rightNumber);
                    }
                    if(cur[i] == '-'){
                        mid = int.Parse(leftNumber) - int.Parse(rightNumber);;
                    }
                    if(cur[i] == '*'){
                        mid = int.Parse(leftNumber) * int.Parse(rightNumber);;
                    }
                    
                    q.Enqueue(left + Math.Abs(mid).ToString() + right);
                    if(mid < 0 && pn == "+" || mid > 0 && pn == "-")
                        q.Enqueue("-");
                    else
                        q.Enqueue("+");
                        
                }
            }
            if(!operatorFound){
                var num = pn == "+" ? int.Parse(cur) : int.Parse(cur) * -1; 
                result.Add(num);
            }
                
        }
        return result;
    }

    private string FindNextLength(string input, int curIndex){
        var sb = new StringBuilder();
        while(true){
            if(curIndex == input.Length - 1)
                break;
            if(!Char.IsDigit(input[++curIndex]))
                break;
            sb.Append(input[curIndex]);
        }
        return sb.ToString();
    }

    private string FindPreviousLength(string input, int curIndex){
        var sb = new StringBuilder();
        while(true){
            if(curIndex == 0)
                break;
            if(!Char.IsDigit(input[--curIndex]))
                break;
            sb.Append(input[curIndex]);
        }
        return sb.ToString();
    }
}