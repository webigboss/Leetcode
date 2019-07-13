using System.Collections.Generic;
using System;

namespace AlgorithmPlayground{
    public class KSmallestPairsClass {
        public KSmallestPairsClass(){
            Test();
        }
        public void Test(){
            var nums1 = new []{1,1,2};
            var nums2 = new []{1,2,3};
            var k = 3;
            var result = KSmallestPairs(nums1, nums2, k);
        }
        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
            //Priority Queue approach (c# doesn't have PQ natively so use sorted list as the alternatives)
            //Note: imagine a matrix like below and follow the steps defined in below iteration you will know why it's valid
            //      1   7   11 (nums1)
            //      
            var comparer = new AllowDuplicateComparer<int>();
            var sortedList = new SortedList<int, int[]>(comparer);
            var result = new List<IList<int>>();
            //1. add all [nums1[i],nums2[0]] to the list to get sorted
            for(var i = 0; i < nums1.Length; i++){
                sortedList.Add(nums1[i] + nums2[0], new []{nums1[i], nums2[0], 0});
            }
            
            
            //2. get k item from sorted list while adding new item to it
            var count = 0;
            while(sortedList.Count > 0 && count < k){
                var first = sortedList.Values[0];
                result.Add(new []{first[0], first[1]});
                count++;
                sortedList.RemoveAt(0);
                if(first[2] == nums2.Length - 1) continue;
                sortedList.Add(first[0] + nums2[first[2] + 1], new []{ first[0], nums2[first[2] + 1], first[2] + 1 });
            }
            return result;
        }
        
        public class AllowDuplicateComparer<T> : IComparer<T> {
            public int Compare(T a, T b){
                if(a is int){
                    if(Convert.ToInt32(a) <= Convert.ToInt32(b)) return -1;
                    return 1;
                }
                return -1;
            }
        }
    }      
}