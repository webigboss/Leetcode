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
        //BFS iterative with queue
        if(root == null) return 0;
        var q = new Queue<Node>();
        var result = 0;
        
        q.Enqueue(root);
        var size = q.Count;
        while(q.Count > 0){
            while(size > 0){
                var node = q.Dequeue();
                foreach(var child in node.children)
                    q.Enqueue(child);
                size--;
            }
            result++;
            size = q.Count;
        }
        return result;
    }
}