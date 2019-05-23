/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node(){}
    public Node(int _val,IList<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
}
*/
public class Solution {
    public Node CloneGraph(Node node) {
        var ht = new Hashtable();
        return CloneGraphRecursive(node, ht);
    }
    //this is essentially the Depth first search for graph theory, the recursion is equivalent of a stack structure
    //however to archive deep copy, stack data structure seems to be less straight-forward than implementing by recusion
    private Node CloneGraphRecursive(Node node, Hashtable ht){
        //exit criteria
        if(ht.Contains(node))
            return (Node)ht[node];
        
        var cloneNode = new Node();
        cloneNode.val = node.val;
        cloneNode.neighbors = new List<Node>();
        ht.Add(node, cloneNode);
        foreach(var childNode in node.neighbors){
            cloneNode.neighbors.Add(CloneGraphRecursive(childNode, ht));
        }
        return cloneNode;
    }
}