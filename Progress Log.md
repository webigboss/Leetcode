# Progress Log

#|Title|Difficulty|Solved Date|Resolved Independently?|Original Solution|Other Solution Accepted|Revisite Date|Complexity Analysis and Notes|Solution summary
---|---|---|---|---|---|---|---|---|---
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
17|Letter Combinations of a Phone Number|Medium|2019/4/7|No|DFS(BackTracking) / BFS||2019/6/3|revisited with BFS solution, and then optimized Hashtable by string array
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
165|Compare Version Numbers|Medium|5/14/2019|Yes|Spefific to problem|||
168|Excel Sheet Column Title|Easy|5/14/2019|Yes|Math|||TC: O(k) k = n/26; SC: O(k)
171|Excel Sheet Column Number|Easy|5/14/2019|Yes|Math|||TC: O(n) n=s.Length; SC: O(1)
128|Longest Consecutive Sequence|Hard|5/15/2019|Yes for Sorting, Inspired for HT|HashTable / Sorting|||Sorting: TC: O(nlogn), SC: O(1); Hashtable: TC: O(n), SC: O(n)
155|Min Stack|Easy|5/15/2019|Yes for List|List / One Stack|||
154|Find Minimum in Rotated Sorted Array II|Hard|5/16/2019|Yes|Binary Search|||TC: O(log(n)) (average), O(n) (worst); SC: O(1)
217|Contains Duplicate|Easy|5/16/2019|Yes|Hashtable|||TC: O(n), SC: O(n); it can be solved by sorting too
219|Contains Duplicate II|Easy|5/16/2019|Yes|Hashtable|||TC: O(n), SC: O(n)
228|Summary Ranges|Medium|2019/5/17|Yes|One Pass|||TC: O(n), SC: O(n)
76|Minimum Window Substring|Hard|2019/5/18|Yes|Hashtable|||TC: O(n), SC: O(n); Bravo! Check this post for template summarization of the substring problem. [here](https://leetcode.com/problems/minimum-window-substring/discuss/26808/Here-is-a-10-line-template-that-can-solve-most-'substring'-problems)
139|Word Break|Medium|2019/5/18|No|DP|||TC: O(n^3), SC: O(n)
134|Gas Station|Medium|2019/5/19|Yes for the one with O(n^2)|One Pass|||Brutal: TC: O(n^2), SC: O(1); OnePass: TC: O(n), SC: O(1)
150|Evaluate Reverse Polish Notation|Medium|2019/5/19|Inspired only by idea(developed code independently)|Stack|||Left to Right: TC: O(n), SC: O(n). There is another Right to left solution which is less straight-forward. It failed at a test case which I didn't figure out the reason why. I added the code for it anyway
115|Distinct Subsequences|Hard|2019/5/20|Inspired only by idea(developed code independently)|DP|||TC: O(n*m), SC: O(n*m). Bravo! Think of the parrtern independently!
178|Rank Scores|Medium|2019/5/20|Yes|SQL|||
191|Number of 1 Bits|Easy|2019/5/21|Yes|Bit Manipulation|||
190|Reverse Bits|Easy|2019/5/21|Yes|Bit Manipulation|||there is a optimal solution that uses bitwise operation at [here](https://leetcode.com/problems/reverse-bits/discuss/54746/Java-Solution-and-Optimization)
133|Clone Graph|Medium|2019/5/22|Yes|Recursion & Hashtable|||TC: O(n), SC: O(n); this is essentially the Depth first search for graph theory, the recursion is equivalent of a stack structure, however to archive deep copy, stack data structure seems to be less straight-forward than implementing by recusion
151|Reverse Words in a String|Medium|2019/5/22|Yes|Stack|||TC: O(n), SC: O(n)
127|Word Ladder|Medium|2019/5/22|Inspired only by idea(developed code independently)|Breadth First Search(Graph)|||TC: O(n * m * n) or O(n * m) n: number of word, m: length of each word; SC: O(n * m)
130|Surrounded Regions|Medium|2019/5/23|Inspired only by idea(developed code independently)|BFS(Queue) & DFS(Recursion)|||TC: O(n * m); SC: O(n * m)
202|Happy Number|Easy|2019/5/23|Yes|Hashtable|||TC: O(n), SC: O(n)
198|House Robber|Easy|2019/5/23|Yes|DP|||TC: O(n), SC: O(n)
200|Number of Islands|Medium|2019/5/24|Yes|BFS(Queue) & DFS(Recursion)|||TC: O(n * m); SC: O(n * m)
257|Binary Tree Paths|Easy|2019/5/24|Yes|DFS(Binary Tree)|||TC: O(n), SC: O(n)
207|Course Schedule|Medium|2019/5/25|Inspired only by idea(developed code independently)|Topological Sort: DFS(Recursion+Stack); Kahn's algorithm|||DFS: TC: O(n+m), SC: O(n+m); Kahn: TC: O(n+m), SC: O(max(n, m)). n: length of numCourse, m: length of prerequisites
181|Employees Earning More Than Their Managers|Easy|2019/5/25|Yes|SQL|||
210|Course Schedule II|Medium|2019/5/26|Yes|Topological Sort: DFS(Recursion+Stack); Kahn's algorithm|||DFS: TC: O(n+m), SC: O(n+m); Kahn: TC: O(n+m), SC: O(max(n, m)). n: length of numCourse, m: length of prerequisites
176|Second Highest Salary|Easy|2019/5/26|Yes|SQL|||
175|Combine Two Tables|Easy|2019/5/26|Yes|SQL|||
177|Nth Highest Salary|Medium|2019/5/26|Yes|SQL|||
196|Delete Duplicate Emails|Easy|2019/5/27|Yes|SQL|||
126|Word Ladder II|Hard|2019/5/27|Yes|BFS+DFS(Backtracking)|||TC: O(n*m*n) or O(n*m)? n: number of word, m: length of each word; SC: O(n*m)
172|Factorial Trailing Zeroes|Easy|2019/5/28|No|Math|||TC: O(log5(n)), SC:O(log5(n))
279|Perfect Squares|Medium|2019/5/28|Yes|BFS|||TC: O(sqrt(n)), SC: O(sqrt(n)); there is also DP solutions
187|Repeated DNA Sequences|Medium|2019/5/28|Yes|Hashtable|||TC: O(n), SC: O(n); can optimize this solution by bit manipulation
204|Count Primes|Medium|2019/5/29|No|Specific to problem|||TC: O(nloglog n), SC: O(n) https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes#cite_note-intro-8
231|Power of Two|Easy|2019/5/29|Yes|Math|||TC: O(logn)?, SC: O(1). There are 4 different ways to solve Iterative&Recursive&Bit operation&Math 
201|Bitwise AND of Numbers Range|Medium|2019/5/31|Yes|Bit Manipulation|||TC: O(Min(n.length, m.length)); SC: O(1)
213|House Robber II|Medium|2019/5/31|Yes|DP|||TC: O(n), SC: O(n)
205|Isomorphic Strings|Easy|2019/6/1|Yes|Hashtable|||TC: O(n), SC: O(1); Although we do use extra space, the space complexity is O(1)O(1) because the table's size stays constant no matter how large n is.
215|Kth Largest Element in an Array|Medium|2019/6/1|Yes|Heapsort / Quickselect(20190630)||2019/6/30: quickselect recursion; 2019/07/03: quickselect interation in place|Heapsort: TC: O(nlogn), SC: O(1); Quickselect recursion: TC: O(n), SC: O(log(n))?; Quickselect in place: TC:O(n), SC:O(1). for quickselect approach, the partition scheme I used is Lomuto, there is another Hoare partition scheme which has improved worse case, but I also introduced a way to ramdomize the pivot, this will also improve the worse case of Lomuto partition.
242|Valid Anagram|Easy|2019/6/1|Yes|Hashtable|||TC: O(n), SC: O(1); Although we do use extra space, the space complexity is O(1)O(1) because the table's size stays constant no matter how large n is.
184|Department Highest Salary|Medium|2019/6/2|Yes|SQL|||
183|Customers Who Never Order|Easy|2019/6/2|Yes|SQL|||
179|Largest Number|Medium|2019/6/2|Yes|Heap Sort|||TC: O(nlogn), SC: O(1);
164|Maximum Gap|Hard|2019/6/3|Yes|Radix Sort|||TC: O(d(n+k)) = O(n); SC: O(n+k) = O(n)
180|Consecutive Numbers|Medium|2019/6/4|No|SQL|||
221|Maximal Square|Medium|2019/6/4|No|DP|||TC: O(n*m), SC: O(n*m), there is a optimal solution to reduce SC to O(n)
836|Rectangle Overlap|Easy|2019/6/4|Yes|Math|||TC: O(1), SC: O(1);
185|Department Top Three Salaries|Hard|2019/6/5|Yes|SQL|||
230|Kth Smallest Element in a BST|Medium|2019/6/5|Yes|Recursion / Iteration|||Recursion: TC: O(n), SC: O(n); Iteration: TC: O(H+k), SC: O(H+k). H: tree's height, k: for the kth element
229|Majority Element II|Medium|2019/6/6|Yes (Hashtable)|Hashtable / Boyer-Moore Majority vote|||Hashtable: TC:O(n), SC: O(n), Boyer-Moore Majority Vode: TC: O(n), SC: O(1)
235|Lowest Common Ancestor of a Binary Search Tree|Easy|2019/6/6|Yes|Iteration|||TC: O(n) (worst case, when BST is skewer, if the tree is balanced, then will be O(logn), SC: O(1); 
220|Contains Duplicate III|Medium|2019/6/8|No|SortedSet / Bucket Dict|||SortedList: TC: O(nlogk), SC: O(k); Bucket dict:TC: O(n), SC: O(k)
223|Rectangle Area|Medium|2019/6/8|No|Math|||TC: O(1), SC: O(1);
232|Implement Queue using Stacks|Easy|2019/6/8|Yes|Design|||TC: O(n)(Push), O(1)(Pop), SC: O(n); the alternative implementation for Pop by Amotrized is brilliant
241|Different Ways to Add Parentheses|Medium|2019/6/8|inspired only by idea(developed code independently)|Recursion (DFS alike)|||I tried to solve it by BFS but it doesn't quite fit for this problem because it will generate duplicates, but the code is still worth revisiting
225|Implement Stack using Queues|Easy|2019/6/9|Yes|Specific to problem|||Two Queue: TC: O(n)(Push), O(1)(Pop); One Queue: TC: O(n)(Push), O(1)(Pop)
238|Product of Array Except Self|Medium|2019/6/9|Inspired only by idea(developed code independently)|Specific to problem|||TC:O(n), SC: O(n); There is an optimal solution that with SC: O(1)
239|Sliding Window Maximum|Hard|2019/6/9|No|Deque|||TC:O(n^2), SC: O(n); the two pass linear solution is also worth checking: [here](https://leetcode.com/problems/sliding-window-maximum/discuss/65881/O(n)-solution-in-Java-with-two-simple-pass-in-the-array)
236|Lowest Common Ancestor of a Binary Tree|Medium|2019/6/10|Yes|DFS(Recursion)|||TC: O(n), SC: O(n); first time come up with a recursion with a return type, code is nice and tidy, bravo! there is iterative solution
258|Add Digits|Easy|2019/6/10|Yes|Math|||TC: linear O(k), SC: O(1); there is a O(1) solution 
263|Ugly Number|Easy|2019/6/11|Yes|Math|||
264|Ugly Number II|Medium|2019/6/11|No|DP|||TC: O(n), SC: O(n)
268|Missing Number|Easy|2019/6/12|Yes|Math|||TC: O(n), SC: O(1)
91|Decode Ways|Medium|2019/6/12|Yes|DP|||TC: O(n), SC: O(n)
41|First Missing Positive|Hard|2019/6/12|Yes for (SC: O(n))|Specific to problem|||Hashtable: TC: O(n), SC: O(n); Swap Numbers: TC:O(n), SC: O(1)
278|First Bad Version|Easy|2019/6/14|Yes|Binary Search|||TC: O(logn), SC: O(1)
227|Basic Calculator II|Medium|2019/6/14|No|Stack|||TC: O(n), SC: O(1)
283|Move Zeroes|Easy|2019/6/15|Yes|Specific to problem|||TC: O(n), SC: O(1)
290|Word Pattern|Easy|2019/6/15|Yes|HashTable|||TC: O(n), SC: O(n)
292|Nim Game|Easy|2019/6/16|Yes|Specific to problem|||TC: O(1), SC: O(1)
224|Basic Calculator|Hard|2019/6/17|No|Stack|||TC: O(n), SC: O(n)
326|Power of Three|Easy|2019/6/17|Yes|Math|||TC: O(log(sqrt(n)))?, SC: O(1)
146|LRU Cache|Medium|2019/6/18|Yes|Hashtable|||TC: Get: O(1), Put: O(n), SC: O(n); there is an solution use doubly linked list to archive O(1) for both get and put 
274|H-Index|Medium|2019/6/18|Yes|Sorting / Counting Sort|||Sorting: TC: O(nlogn), SC: O(1); Counting Sort: TC: O(n), SC: O(n)
275|H-Index II|Medium|2019/6/18|Yes|Logrithm pass|||TC: O(logn), SC: O(1)
287|Find the Duplicate Number|Medium|2019/6/19|No|Cycle detection/Sorting/Hashtable|||Cycle Detection: TC: O(n), SC: O(1);Sorting: TC: O(nlogn), SC: O(1); Hashtable: TC: O(n), SC: O(n) 
299|Bulls and Cows|Medium|2019/6/20|Yes|Specific to problem|||one pass or two pass: TC: O(n), SC: O(n)
289|Game of Life|Medium|2019/6/20|Yes|Specific to problem|||TC: O(n*m), SC: O(1)
300|Longest Increasing Subsequence|Medium|6/21/2019|No|Recursion with memorization / DP|||Recursion with memo: TC: O(n^2), SC: O(n^2)
303|Range Sum Query - Immutable|Easy|6/21/2019|No for DP|DP|||TC: O(n), SC: O(n)
304|Range Sum Query 2D - Immutable|Medium|6/22/2019|Yes (caching by row)|DP(caching by row / caching by area|||caching by row: TC: Query:O(m), pre-computation: O(n*m), SC: O(n*m); caching by area: TC: Query: O(1), pre-computation: O(n*m), SC: O(n*m)
306|Additive Number|Medium|6/22/2019|Yes|Backtracking||| 
307|Range Sum Query - Mutable|Medium|6/23/2019|Yes|DP|||DP: TC: query: O(1), update: O(n), pre-computation: O(n); SC: O(n). There are segment tree apporach which have logarithmic (logn) query time complexity.
310|Minimum Height Trees|Medium|6/25/2019|No|Specific to problem|||TC: O(n), SC: O(n)
309|Best Time to Buy and Sell Stock with Cooldown|Medium|6/25/2019|No|DP|||TC: O(n), SC: O(n), there is another way to design DP approach with 3 DP arrays, check [here](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/discuss/75928/Share-my-DP-solution-(By-State-Machine-Thinking))
313|Super Ugly Number|Medium|6/26/2019|Yes|DP|||TC:O(n*m), SC: O(n+m); n: nth ugly number, m: number of primes
319|Bulb Switcher|Medium|6/26/2019|No|Math|||TC: O(1), SC: O(1)
318|Maximum Product of Word Lengths|Medium|6/26/2019|No|Bit Manipulation|||TC: O(n*m), SC: O(n)
322|Coin Change|Medium|6/27/2019|Yes|DP (bottom up)||6/29/2019: improved the code by removed some unneccessary logic; implemented DP top down with memoization.|TC: O(n*m), SC: O(m); n: number of coins, m: amount. Bravo for figuring out DP deduce.
342|Power of Four|Easy|6/27/2019|Inspired only by idea(developed code independently)|Base Conversion|||Base Conversion: TC: O(log4(n)), SC: O(1);
328|Odd Even Linked List|Medium|6/27/2019|Yes|Specific to problem|||TC: O(n), SC: O(1)
344|Reverse String|Easy|6/28/2019|Yes|Specific to problem|||TC: O(n), SC: O(1)
312|Burst Balloons|Hard|6/28/2019|No|Divide and Conquer with Memo|||DC with memo: TC: O(n^2), SC: O(n^2)
345|Reverse Vowels of a String|Easy|6/28/2019|Yes|Two Pointers|||TC: O(n), SC: O(n) (created a char array)
324|Wiggle Sort II|Medium|6/29/2019|No|Sort|||TC: O(n) (assume FindKthLargest is O(n)), SC: O(n).  There is a in place optimal solution
347|Top K Frequent Elements|Medium|6/30/2019||HashTable / Sort|||TC: O(nlog(n)), SC: O(n), there is not native PriorityQueue implementation in C#, so the solution only works for Java
349|Intersection of Two Arrays|Easy|7/1/2019|Yes|Hashtable|||TC: O(n+m); SC: O(n+m)
343|Integer Break|Medium|7/1/2019|No|DP / Math|||DP: O(n^2), SC: O(n); DP optimized by Math: TC: O(n), SC: O(n)
350|Intersection of Two Arrays II|Easy|2019/7/2|Yes|Hashtable|||TC: O(n+m); SC: O(n+m)
337|House Robber III|Medium|2019/7/2|Yes|Dfs + Memoizaiton|||TC: O(2n) = O(n)?; SC: ? For TC: think about every node will be only calculated twice, one robbing, one for skipping 
341|Flatten Nested List Iterator|Medium|2019/7/5|Yes|Stack|||TC: HasNext(): O(n), Next(): O(1), SC: O(n)
338|Counting Bits|Medium|2019/7/5|Yes|Bit Manipulation + DP|||TC:O(n), SC: O(n)
357|Count Numbers with Unique Digits|Medium|7/5/2019|Yes|Backtracking / DP|||Backtracking: exponential; DP: TC:O(n), SC: O(n);
367|Valid Perfect Square|Easy|7/5/2019|Yes|Binary Search|||TC: O(logn), SC: O(1)
37|Sudoku Solver|Hard|7/6/2019|Yes|Backtracking|||TC: exponential, SC: O(1) since sudoku is constant 9*9.
331|Verify Preorder Serialization of a Binary Tree|Medium|7/7/2019|Yes|Stack|||TC:O(n), SC: O(n)
334|Increasing Triplet Subsequence|Medium|7/7/2019|Yes|Two Pass|||TC:O(n), SC: O(1)
208|Implement Trie (Prefix Tree)|Medium|7/8/2019|Inspired only by idea(developed code independently)|Trie|||TC: Insert, search, startwith: O(n), SC: O(m); n: count of characters of current word, m: count of total characters in the tree
211|Add and Search Word - Data structure design|Medium|7/8/2019|Yes|Trie+Recursion/Trie+Iterative+BFS|||TC: Insert, O(n), search: O(m); SC: O(m); n: count of characters of current word, m: count of total characters in the tree
377|Combination Sum IV|Medium|7/9/2019|Inspired only by idea(developed code independently)|Recursion / DP|||Recursion: TC: exponential; SC: exponential; DP: TC: O(n*m); SC: O(n); n: target, m: length of nums;
365|Water and Jug Problem|Medium|7/9/2019|No|Math|||TC: O(n), SC: O(1)
371|Sum of Two Integers|Easy|2019/7/10|Yes|Bit Manipulation|||TC: O(1), SC: O(1)
383|Ransom Note|Easy|2019/7/10|Yes|Hashtable|||TC:O(n), SC: O(n)
25|Reverse Nodes in k-Group|Hard|2019/7/11|Yes|Inplace reverse LinkedList|||TC: O(n), SC: O(1)
332|Reconstruct Itinerary|Medium|07/12/2019|Yes|DFS(Recursion)|||TC: exponential, SC: O(n), in problem is essentially a directed graph with more than 1 verticies at same direction, PriorityQueue can sort and track remaining vertices in one short, however c# doesn't have it, so I used dictionary of sortedset to sort verices,  and dictinary of int to count remaining vertices while during the DFS. alternitavely I can use sortedList to archive the same as PriorityQueue but with worse time complexity.  
372|SuperPow|Medium|7/12/2019|No|Math+Recursion|||TC:O(n), SC: O(n); n: b's length
373|Find K Pairs with Smallest Sums|Medium|7/13/2019|No|PriorityQueue(Heap)|||TC: O(n^2), SC: O(n); n:nums2's length; sortedList by default doesn't allow duplicated key. need to know how to use Icomparer to define comparer that allow duplicate key
387|First Unique Character in a String|Easy|2019/7/14|Yes|Hashtable|||TC: O(n), SC: O(n)
368|Largest Divisible Subset|Medium|2019/7/15|No|DP|||TC: O(n^2), SC: O(n)
375|Guess Number Higher or Lower II|Medium|07/16/2019|No|DP(Top Down)/DP(Bottom Up)|||DP(TopDown): TC: O(n^2), SC: O(n^2); DP(Bottom up): TC: O(n^3)?, SC: O(n^2)
376|Wiggle Subsequence|Medium|07/17/2019|Yes|DP|||TC: O(n), SC: O(n); check the solution section, it has better DP thoughts and greedy solution
378|Kth Smallest Element in a Sorted Matrix|Medium|2019/7/17|Yes|PriorityQueue(Heap)|||TC: O(n^2), SC: O(n); used SortedList to implement PriorityQueue as C# doesn't have native prorityqueue class, native PQ will have TC: O(nlogn), SC: O(n) 
389|Find the Difference|Easy|2019/7/18|Yes(hashtable)|Hashtable / Bit Manipulation|||Hashtable: TC: O(n), SC: O(n); BitManipulation: TC:O(n), SC: O(1)
390|Elimination Game|Medium|07/18/2019|No|Specific to Problem|||TC: O(n), SC: O(1)|1. have an int and keep updating it as the length of remaining numbers; 2. analysis case from left or from right, from left will always start from the first num, which will visit the first num, while from right, whether the left first num will be visited depends on odd/even of remaining element
380|Insert Delete GetRandom O(1)|Medium|07/19/2019|inspired only by idea(developed code independently)|Hashtable+ List Swap|||TC: O(1), SC: O(n)|1. using a list to calculcate the random fron Random(), but it’s length is determined by the dictionray, meaning any element exceeds the count of dict will not be considered as an element of this list, removing item by swaping item to list end;
374|Guess Number Higher or Lower|Easy|7/21/2019|Yes|Binary Search|||TC:O(logn), SC: O(1)|