public class Solution {
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        int maxHeight = -1, cnt = 0;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        cnt = q.Count;
        while(q.Count > 0){
            for(var i = 0; i < cnt; ++i){
                var cur = q.Dequeue();
                if(cur.left != null)
                    q.Enqueue(cur.left);
                if(cur.right != null)
                    q.Enqueue(cur.right);
            }
            cnt = q.Count;
            maxHeight++;
        }
        //Console.WriteLine(maxHeight);
        var ans = new TreeNode[1];
        Helper(root, maxHeight, 0, ans);
        return ans[0];
    }
    
    int Helper(TreeNode node, int maxHeight, int curHeight, TreeNode[] ans){
        if(node == null) return curHeight-1;
        
        var left = Helper(node.left, maxHeight, curHeight+1, ans);
        var right = Helper(node.right, maxHeight, curHeight+1, ans);
        if(left == right && left == maxHeight) {
            //Console.WriteLine($"ans-> {node.val}");
            ans[0] = node;
        }
        return Math.Max(left, right);
    }
}