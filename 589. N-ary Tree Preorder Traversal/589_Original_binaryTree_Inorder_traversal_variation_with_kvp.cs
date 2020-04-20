public class Solution {
    public IList<int> Preorder(Node root) {
        //!!don't need to be this complex, as preorder is essentially a DFS search
        //use the iterative DFS with a stack will do this job, this also applies to 
        //Preorder traversal of a BinaryTree
        //this solution is used for In-order traversal, which is more ticky
        //it's good to come up with this variation for n-ary!
        var st = new Stack<KeyValuePair<Node,int>>();
        var result = new List<int>();
        
        while(true){
            while(root != null){
                result.Add(root.val);
                if(root.children != null && root.children.Count > 0){
                    st.Push(new KeyValuePair<Node, int>(root, 1));
                    root = root.children[0];
                }
                else
                    root = null;
            }    
            if(st.Count == 0) break;
            var kvp = st.Pop();
            if(kvp.Value < kvp.Key.children.Count){
                root = kvp.Key.children[kvp.Value];
                st.Push(new KeyValuePair<Node, int>(kvp.Key, kvp.Value + 1));
            }
            else 
                root = null;
        }
        return result;
    }
}