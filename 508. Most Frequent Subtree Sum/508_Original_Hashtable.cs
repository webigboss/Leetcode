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
    public int[] FindFrequentTreeSum(TreeNode root) {
        var dict = new Dictionary<int, int>();
        Helper(root, dict);
        var result = new List<int>();
        var max = 0;
        foreach(var kvp in dict){
            if(kvp.Value > max){
                result.Clear();
                max = kvp.Value;
                result.Add(kvp.Key);
            }
            else if(kvp.Value == max){
                result.Add(kvp.Key);
            }
            
        }
        return result.ToArray();
    }
    
    private int Helper(TreeNode node, Dictionary<int, int> dict){
        if(node == null) return 0;
        var leftSum = Helper(node.left, dict);
        var rightSum = Helper(node.right, dict);
        var curSum = node.val + leftSum + rightSum;
        if(!dict.ContainsKey(curSum))
            dict[curSum] = 1;
        else
            dict[curSum]++;
        return curSum;
    }
}