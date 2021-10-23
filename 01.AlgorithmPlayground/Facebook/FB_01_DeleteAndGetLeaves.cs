using System;
using System.Collections.Generic;
using System.Linq;


//given a binary tree, get all its leaves and delete them, keep doing that until the tree is empty
// e.g. input
//        1
//      /   \
//     2     3
//    /  \   
//   4    5
// output: [[4,5,3][2][1]]
public class FB_01_DeleteAndGetLeave{
    
    public class TreeNode{
        public TreeNode left;
        public TreeNode right;
        public int val;
        public TreeNode(int val = 0) {
            this.val = val;
        }
    }

    public void Test(){
        TreeNode root;
        root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);
        List<List<int>> list;

        list = DeleteAndGetLeaves(root);

        Console.WriteLine($"[{string.Join(",", list.Select(l=> $"[{string.Join(",", l)}]"))}]");
        
    }

    public List<List<int>> DeleteAndGetLeaves(TreeNode root) {
        var dictLevel = new Dictionary<int, List<int>>();
        Helper(root, dictLevel);
        var ans = new List<List<int>>();
        return new List<List<int>>(dictLevel.Values);
    }

    int Helper(TreeNode node, Dictionary<int,List<int>> dict) {
        if(node == null)
            return -1;

        if(node.left == null && node.right == null) {
            if(!dict.ContainsKey(0))
                dict[0] = new List<int>();
            dict[0].Add(node.val);
            return 0;
        }

        var left = Helper(node.left, dict);
        var right = Helper(node.right, dict);

        var level = Math.Max(left, right) + 1;
        if(!dict.ContainsKey(level))
            dict[level] = new List<int>();
        dict[level].Add(node.val);
        return Math.Max(left, right) + 1;
    }
}