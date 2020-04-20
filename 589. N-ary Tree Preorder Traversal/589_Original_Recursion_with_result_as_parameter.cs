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
        //recursion with pass in result as a parameter;
        var result = new List<int>();
        Helper(root, result);
        return result;
    }
    
    private void Helper(Node node, IList<int> list){
        if(node == null) return;
        
        list.Add(node.val);
        foreach(var c in node.children)
            Helper(c, list);
    }
}