public class Solution {
    enum Direction{
        Up,
        Down,
        Left,
        Right
    }
    
    public int RobotSim(int[] commands, int[][] obstacles) {
        var vo = new Dictionary<int, HashSet<int>>();
        var ho = new Dictionary<int, HashSet<int>>();
        for(var i = 0; i < obstacles.Length; ++i){
            int x = obstacles[i][0], y = obstacles[i][1];
            if(!vo.ContainsKey(x))
                vo[x] = new HashSet<int>();
            if(!ho.ContainsKey(y))
                ho[y] = new HashSet<int>();
            vo[x].Add(y);
            ho[y].Add(x);
        }
        
        var cur = new int[2];
        var d = Direction.Up;
        var ans = 0;
        for(var i = 0; i < commands.Length; ++i){
            if(commands[i] < 0)
                d = ChangeDirections(d, commands[i]);
            else{
                if(d == Direction.Up || d == Direction.Down){
                    if(!vo.ContainsKey(cur[0])) {
                        cur[1] = d == Direction.Up ? cur[1]+commands[i] : cur[1]-commands[i];
                        continue;
                    }
                    for(var j = 0; j < commands[i]; ++j){
                        if(d == Direction.Up){
                            if(vo[cur[0]].Contains(cur[1]+1)) break;
                            cur[1]++;
                        }
                        if(d == Direction.Down){
                            if(vo[cur[0]].Contains(cur[1]-1)) break;
                            cur[1]--;
                        }
                        
                    }
                }
                else if(d == Direction.Left || d == Direction.Right){
                    if(!ho.ContainsKey(cur[1])) {
                        cur[0] = d == Direction.Right ? cur[0]+commands[i] : cur[0]-commands[i];
                        continue;
                    }
                    for(var j = 0; j < commands[i]; ++j){
                        if(d == Direction.Right){
                            // Console.WriteLine($"j:{j}, cur[0]+j+1: {cur[0]+j+1}");
                            // Console.WriteLine($"ho[cur[1]]: [{string.Join(',',ho[cur[1]])}]");
                            if(ho[cur[1]].Contains(cur[0]+1)) break;
                            cur[0]++;
                        }
                        if(d == Direction.Left){
                            if(ho[cur[1]].Contains(cur[0]-1)) break;
                            cur[0]--;
                        }
                    }
                }
            }
            ans = Math.Max(ans, cur[0]*cur[0]+cur[1]*cur[1]);
            // Console.WriteLine($"cur:[{cur[0]},{cur[1]}], d:{d:G}");
        }
        // Console.WriteLine($"cur:[{cur[0]},{cur[1]}], d:{d:G}");
        ans = Math.Max(ans, cur[0]*cur[0]+cur[1]*cur[1]);
        return ans;
    }

    
    Direction ChangeDirections(Direction d, int c){
        switch (d){
            case Direction.Up:
                return c == -1 ? Direction.Right : Direction.Left; 
            case Direction.Down:
                return c == -1 ? Direction.Left : Direction.Right; 
            case Direction.Left:
                return c == -1 ? Direction.Up : Direction.Down; 
            default:
                return c == -1 ? Direction.Down : Direction.Up;
        }
    }
}