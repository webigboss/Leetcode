// Suppose we have some input data describing a graph of relationships between parents and children over multiple generations. The data is formatted as a list of (parent, child) pairs, where each individual is assigned a unique positive integer identifier.

// For example, in this diagram, 6 and 8 have common ancestors of 4 and 14.

//              15
//              |
//          14  13
//          |   |
// 1   2    4   12
//  \ /   / | \ /
//   3   5  8  9
//    \ / \     \
//     6   7     11

// parentChildPairs1 = [
//     (1, 3), (2, 3), (3, 6), (5, 6), (5, 7), (4, 5),
//     (4, 8), (4, 9), (9, 11), (14, 4), (13, 12),
//     (12, 9),(15, 13)
// ]

// Write a function that takes this data and the identifiers of two individuals as inputs and returns true if and only if they share at least one ancestor. 

// Sample input and output:

// hasCommonAncestor(parentChildPairs1, 3, 8) => false
// hasCommonAncestor(parentChildPairs1, 5, 8) => true
// hasCommonAncestor(parentChildPairs1, 6, 8) => true
// hasCommonAncestor(parentChildPairs1, 6, 9) => true
// hasCommonAncestor(parentChildPairs1, 1, 3) => false
// hasCommonAncestor(parentChildPairs1, 3, 1) => false
// hasCommonAncestor(parentChildPairs1, 7, 11) => true
// hasCommonAncestor(parentChildPairs1, 6, 5) => true
// hasCommonAncestor(parentChildPairs1, 5, 6) => true

// Additional example: In this diagram, 4 and 12 have a common ancestor of 11.

//         11
//        /  \
//       10   12
//      /  \
// 1   2    5
//  \ /    / \
//   3    6   7
//    \        \
//     4        8

// parentChildPairs2 = [
//     (1, 3), (11, 10), (11, 12), (2, 3), (10, 2),
//     (10, 5), (3, 4), (5, 6), (5, 7), (7, 8),
// ]

// hasCommonAncestor(parentChildPairs2, 4, 12) => true
// hasCommonAncestor(parentChildPairs2, 1, 6) => false
// hasCommonAncestor(parentChildPairs2, 1, 12) => false

// n: number of pairs in the input



using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        var parentChildPairs = new List<int[]>() {
            new int[]{5, 6},
            new int[]{1, 3},
            new int[]{2, 3},
            new int[]{3, 6},
            new int[]{15, 12},
            new int[]{5, 7},
            new int[]{4, 5},
            new int[]{4, 9},
            new int[]{9, 12},
            new int[]{30, 16}
        };
        
//         var ans = GetNodeWithZeroOrOneParent(parentChildPairs);
        
//         foreach(var a in ans){
//             Console.WriteLine($"[{string.Join(',', a)}]");
//         }
        
        var parentChildPairs1 = new List<int[]>() {
            new int[]{1, 3},
            new int[]{2, 3},
            new int[]{3, 6},
            new int[]{5, 6},
            new int[]{5, 7},
            new int[]{4, 5},
            new int[]{4, 8},
            new int[]{4, 9},
            new int[]{9, 11},
            new int[]{14, 4},
            new int[]{13, 12},
            new int[]{12, 9},
            new int[]{15, 13}
        };

        var parentChildPairs2 = new List<int[]>() {
            new int[]{1, 3},
            new int[]{11, 10},
            new int[]{11, 12},
            new int[]{2, 3},
            new int[]{10, 2},
            new int[]{10, 5},
            new int[]{3, 4},
            new int[]{5, 6},
            new int[]{5, 7},
            new int[]{7, 8}
        };
// hasCommonAncestor(parentChildPairs1, 3, 8) => false
// hasCommonAncestor(parentChildPairs1, 5, 8) => true
// hasCommonAncestor(parentChildPairs1, 6, 8) => true
// hasCommonAncestor(parentChildPairs1, 6, 9) => true
// hasCommonAncestor(parentChildPairs1, 1, 3) => false
// hasCommonAncestor(parentChildPairs1, 3, 1) => false
// hasCommonAncestor(parentChildPairs1, 7, 11) => true
// hasCommonAncestor(parentChildPairs1, 6, 5) => true
// hasCommonAncestor(parentChildPairs1, 5, 6) => true
//         var ans = HasCommonAncestor(parentChildPairs1,3,8);
        Console.WriteLine(HasCommonAncestor(parentChildPairs1,3,8));
        Console.WriteLine(HasCommonAncestor(parentChildPairs1,5,8));
        Console.WriteLine(HasCommonAncestor(parentChildPairs1,6,8));
        Console.WriteLine(HasCommonAncestor(parentChildPairs1,6,9));
        Console.WriteLine(HasCommonAncestor(parentChildPairs1,1,3));
        Console.WriteLine(HasCommonAncestor(parentChildPairs1,3,1));
        Console.WriteLine(HasCommonAncestor(parentChildPairs1,7,11));
        Console.WriteLine(HasCommonAncestor(parentChildPairs1,6,5));
        Console.WriteLine(HasCommonAncestor(parentChildPairs1,5,6));
        Console.WriteLine("---------------------");
        Console.WriteLine(HasCommonAncestor(parentChildPairs2,4,12));
        Console.WriteLine(HasCommonAncestor(parentChildPairs2,1,6));
        Console.WriteLine(HasCommonAncestor(parentChildPairs2,1,12));

    }
    
    static List<List<int>> GetNodeWithZeroOrOneParent(List<int[]> pairs){
        var dict = new Dictionary<int, List<int>>();
        int n = pairs.Count;
        for(var i= 0; i < n; i++){
            int p = pairs[i][0], c = pairs[i][1];
            if(!dict.ContainsKey(p)){
                dict[p] = new List<int>();
            }
            if(!dict.ContainsKey(c)){
                dict[c] = new List<int>();
            }
            dict[c].Add(p);
        }
        
        var ans0 = new List<int>();
        var ans1 = new List<int>();
        foreach(var kvp in dict){
            if(kvp.Value.Count == 0){
                ans0.Add(kvp.Key);
            }
            if(kvp.Value.Count == 1){
                ans1.Add(kvp.Key);
            }
        }
        return new List<List<int>>{ans0, ans1};
    }
    
    static bool HasCommonAncestor(List<int[]> pairs, int a, int b){
        var dict = new Dictionary<int, List<int>>();
        int n = pairs.Count;
        for(var i= 0; i < n; i++){
            int p = pairs[i][0], c = pairs[i][1];
            if(!dict.ContainsKey(p)){
                dict[p] = new List<int>();
            }
            if(!dict.ContainsKey(c)){
                dict[c] = new List<int>();
            }
            dict[c].Add(p);
        }
        
        var ans1 = GetAncestor(dict, a);
        var ans2 = GetAncestor(dict, b);
        
        foreach(var ancestor in ans1){
            if(ans2.Contains(ancestor))
                return true;
        }
        return false;
    }
    
    // O(n)
    static HashSet<int> GetAncestor(Dictionary<int, List<int>> graph, int a){
        var q = new Queue<int>();
        q.Enqueue(a);
        var ans = new HashSet<int>();
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(ans.Contains(cur))
                continue;
            ans.Add(cur);
            
            foreach(var next in graph[cur]){
                q.Enqueue(next);
            }
        }
        ans.Remove(a);
        return ans;
    }
}
