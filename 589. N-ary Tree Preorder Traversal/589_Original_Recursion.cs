/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        if(root == null) return new List<int>();
        
        var result = new List<int>{root.val};
        foreach(var c in root.children){
            result.AddRange(Preorder(c));
        }
        // result.AddRange(Preorder(root.left));
        // result.AddRange(Preorder(root.right));
        return result;
    }
}