public class Solution {
    public IList<int> DistanceK(TreeNode root, TreeNode target, int K) {
        //BFS with queue
        var dict = new Dictionary<int, List<int>>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(!dict.ContainsKey(cur.val))
                dict[cur.val] = new List<int>();
            
            if(cur.left != null){
                dict[cur.val].Add(cur.left.val);
                if(!dict.ContainsKey(cur.left.val))
                    dict[cur.left.val] = new List<int>();
                dict[cur.left.val].Add(cur.val);
                q.Enqueue(cur.left);
            }
            if(cur.right != null){
                dict[cur.val].Add(cur.right.val);
                if(!dict.ContainsKey(cur.right.val))
                    dict[cur.right.val] = new List<int>();
                dict[cur.right.val].Add(cur.val);
                q.Enqueue(cur.right);
            }
        }
        
        var q2 = new Queue<int>();
        var visited = new HashSet<int>();
        q2.Enqueue(target.val);
        int cnt = q.Count;
        while(q2.Count > 0 && K >= 0){
            for(var i = 0; i < cnt; ++i){
                var cur = q2.Dequeue();
                visited.Add(cur);
                if(!dict.ContainsKey(cur)) continue;
                foreach(var v in dict[cur]){
                    if(visited.Contains(v)) continue;
                    q2.Enqueue(v);
                }
            }
            cnt = q2.Count;
            K--;
        }
        return q2.ToList();
    }
}