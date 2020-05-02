class KthLargest {
    private PriorityQueue<Integer> minHeap;
    private int _k;
    public KthLargest(int k, int[] nums) {
        minHeap = new PriorityQueue<>(k);
        _k = k;
        for(int n: nums)
            add(n);
    }
    
    public int add(int val) {
        if(minHeap.size() < _k)
            minHeap.offer(val);
        else if(minHeap.peek() < val){
            minHeap.poll();    
            minHeap.offer(val);
        }
        return minHeap.peek();
    }
}
