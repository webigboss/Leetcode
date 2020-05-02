public class KthLargest {
    //qucik select appraoch, unlike priority queue, with time complexity: O(logk), here it's O(logn), which leads to TLE; 
    private List<int> list;
    private int K;
    private Random rdn;
    public KthLargest(int k, int[] nums) {
        list = new List<int>(nums);
        rdn = new Random();
        K = k;
    }
    
    public int Add(int val) {
        list.Add(val);
        return QuickSelect(list, 0, list.Count-1, K-1);
    }
    
    //slightly different, it's now find the Kth largest element, done in the parititon function
    private int QuickSelect(List<int> list, int l, int r, int K){
        var ipivot = l + rdn.Next(r - l + 1);
        var iPartition = Partition(list, l, r, ipivot);
        if(iPartition == K) return list[K];
        if(iPartition > K)
            return QuickSelect(list, l, iPartition - 1, K);
        else
            return QuickSelect(list, iPartition + 1, r, K);
    }
    
    private int Partition(List<int> list, int l, int r, int ipivot){
        var iPartition = l;
        Swap(list, r, ipivot);
        for(var i = l; i < r; ++i){
            if(list[i] > list[r]){
                Swap(list, i, iPartition);
                iPartition++;
            }
        }
        Swap(list, r, iPartition);
        return iPartition;
    }
    
    private void Swap(List<int> List, int i, int j){
        var temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
    
    
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */