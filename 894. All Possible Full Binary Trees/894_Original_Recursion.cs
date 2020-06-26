public class Solution {
    public IList<TreeNode> AllPossibleFBT(int N) {
        var ans = new List<TreeNode>();
        N--;
        if(N == 0) {
            ans.Add(new TreeNode(0));
            return ans;
        }
        
        for(var i = 1; i < N; i+=2){
            var left = AllPossibleFBT(i);
            var right = AllPossibleFBT(N-i);
            
            for(var j = 0; j < left.Count; ++j){
                for(var k = 0; k < right.Count; ++k){
                    var node = new TreeNode(0);
                    node.left = left[j];
                    node.right = right[k];
                    ans.Add(node);
                }
            }
        }
        return ans;
    }
}