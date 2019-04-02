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
    public int SumNumbers(TreeNode root) {
        var numlist = new List<int>();
        SumNumbersRecursive(root, 0, numlist);
        var sum = 0;
        foreach(var num in numlist)
            sum += num;
        return sum;
    }
    
    private void SumNumbersRecursive(TreeNode n, int num, List<int> numlist){
        if(n == null)
            return;
        //preorder recursion
        num = num * 10 + n.val; 
             
        if(n.left == null && n.right == null){
            // leave node logic
            numlist.Add(num);   
        }
        
        SumNumbersRecursive(n.left, num, numlist);
        SumNumbersRecursive(n.right, num, numlist);
    }
}