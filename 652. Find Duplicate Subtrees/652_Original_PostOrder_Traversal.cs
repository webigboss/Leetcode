public class Solution {
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        var ans = new List<TreeNode>();
        Helper(root, ans, new Dictionary<string, bool>());
        return ans;
    }
    
    private string Helper(TreeNode node, IList<TreeNode> list, Dictionary<string, bool> dict){
        if(node == null) return "n";
        //the serialized string is pre-order, but the recursion is postorder as we need to calculate both chlildren node first to get the serialized string;
        var preorder = node.val + ',' + Helper(node.left, list, dict) + ',' + Helper(node.right, list, dict);
        if(dict.ContainsKey(preorder)){
            if(!dict[preorder]) list.Add(node);
            dict[preorder] = true;
        }
        else
            dict[preorder] = false;
        return preorder;
    }
}