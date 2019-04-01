/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        var clist = new List<int>();
        var result = new List<IList<int>>();
        PathSumRecursive(root, 0, sum, clist, result);
        return result;
    }
    
    // cSum: sum till current level; tSum: targetd sum; cList: list till current level; tList: final result List
    private void PathSumRecursive(TreeNode n, int cSum, int tSum, IList<int> cList, IList<IList<int>> tList){
        if(n == null)
            return;
        
        var newcList = new List<int>(cList);
        newcList.Add(n.val);
        if(n.left == null && n.right == null && n.val + cSum == tSum){
            tList.Add(newcList);
            return;
        }
        PathSumRecursive(n.left, cSum + n.val, tSum, newcList, tList);
        PathSumRecursive(n.right, cSum + n.val, tSum, newcList, tList);
    }
}