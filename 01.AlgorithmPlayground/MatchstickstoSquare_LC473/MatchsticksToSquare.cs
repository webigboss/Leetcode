
namespace AlgorithmPlayground
{
    public class MatchsticksToSquare
    {
        public MatchsticksToSquare()
        {
            var nums = new[] { 1, 1, 2, 2, 2 };
            var result = Makesquare(nums);
        }
        public bool Makesquare(int[] nums)
        {
            if (nums == null || nums.Length == 0) return false;
            var sum = 0;
            foreach (var n in nums)
                sum += n;
            if (sum % 4 != 0) return false;
            return DfsHelper(nums, 0, new int[4], sum / 4);
        }

        private bool DfsHelper(int[] nums, int i, int[] lengths, int target)
        {
            if (i == nums.Length)
            {
                if (lengths[0] == target && lengths[1] == target && lengths[2] == target)
                    return true;
                else
                    return false;
            }

            for (var j = 0; j < lengths.Length; j++)
            {
                if (lengths[j] + nums[i] > target) continue;
                lengths[j] += nums[i];
                if (DfsHelper(nums, i + 1, lengths, target))
                    return true;
                lengths[j] -= nums[i];
            }
            return false;
        }
    }
}