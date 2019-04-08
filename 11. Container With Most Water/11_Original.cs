public class Solution {
    public int MaxArea(int[] height) {
        if(height == null || height.Count() == 0)
            return 0;
        var maxVolume = 0;
        var tempVolume = 0;
        var li = 0;
        var ri = height.Length - 1;
        while(li < ri){
            maxVolume = Math.Max((ri - li) * Math.Min(height[li], height[ri]), maxVolume);
            if(height[li] < height[ri])
                li++;
            else //height[li] >= height[ri]
                ri--;
        }
        return maxVolume;
    }
}