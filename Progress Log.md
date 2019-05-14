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
49|Group Anagrams|Medium|4/26/2019|No|Specific to problem|||
32|Longest Valid Parentheses|Hard|4/27/2019|No|Stack & DP|||TC: O(n), SC: O(n) for both Stack and DP solution
142|Linked List Cycle II|Medium|4/27/2019|Yes for HT, No for TP|Hashtable & Two Pointer|||Hashtable: TC: O(n), SC: O(n); Two Ponters: TC: O(n)?, SC: O(1)
23|Merge k Sorted Lists|Hard|4/28/2019|Inspired only by idea(developed code independently)|Specific to problem|||TC: O(nk), SC: O(1), k is the count of list array. My solution seems to be better than official solution 2. because save min value in a list so I can make sure one iterration will get all the nodes with min val, instead of interating min vals multiple times. Follow-up: check solution 3, under stand priority queue (heap)
55|Jump Game|Medium|4/28/2019|No|Backtracking & DP Top down & DP Buttom up & Greedy|||the solution article is brilliant
54|Spiral Matrix|Medium|4/29/2019|Yes|Specific to problem|||TC: O(n), SC: O(n)
56|Merge Intervals|Medium|4/29/2019|Yes|Bubble Sort|||TC: O(n^2), SC: O(1). Try other more efficient sorting algorithm. Like heapsort, quicksort, mergesort, etc.
59|Spiral Matrix II|Medium|4/30/2019|Yes|Specific to problem|||TC: O(n), SC: O(n)
62|Unique Paths|Medium|4/30/2019|No|Math & DP|||Math: O(n), SC O(1), DP: O(n^2), SC: O(n^2), DP solution can optimize the space complexity.
36|Valid Sudoku|Medium|5/1/2019|Yes|Hashtable|||
82|Remove Duplicates from Sorted List II|Medium|5/1/2019|Yes|3 Pointers|||TC: O(n), SC: O(1), one pass algorithm
206|Reverse Linked List|Easy|5/2/2019|Yes|Iteration & Recursion|||Iteration: TC: O(n), SC: O(1); Recursion: TC: O(n), SC: O(n)
92|Reverse Linked List II|Medium|5/2/2019|Yes|Iteration|||Iteration: TC: O(n), SC: O(1)
109|Convert Sorted List to Binary Search Tree|Medium|5/3/2019|Yes|Recursion|||TC: O(n), SC: O(n), same as official solution 2
138|Copy List with Random Pointer|Medium|5/3/2019|Yes|Hashtable|||TC: O(n), SC  O(n). There is a optimized solution which will archive SC O(1)
143|Reorder List|Medium|5/4/2019|Yes|covert to list|||TC: O(n), SC  O(n). There is a optimized solution which find the mid of the linkedlist first, reverse the sencond part and finally reorder the linked list. Without using list make its SC constant O(1)
147|Insertion Sort List|Medium|5/4/2019|Yes|Specific to problem|||TC: O(n), SC  O(1)
148|Sort List|Medium|5/5/2019|No|Merge Sort|||TC: O(nlog(n)), SC: O(log(n)), this problem asks for constant space complexiy, so optimal solution seems to be a bottom-up merge sort. Worth checking this [one](https://leetcode.com/problems/sort-list/discuss/239384/Java-Real-O(1)-space-No-recursion-only-iterative-merge-sort-with-full-comments)
160|Intersection of Two Linked Lists|Easy|5/6/2019|Yes for HT, No for TP|Hashtable & Two Pointer|||Hashtable: TC: O(m+n), SC: O(m) or O(n); Two Pointers: TC O(n+m), SC: O(1)
234|Palindrome Linked List|Easy|5/6/2019|Inspired only by idea(developed code independently)|Two Pointers|||TC: O(n); SC O(1)
237|Delete Node in a Linked List|Easy|2019/5/7|Yes|Specific to problem|||TC: O(n); SC: O(1), official solution is optimal that archives TC O(1)
63|Unique Paths II|Medium|2019/5/7|Yes|DP|||TC: O(m*n), SC: O(m*n), official solution doesn’t create a dp array but use the modify the obstacalGrid in place so it can archive SC O(1)
43|Multiply Strings|Medium|2019/5/8|No|Specific to problem, Math|||TC: O(m*n), SC: O(m+n)
64|Minimum Path Sum|Medium|2019/5/9|Yes|DP|||TC: O(m*n), SC: O(m*n), the dp 2D array could be ingored to use jagged array grid, to archive SC O(1)
71|Simplify Path|Medium|2019/5/9|Yes|Stack|||TC: O(n), SC: O(n)
73|Set Matrix Zeroes|Medium|2019/5/9|inspired only by idea(developed code independently)|In Place Algorithm|||TC: O(m*n), SC: O(1)
120|Triangle|Medium|5/10/2019|Yes|DP|||
123|Best Time to Buy and Sell Stock III|Hard|5/11/2019|No|DP & One Pass|||DP: O(k*n), SC: O(k*n); OnePass: TC: O(n), SC: O(1). The DP solution can be further optimized to SC: O(k)
152|Maximum Product Subarray|Medium|5/11/2019|No|DP|||TC: O(n), SC:O(1). Solution explaination [here](https://leetcode.com/problems/maximum-product-subarray/discuss/48230/Possibly-simplest-solution-with-O(n)-time-complexity/181239)
51|N-Queens|Hard|5/11/2019|Yes|Backtracking|||
52|N-Queens II|Hard|5/11/2019|Yes|Backtracking|||
169|Majority Element|Easy|2019-05-12|Yes|Sorting / Hashtable / Divide & Conquer|||Sorting: TC: O(nlogn), SC: O(1); Hashtable: TC: O(n), SC: O(n); Divide & Conquer: TC: O(nlogn), SC: O(logn)
189|Rotate Array|Easy|2019-05-12|Yes|Queue / Array / Reverse|||Queue & Array TC: O(n), SC: O(n); Reverse: TC: O(n), SC: O(1)
216|Combination Sum III|Medium|2019/5/13|Yes|Backtracking|||
8|String to Integer (atoi)|Medium|2019/5/13|Yes|Specific to problem|||