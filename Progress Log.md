# Progress Log

#|Title|Difficulty|Solved Date|Resolved Independently?|Original Solution|Other Solution Accepted|Revisite Date|Different Solution Follow-up
---|---|---|---|---|---|---|---|---
102|Binary Tree Level Order Traversal|Medium|3/23/2019|No|Level Order traversal (Recursion) O(n^2)||4/5/2019|Level Order Traversal by Queue, Time complexity is O(n)
107|Binary Tree Level Order Traversal II|Medium|3/23/2019|No|Level Order traversal (Recursion) O(n^2)|||
||||||||
110|Balanced Binary Tree|Easy|3/25/2019|Yes|Recursion+Binary Search|||
111|Minimum Depth of Binary Tree|Easy|3/26/2019|Yes|Recursion|||
112|Path Sum|Easy|3/27/2019|Yes|Recursion|||
94|Binary Tree Inorder Traversal|Medium|3/27/2019|Yes|Recursion|Interation||Morris Traversal
96|Unique Binary Search Trees|Medium|3/28/2019|No||||
95|Unique Binary Search Trees II|Medium|3/28/2019|No||||
98|Validate Binary Search Tree|Easy|3/29/2019|Yes|Inorder traversal|||
113|Path Sum II|Medium|3/30/2019|Yes|Recursion(using List store data)|||Recursion(using linked list)
99|Recover Binary Search Tree|Hard|3/30/2019|Yes|Recursion(twice)|||"1.Can it be solved with one recursive call?2.Morris Traversal"
103|Binary Tree Zigzag Level Order Traversal|Medium|3/31/2019|Yes|Recursion|||
105|Construct Binary Tree from Preorder and Inorder Traversal|Medium|3/31/2019|Inspired only by idea(developed code independently)|Recursion|||need to improve time, now only 14% faster than other; check 106, use Hashtable and indexes instead of Array.IndexOf() and Array.Copy
106|Construct Binary Tree from Inorder and Postorder Traversal|Medium|3/31/2019|Inspired only by idea(developed code independently)|Recursion|||
114|Flatten Binary Tree to Linked List|Medium|4/1/2019|Yes|Preorder traversal (Recursion)|||
129|Sum Root to Leaf Numbers|Medium|4/1/2019|Yes|Preorder traversal (Recursion)|||
144|Binary Tree Postorder Traversal|Medium|4/2/2019|Yes|Recursion / Iteration|||
145|Binary Tree Postorder Traversal|Hard|4/2/2019|No|Recursion / Iteration|||
226|Invert Binary Tree|Easy|4/3/2019|Yes|Recursion|||
116|Populating Next Right Pointers in Each Node|Medium|4/3/2019|Yes|Level Order Traversal + Recursion|||O(n^2), need to see if it's doable at O(n)
117|Populating Next Right Pointers in Each Node II|Medium|4/3/2019|Yes|Level Order Traversal + Recursion|||exact same solution as 116, need to find alternative solutions
173|Binary Search Tree Iterator|Medium|4/4/2019|Yes|Inorder traversal (Interative)|||
199|Binary Tree Right Side View|Medium|4/4/2019|Yes|Level Order traversal (Recursion)|||not too fast, need to explore other solutions
222|Count Complete Tree Nodes|Medium|4/5/2019|Yes|Recursion O(n) / Binary Search O(log(n)^2)|||need to check  the iterative binary search
11|Container With Most Water|Medium|4/6/2019|No|Two Pointers alike (not based on sorting array actually, just have two pointers)|||
12|Integer to Roman|Medium|4/6/2019|Yes|Specific to problem|||
17|Letter Combinations of a Phone Number|Medium|4/7/2019|No|recursion|||
18|4Sum|Medium|4/7/2019|No|2sum and 3sum |||
39|Combination Sum|Medium|4/8/2019|No|Backtracking|||
31|Next Permutation|Medium|4/8/2019|Inspired only by idea(developed code independently)|Specific to problem|||No need to use Array.Sort, because it is really a reverse of all the elements is needed. Explore backtracking solution at [here](https://leetcode.com/problems/combination-sum/discuss/16502/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partitioning))
46|Permutations|Medium|4/9/2019|Yes|Backtracking|||
47|Permutations II|Medium|4/9/2019|Yes|Backtracking||4/11/2019|only faster than 20%, need to think of a way to get rid of usedIndexes, refer to other's solution could use a bool array. 4/11/2019: rewrite the solution with bool[] to mark the used element
40|Combination Sum II|Medium|4/10/2019|Yes|Backtracking|||
22|Generate Parentheses|Medium|4/10/2019|Yes|Backtracking|||this problem is leveled my understanding of backtracking
60|Permutation Sequence|Medium|4/11/2019|Yes|Backtracking/Specific calculation|||backtracking is not suitable for this problem in terms of time
77|Combinations|Medium|4/12/2019|Yes|Backtracking|||
78|Subsets|Medium|4/12/2019|Yes|Backtracking|||
89|Gray Code|Medium|4/12/2019|yes|Backtracking/Specific calculation|||follow up with other speficic calculate at [here](https://zh.wikipedia.org/wiki/%E6%A0%BC%E9%9B%B7%E7%A0%81)
79|Word Search|Medium|4/13/2019|Yes|Backtracking|||time and space is horrible, need to improve
90|Subsets II|Medium|4/13/2019|Yes|Backtracking|||
93|Restore IP Addresses|Medium|4/15/2019|Yes|Backtracking|||
131|Palindrome Partitioning|Medium|4/15/2019|Inspired only by idea(developed code independently)|Backtracking|||I think my solution is shorter than the answer with highest votes
33|Search in Rotated Sorted Array|Medium|4/17/2019|Inspired only by idea(developed code independently)|Binary Search|||time complexity O(log(n))
81|Search in Rotated Sorted Array II|Medium|4/17/2019|Inspired only by idea(developed code independently)|Binary Search|||time complexity O(log(n)), worst case O(n)
34|Find First and Last Position of Element in Sorted Array|Medium|4/17/2019|Yes|Binary Search|||
50|Pow(x, n)|Medium|4/17/2019|Yes|Binary Search|||
153|Find Minimum in Rotated Sorted Array|Medium|4/18/2019|Yes|Binary Search|||
162|Find Peak Element|Medium|4/18/2019|Yes|Binary Search|||
74|Search a 2D Matrix|Medium|4/19/2019|Yes|Binary Search|||time complexity is O(log(n)+log(m)), better than conceptually map the matrix to a 1 dimension array and do the binary search has time complexity O(log(n*m))
240|Search a 2D Matrix II|Medium|4/19/2019|No|Liner checking|||time complexity is O(n+m), not the optimal solution, check cracking the code interview 6th version chapter 10.9 for the binary search solution to archive logarithm time complexity
167|Two Sum II - Input array is sorted|Medium|4/20/2019|Inspired only by idea(developed code independently)|Two Pointers|||time complexity O(n), space complexity O(1), vs hashtable solution time complexity O(n), space complexity O(n), no better binary search solution found.
209|Minimum Size Subarray Sum|Medium|4/20/2019|No|Two Pointers alike (not based on sorting array actually, just have two pointers)|||Time complexity O(n), space complexity O(1). Worth of doing the O(nlog(n)) binary search solution to understand the idea of it
19|Remove Nth Node From End of List|Medium|4/21/2019|Yes|Specific to problem / Two Pointers alike|||one pass algorithm, Time complexity O(n), space complexity O(n), need to familiarize and finish the solution in solution section, they both have contant O(1) space complexity. Especially the one pass solution is brilliant.
61|Rotate List|Medium|4/21/2019|Yes|Two Pointers alike (not based on sorting array actually, just have two pointers)|||two pass algorithm, time complexity O(n), space complexity is constant O(1). Is there a one pass algorithm?
24|Swap Nodes in Pairs|Medium|4/22/2019|Yes|Two Pointers alike (not based on sorting array actually, just have two pointers)|||one pass algorithm, Time complexity O(n), space complexity O(1)
75|Sort Colors|Medium|4/22/2019|No|Counting Sort|||two pass algorithm, time complexity O(n), space complexity is constant O(1). There is a QuickSort solution which is O(nlog(n)) but is one pass: [here](https://leetcode.com/problems/sort-colors/discuss/26549/Java-solution-both-2-pass-and-1-pass)
80|Remove Duplicates from Sorted Array II|Medium|4/23/2019|Yes|Two Pointers alike (not based on sorting array actually, just have two pointers)|||
86|Partition List|Medium|4/24/2019|No|Two Pointers alike (not based on sorting array actually, just have two pointers)|||TC: O(n), SC: O(1)
48|Rotate Image|Medium|4/25/2019|No|Specific to problem|||