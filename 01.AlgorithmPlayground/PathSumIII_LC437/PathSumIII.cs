namespace AlgorithmPlayground
{
    public class PathSumIII
    {
        public PathSumIII(){
            var root = new TreeNode(1);
            root.left = new TreeNode(-2);
            root.right = new TreeNode(-3);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(-2);
            root.left.left.left = new TreeNode(-1);
            var result = PathSum(root, 3);
        }
        private int result = 0;
        public int PathSum(TreeNode root, int sum)
        {
            //DFS recursively traverse the tree and pass each node into the method below
            //the way of traversing can be done by iterative BFS by utilizing a queue, or iterative DFS by utilizing a stack
            if(root == null) return 0;
            PathSumFromNode(root, 0, sum);
            PathSum(root.left, sum);
            PathSum(root.right, sum);
            return result;
        }

        private void PathSumFromNode(TreeNode node, int aggregate, int sum)
        {
            if (node == null)
                return;

            if (node.val + aggregate == sum)
            {
                result++;
                return;
            }
            aggregate += node.val;
            PathSumFromNode(node.left, aggregate, sum);
            PathSumFromNode(node.right, aggregate, sum);
        }
    }



    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}