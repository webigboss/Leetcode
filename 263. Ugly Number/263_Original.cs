public class Solution {
    public bool IsUgly(int num) {
        //BFS queue
        if(num <= 0)
            return false;
        var q = new Queue<int>();
        q.Enqueue(num);
        int cur;
        while(q.Count > 0){
            cur = q.Dequeue();
            if(cur == 1) 
                return true;
            if(cur % 2 == 0)
                q.Enqueue(cur / 2);
            if(cur % 3 == 0)
                q.Enqueue(cur / 3);
            if(cur % 5 == 0)
                q.Enqueue(cur / 5);
        }
        return false;
    }
}