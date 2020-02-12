using System;
using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class Pattern132
    {
        public Pattern132()
        {
            var nums = new[] { 6, 12, 4, 13, 5, 11 };
            var result = Find132pattern(nums);
        }
        public bool Find132pattern(int[] nums)
        {
            //official 4th solution: min array with stack
            if (nums.Length < 3) return false;
            var minArray = new int[nums.Length];
            minArray[0] = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                minArray[i] = Math.Min(minArray[i - 1], nums[i]);
            }

            var st = new Stack<int>();
            for (var j = nums.Length - 1; j >= 0; j--)
            {
                if (nums[j] > minArray[j])
                {
                    while (st.Count > 0 && st.Peek() <= minArray[j])
                        st.Pop();
                    if (st.Count > 0 && st.Peek() < nums[j])
                        return true;
                    st.Push(nums[j]);
                }
            }
            return false;
        }
    }
}