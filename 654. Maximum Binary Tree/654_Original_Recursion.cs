public class Solution {
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return Helper(nums, 0, nums.Length - 1);
    }
    
    private TreeNode Helper(int[] nums, int l, int r){
        if(l > r) return null;
        var imax = l;
        for(var i = l; i <= r; ++i)
            if(nums[i] > nums[imax]) imax = i;
        
        var root = new TreeNode(nums[imax]);
        //left subtree
        root.left = Helper(nums, l, imax - 1);
        root.right = Helper(nums, imax + 1, r);
        return root;
    }
}