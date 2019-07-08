using System;
using System.Collections.Generic;

namespace AlgorithmPlayground{
    public class QuickSort{
        public QuickSort(){
            var nums = new []{1,15,6,7,8,4,2,5,3,5,6,7,8,12,3,4,11,9,6,13,19,22,2,17};
            var nums1 = new []{1,15,6,7,8,4,2,5,3,5,6,7,8,12,3,4,11,9,6,13,19,22,2,17};
            QuickSortIterativeInPlace(nums);
            Array.Sort(nums1);
        }
        public static int[] QuickSortIterativeInPlace(int[] nums){
            int left = 0;
            int right = nums.Length - 1;
            int correctIndex;
            var rnd = new Random();
            var q = new Queue<int[]>();
            q.Enqueue(new int[]{left, right});
            while(q.Count > 0){
                var pair = q.Dequeue();
                left = pair[0];
                right = pair[1];
                if(left >= right) continue;

                var pivotIndex = left + (rnd.Next() % (right - left + 1));
                var pivotValue = nums[pivotIndex];
                Swap(nums, pivotIndex, right);
                correctIndex = left;
                for(var i = left; i < right; i++){
                    if(nums[i] < pivotValue) Swap(nums, i, correctIndex++);
                }
                Swap(nums, right, correctIndex);
                q.Enqueue(new int[]{left, correctIndex - 1});
                q.Enqueue(new int[]{correctIndex + 1, right});
            }
            return nums;
        }

        private static void Swap(int[] nums, int i, int j){
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}