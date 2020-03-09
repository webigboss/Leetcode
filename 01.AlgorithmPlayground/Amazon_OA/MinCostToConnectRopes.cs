using System.Linq;
using System.Collections.Generic;

namespace AlgorithmPlayground
{
    //https://leetcode.com/discuss/interview-question/344677
    public class MinCostToConnectRopes
    {

        public MinCostToConnectRopes()
        {
            var ropes = new[] { 8, 4, 6, 12 };
            var result = GetMinCost(ropes); //58
            ropes = new[] { 20, 4, 8, 2 };
            result = GetMinCost(ropes); //54
            ropes = new[] { 1, 2, 5, 10, 35, 89};
            result = GetMinCost(ropes); //224
            ropes = new[] { 2, 2, 3, 3 };
            result = GetMinCost(ropes); //20
        }

        //time complexity O(n^2logn), SC: O(n), if use Heap: time complexity reduce to O(nlogn)
        public int GetMinCost(int[] ropes)
        {
            var result = 0;
            var list = new List<int>();
            foreach (var r in ropes)
                list.Add(r);

            while (list.Count > 1)
            {
                list.Sort();
                //the time complexity of ElementAt for SortedSet is O(logn)
                var top1 = list[0];
                var top2 = list[1];
                result += top1 + top2;

                //the time complexity of Remove() for SortedSet is O(logn)
                list.RemoveAt(0);
                list.RemoveAt(0);
                list.Add(top1 + top2);
            }
            return result;
        }
    }
}