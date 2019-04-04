/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node(){}
    public Node(int _val,Node _left,Node _right,Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
}
*/
public class Solution {
    public Node Connect(Node root) {
        var tarlevel = 1;
        while(true){
            var linkedList = new LinkedList<Node>();
            PopulateLevel(root, 1, tarlevel, linkedList);
            tarlevel++;
            if(linkedList.Count == 0)
                break;
        }
        return root;
    }
    
    private void PopulateLevel(Node n, int curlevel, int tarlevel, LinkedList<Node> list){
        if(n == null)
            return;
        if(curlevel == tarlevel){
            if(list.Count > 0){
                ((Node)list.Last.Value).next = n;
            }
            list.AddLast(n);
            return;
        }
        if(curlevel < tarlevel){
            curlevel++;
            PopulateLevel(n.left, curlevel, tarlevel, list);
            PopulateLevel(n.right, curlevel, tarlevel, list);
        }
        
    }
}