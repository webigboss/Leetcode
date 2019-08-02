using System.Collections.Generic;

namespace AlgorithmPlayground{

        public class SummaryRangesTest{
            public SummaryRangesTest(){
                var summaryRanges = new SummaryRanges();
                summaryRanges.AddNum(1);
                summaryRanges.AddNum(3);
                summaryRanges.AddNum(7);
                summaryRanges.AddNum(2);
                summaryRanges.AddNum(6);
                summaryRanges.AddNum(9);
                summaryRanges.AddNum(8);
                var intervals = summaryRanges.GetIntervals();
            }
        }
        public class SummaryRanges {

        /** Initialize your data structure here. */
        
        private SortedSet<int> intervals; 
        
        public SummaryRanges() {
            intervals = new SortedSet<int>();
        }
        
        public void AddNum(int val) {
            if(intervals.Contains(val)) return;
            intervals.Add(val);
        }
        
        public int[][] GetIntervals() {
            var arrIntervals = new List<int[]>();
            int pre = -2;
            int start = -2;
            foreach(var num in intervals){
                if(start == -2){
                    start = num;
                }
                else if(num > pre + 1){
                    arrIntervals.Add(new []{start, pre});
                    start = num;
                }
                pre = num;
            }
            arrIntervals.Add(new []{start, pre});

            return arrIntervals.ToArray();
        }
    }
}