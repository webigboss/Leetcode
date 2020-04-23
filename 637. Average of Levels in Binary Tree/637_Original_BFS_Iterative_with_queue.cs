public class Solution {
    public IList<double> AverageOfLevels(TreeNode root) {
        //BFS with a queue
        var q = new Queue<TreeNode>();
        var ans = new List<double>();
        q.Enqueue(root);
        double sum = 0;
        var count = q.Count;
        while(q.Count > 0){
            for(var i = 0; i < count; ++i){
                var node = q.Dequeue();
                sum += node.val;
                if(node.left != null)
                    q.Enqueue(node.left);
                if(node.right != null)
                    q.Enqueue(node.right);
            }
            ans.Add(sum / count);
            sum = 0;
            count = q.Count;
        }
        return ans;
    }
}