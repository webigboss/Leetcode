public class Solution {
    public TreeNode ConstructFromPrePost(int[] pre, int[] post) {
        //Console.WriteLine($"pre: [{string.Join(',', pre)}]; post: [{string.Join(',', post)}]");
        int n = pre.Length, l = 0;
        if(n == 0) return null;
        var node = new TreeNode(pre[0]);
        if(n == 1) return node;
        for(var i = 0; i < n; ++i){
            if(post[i] == pre[1]){
                l = i+1;
                break;
            }
        }
        int[] lPre = new int[l], lPost = new int[l], rPre = new int[n-l-1], rPost = new int[n-l-1];
        Array.Copy(pre, 1, lPre, 0, l);
        Array.Copy(post, 0, lPost, 0, l);
        Array.Copy(pre, l+1, rPre, 0, n-l-1);
        Array.Copy(post, l, rPost, 0, n-l-1);
        node.left = ConstructFromPrePost(lPre, lPost);
        node.right = ConstructFromPrePost(rPre, rPost);
        return node;
    }
}