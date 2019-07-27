/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
    //iterative preorder DFS
    
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        var result = string.Empty;
        var st = new Stack<TreeNode>();
        var sb = new StringBuilder();
        while(true){
            while(root != null){
                sb.Append(root.val).Append(',');
                st.Push(root);
                root = root.left;
            }
            sb.Append('x').Append(',');
            if(st.Count == 0) break;
            root = st.Pop().right;
        }
        result = sb.ToString();
        if(result[result.Length - 1] == ',')
            result = result.Substring(0, result.Length - 1);
        return result;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        var dummyRoot = new TreeNode(-1);
        var cur = dummyRoot;
        var st = new Stack<TreeNode>();
        TreeNode next = null;
        var dataList = data.Split(',');
        foreach(var s in dataList){
            if(s == "x")
                next = null;
            else
                next = new TreeNode(int.Parse(s));
            
            if(cur == null){
                cur = st.Pop();
                cur.right = next;
                cur = cur.right;
            }
            else{
                cur.left = next;
                st.Push(cur);
                cur = cur.left;
            }
        }
        return dummyRoot.left;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));