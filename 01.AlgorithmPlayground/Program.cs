using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var sodoku = new SudoKuSolver();
            //var quickSort = new QuickSort();
            //var superpow = new SuperPowClass();
            //var ksmall = new KSmallestPairsClass();
            //var wiggle = new WiggleSubsequenceClass();
            //var rndSetTest = new RandomSetTest();
            // var head = new ListNode(10);
            // head.next = new ListNode(1);
            // head.next.next = new ListNode(10);
            // head.next.next.next = new ListNode(20);
            // head.next.next.next.next = new ListNode(100);
            // var linkedListRandomNode = new LinkedListRandomNode(head);
            // var result = linkedListRandomNode.GetRandom();
            //var shuffleTest = new SuffleArrayTest();
            //var nthDigits = new NthDigit();
            // var findSubstring = new FindSubStringClass();
            // var wildcardmatching = new WildcardMatching();
            //var trapRainWater = new TrappingRainWater();
            // var s = string.Format("{0}:{1:D2}", 1, 2);
            //var summaryRangeTest = new SummaryRangesTest();
            //var rotateFunction = new RotateFunction();
            // var intergerReplacement = new IntegerReplacementClass();
            //var reconstructQueue = new QueueReconstruction();
            // var longestRepeatingCharReplace = new LongestRepeatingCharacterReplacement();
            // var constructQuadTree = new ConstructQuadTree();
            //var numberofSegment = new NumberofSegmentsInAString();
            //var pathSumIII = new PathSumIII();
            //var permutationInString = new PermutationinString();
            // var numberofBoomerangs = new NumberOfBoomerangsClass();
            // var serializeDeserializeBST = new SerializeandDeserializeBST();
            // var count = new FourSumII();
            // var pattern132 = new Pattern132();
            //var circularArrayLoop = new CircularArrayLoop();
            // var repeatedSubstringPattern = new RepeatedSubstringPatternClass();
            // var minMoves2 = new MinMovesII();
            // var canIWin = new CanIwinClass();
            // var substringinWraparoundString = new UniqueSubstringinWraparoundString();
            // var countNegatives = new CountNegatives();
            // var concatenatedWords = new ConcatenatedWords();
            // var wordbreak2 = new WordBreakII();
            // var matchsticksToSquare = new MatchsticksToSquare();
            // var smallestGoodBase = new SmallestGoodBaseClass();
            // var increasingSubsequences = new IncreasingSubsequences();
            // var zumaGame = new ZumaGame();
            // var topNBuzzWords = new TopNBuzzWords();
            // var topNBuzzWordsVar1 = new TopNBuzzWordsVar1();
            // var treasureIsland = new TreasureIsland();
            // var treasureIsland2 = new TreasureIsland2();
            // var optimalUtilization = new OptimalUtilization();
            // var minCostToConnectRopes = new MinCostToConnectRopes();
            // var minimumHours = new MinimumHours();
            // var numberofIslands = new NumberofIsLands();

            // var heap = new Heap<int>();
            // heap.Enqueue(4);
            // heap.Enqueue(7);
            // heap.Enqueue(12);
            // heap.Enqueue(2);
            // heap.Enqueue(1);
            // heap.Enqueue(7);
            // heap.Enqueue(5);
            // heap.Enqueue(3);
            // heap.Enqueue(9);
            // var list = new List<int>();
            // list.Add(heap.Dequeue());
            // list.Add(heap.Dequeue());
            // list.Add(heap.Dequeue());
            // list.Add(heap.Dequeue());
            // list.Add(heap.Dequeue());
            // list.Add(heap.Dequeue());
            // list.Add(heap.Dequeue());
            // list.Add(heap.Dequeue());
            // list.Add(heap.Dequeue());

            // var completeKnapsack = new CompleteKnapsack();
            // var zeroOneKnapsack = new ZeroOneKnapsack();
            // var coinChange = new CoinChange();
            //var findGroupsOfAnagrams = new FindGroupsOfAnagrams();
            // Console.ReadLine();
            //var beautifulArrangement = new BeautifulArrangement();
            // var minesweeper = new Minesweeper();
            // var fractionAddSubtract = new FractionAdditionandSubtraction();
            // var frogCroaking = new FrogCroaking();
            // var MaximumLengthofPairChain = new MaximumLengthofPairChain();
            // var magicDict = new MagicDictionary();
            // magicDict.BuildDict(new []{"hello", "leetcode"});
            // var result = magicDict.Search("hhllo");
            //  result = magicDict.Search("hell");
            // var validPalindrome = new ValidPalindromeII();
            // var repeatedStringMatch = new RepeatedStringMatch();
            var parentChildGraph = new ParentChildGraph();
            parentChildGraph.Test_GetNodesWithZeroOrOneParents();
            parentChildGraph.Test_HaveCommonAncestor();
            var courseSelecting = new CourseSelecting();
            courseSelecting.Test_SameCourceBetweenTwo();
        }
    }
}
