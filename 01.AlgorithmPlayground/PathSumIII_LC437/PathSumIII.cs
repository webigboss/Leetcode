namespace AlgorithmPlayground
{
    public class PathSumIII
    {
        public PathSumIII()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(-2);
            root.right = new TreeNode(-3);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(-2);
            root.left.left.left = new TreeNode(-1);
            var result = PathSum(root, 3);
        }
        public int PathSum(TreeNode root, int sum)
        {
            //DFS recursively traverse the tree and pass each node into the method below
            //the way of traversing can be done by iterative BFS by utilizing a queue, or iterative DFS by utilizing a stack
            if (root == null) return 0;
            return PathSumFromNode(root, 0, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
        }

        private int PathSumFromNode(TreeNode node, int aggregate, int sum)
        {
            if (node == null)
                return 0;
            aggregate += node.val;
            var resultFromChild = PathSumFromNode(node.left, aggregate, sum) + PathSumFromNode(node.right, aggregate, sum);
            if (aggregate == sum)
                return 1 + resultFromChild;
            else
                return resultFromChild;
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