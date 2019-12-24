using System.Text;
using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class SerializeandDeserializeBST
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public SerializeandDeserializeBST()
        {
            var root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            var serializedResult = serialize(root);
            var deserializedNode = deserialize(serializedResult);
        }

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            //use 'n' for null nodes, serialize level by level top down using BFS 
            var q = new Queue<TreeNode>();
            var sb = new StringBuilder();
            TreeNode cur = null;
            q.Enqueue(root);

            while (q.Count > 0)
            {
                cur = q.Dequeue();
                if (cur != null)
                {
                    sb.Append(cur.val);
                    q.Enqueue(cur.left);
                    q.Enqueue(cur.right);
                }
                else
                {
                    sb.Append('n');
                }
                sb.Append(',');
            }
            var result = sb.ToString();
            return result.Substring(0, result.Length - 1);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var vals = data.Split(',');
            if (vals[0] == "n")
                return null;
            var root = new TreeNode(int.Parse(vals[0]));
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            TreeNode cur = null;
            var i = 1;
            while (i < vals.Length)
            {
                cur = q.Dequeue();
                if (vals[i] != "n")
                {
                    cur.left = new TreeNode(int.Parse(vals[i]));
                    q.Enqueue(cur.left);
                }
                i++;
                if (vals[i] != "n")
                {
                    cur.right = new TreeNode(int.Parse(vals[i]));
                    q.Enqueue(cur.right);
                }
                i++;
            }
            return root;
        }
    }
}