/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public int MaxDepth(Node root) {
        //DFS recursive appraoch
        if(root == null) return 0;
        
        var result = 0;
        foreach(var child in root.children){
            result = Math.Max(result, MaxDepth(child));
        }
        return result + 1;
    }
}