/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        var result = new List<IList<int>>();
        if(root == null) return result;
        var q = new Queue<KeyValuePair<int, Node>>();
        q.Enqueue(new KeyValuePair<int, Node>(1, root));
        
        while(q.Count > 0){
            var kvp = q.Dequeue();
            if(result.Count != kvp.Key)
                result.Add(new List<int>());
            
            result[result.Count - 1].Add(kvp.Value.val);
            foreach(var child in kvp.Value.children){
                q.Enqueue(new KeyValuePair<int, Node>(kvp.Key + 1, child));
            }
        }
        return result;
    }
}