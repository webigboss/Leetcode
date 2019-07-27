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
    //recursive preorder DFS approach
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        var sb = new StringBuilder();
        var result = string.Empty;
        serializeHelper(root, sb);
        result = sb.ToString();
        if(result[result.Length - 1] == ',')
            result = result.Substring(0, result.Length - 1);
        return result;
    }
    
    private void serializeHelper(TreeNode node, StringBuilder sb){
        if(node == null){
            sb.Append('x').Append(',');
            return;
        }
        sb.Append(node.val).Append(',');
        serializeHelper(node.left, sb);
        serializeHelper(node.right, sb);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        var q = new Queue<string>(data.Split(','));
        
        return deserializeHelper(q);
    }
    
    private TreeNode deserializeHelper(Queue<string> q){
        var s = q.Dequeue();
        if(s == "x")
            return null;
        var node = new TreeNode(int.Parse(s));
        node.left = deserializeHelper(q);
        node.right = deserializeHelper(q);
        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));