public class Solution {
    public int SlidingPuzzle(int[][] board) {
        //dfs approach by queue
        var sb = new StringBuilder();
        for(var j = 0; j < 2; ++j){
            for(var i = 0; i < 3; ++i){
                sb.Append(board[j][i]);
            }
        }
        var visited = new HashSet<string>();
        var b = sb.ToString(); 
        var q = new Queue<string>();
        q.Enqueue(b);
        var cnt = 1;
        var ans = 0;
        //all edges: 0->[1,3]; 1->[1,2,4]; 2->[1,5]; 3->[0,4]; 4->[1,3,5]; 5->[4,2]
        while(q.Count > 0){
            for(var i = 0; i < cnt; ++i){
                var cur = q.Dequeue();
                //Console.WriteLine($"cur:{cur}");
                if(cur == "123450") return ans;
                if(visited.Contains(cur)) continue;
                visited.Add(cur);
                var izero = 0;
                for(var j = 0; j < 6; ++j)
                    if(cur[j]=='0') izero = j;
                
                switch(izero){
                    case 0:
                        q.Enqueue(Swap(cur, 0, 1));
                        q.Enqueue(Swap(cur, 0, 3));
                        break;
                    case 1:
                        q.Enqueue(Swap(cur, 1, 0));
                        q.Enqueue(Swap(cur, 1, 2));
                        q.Enqueue(Swap(cur, 1, 4));
                        break;
                    case 2:
                        q.Enqueue(Swap(cur, 2, 1));
                        q.Enqueue(Swap(cur, 2, 5));
                        break;
                    case 3:
                        q.Enqueue(Swap(cur, 3, 0));
                        q.Enqueue(Swap(cur, 3, 4));
                        break;
                    case 4:
                        q.Enqueue(Swap(cur, 4, 1));
                        q.Enqueue(Swap(cur, 4, 3));
                        q.Enqueue(Swap(cur, 4, 5));
                        break;
                    default:
                        q.Enqueue(Swap(cur, 5, 4));
                        q.Enqueue(Swap(cur, 5, 2));
                        break;
                }
            }
            
            ans++;
            //Console.WriteLine($"ans:{ans}");
            cnt = q.Count;
        }
        return -1;
    }
    
    private string Swap(string a, int i, int j){
        var arr = a.ToCharArray();
        var temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        return new string(arr);
    }
}