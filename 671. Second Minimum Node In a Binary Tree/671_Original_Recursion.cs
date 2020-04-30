public class Solution {
    public int FindSecondMinimumValue(TreeNode root) {
        if(root == null) return -1;
        var mins = new []{root.val, -1};
        Helper(root, mins);
        return mins[1];
    }
    
    private void Helper(TreeNode node, int[] mins){
        if(node == null) return;
        
        if(node.val > mins[0]){
            if(mins[1] == -1)
                mins[1] = node.val;
            else
                mins[1] = Math.Min(mins[1], node.val);
            return;
        }
        
        Helper(node.left, mins);
        Helper(node.right, mins);
    }
}