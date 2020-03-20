public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        //DFS recursion approach
        var dict = new Dictionary<int, IList<int>>();
        //global visited
        var hsGlobal = new HashSet<int>();
        //!!! it's not mandatory to use a stack to hold the answer, it could be a list, but just be cause use the nature of stack is storing element in a reverse order when we pop elements out
        var stResult = new Stack<int>();
        foreach(var e in prerequisites){
            if(!dict.ContainsKey(e[1]))
                dict[e[1]] = new List<int>{e[0]};
            else
                dict[e[1]].Add(e[0]);
        }
        
        for(var i = 0; i < numCourses; i++){
            var hsCur = new HashSet<int>();
            if(!DfsHelper(i, dict, hsGlobal, hsCur, stResult))
                return false;
        }
        return true;
    }
    
    //if it's not a DAG, return false;
    private bool DfsHelper(int num, Dictionary<int, IList<int>> dict, 
                           HashSet<int> hsGlobal, HashSet<int> hsCur, Stack<int> stResult){
        //cannot swap below 2 check, the checking for DAG should be of higher priority, otherwise DAG checking will not working properly
        if(hsCur.Contains(num))
            return false;
        hsCur.Add(num);
        
        if(hsGlobal.Contains(num)){
            hsCur.Remove(num);
            return true;
        }
        hsGlobal.Add(num);
        

        
        if(dict.ContainsKey(num)){
            foreach(var next in dict[num]){
                if(!DfsHelper(next, dict, hsGlobal, hsCur, stResult))
                    return false;
            }
        }
        hsCur.Remove(num);
        stResult.Push(num);
        return true;
    }
}