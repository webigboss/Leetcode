

namespace AlgorithmPlayground
{
    public class CircularArrayLoop
    {
        public CircularArrayLoop()
        {
            var nums = new []{-2, 1,-1,-2,-2};
            var result = CircularArrayLoopSolution(nums);
        }
        public bool CircularArrayLoopSolution(int[] nums)
        {
            var sp = 0;
            var fp = 0;
            var sp_pre = 0;
            var fp_pre = 0;
            var direction = 1; //1 for forward. -1 for backward
            var l = nums.Length;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    continue;
                sp = i;
                fp = i;
                direction = nums[i] > 0 ? 1 : -1;
                while (true)
                {
                    var failed = false;
                    var step = 1;
                    while (step > 0 && !failed)
                    {
                        if (direction * nums[sp] <= 0)
                        {
                            failed = true;
                            break;
                        }
                        sp_pre = sp;
                        sp = (sp + nums[sp]) % l;
                        if (sp < 0) sp += l;
                        if (sp == sp_pre)
                        {
                            failed = true;
                            break;
                        }
                        step--;
                    }
                    step = 2;
                    while (step > 0 && !failed)
                    {
                        if (direction * nums[fp] <= 0)
                        {
                            failed = true;
                            break;
                        }
                        fp_pre = fp;
                        fp = (fp + nums[fp]) % l;
                        if (fp < 0) fp += l;
                        if (fp == fp_pre)
                        {
                            failed = true;
                            break;
                        }

                        step--;
                    }
                    if(failed)
                    {
                        nums[i] = 0;
                        break;
                    }
                    if (sp == fp)
                        return true;
                }
            }
            return false;
        }
    }
}