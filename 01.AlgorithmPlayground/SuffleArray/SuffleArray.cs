using System;
using System.Collections.Generic;
namespace AlgorithmPlayground{

    public class SuffleArrayTest{
        public SuffleArrayTest(){
            var nums = new []{1,2,3};
            var suffle = new SuffleArray(nums);
            suffle.Shuffle();
            suffle.Reset();
            suffle.Shuffle();
        }
    }
    public class SuffleArray {

        private int[] arr;
        private int[] original;
        private Random rdn;
        public SuffleArray(int[] nums) {
            arr = nums;
            original = new int[nums.Length];
            for(var i = 0; i < nums.Length; i++)
                original[i] = nums[i];
            rdn = new Random();
        }
        
        /** Resets the array to its original configuration and return it. */
        public int[] Reset() {
            for(var i = 0; i < original.Length; i++)
                arr[i] = original[i];
            return arr;
        }
        
        /** Returns a random shuffling of the array. */
        public int[] Shuffle() {
            for(var i = 0; i < arr.Length; i++){
                var rndIndex = i + rdn.Next(arr.Length - i);
                Swap(arr, i, rndIndex);
            }
            return arr;
        }
        
        private void Swap(int[] nums, int i, int j){
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}