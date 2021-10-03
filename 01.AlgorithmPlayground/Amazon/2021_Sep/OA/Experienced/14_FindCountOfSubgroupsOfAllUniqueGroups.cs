using System;
using System.Collections.Generic;
using System.Text;

//https://www.1point3acres.com/bbs/thread-803925-1-1.html
public class AmazonOA_14_FindCountOfSubarrayOfAllUniqueDecreasingSubarray {
    public void Test(){
        int[] arr;
        Console.WriteLine("Count of Subarray of unique decreasing subarray of an array:");
        arr = new int[]{4,3,5,4,3};
        Console.WriteLine($"[{string.Join(',', arr)}] -> {CountOfSubarrayOfUniqueDescreasingSubarray(arr)}");   
        arr = new int[]{5,4,3,5,4,3};
        Console.WriteLine($"[{string.Join(',', arr)}] -> {CountOfSubarrayOfUniqueDescreasingSubarray(arr)}");    
        arr = new int[]{1,1,1};
        Console.WriteLine($"[{string.Join(',', arr)}] -> {CountOfSubarrayOfUniqueDescreasingSubarray(arr)}"); 
    }

    public int CountOfSubarrayOfUniqueDescreasingSubarray(int[] arr) {
        int ans = 0, cur = 0, curCnt = 1, n = arr.Length, prev = int.MaxValue;
        var hs = new HashSet<string>();
        var sb = new StringBuilder();
        
        for (var i = 0; i < n; i++) {
            if(arr[i] < prev){
                sb.Append(arr[i]);
                prev = arr[i];
                cur += curCnt++;
            }
            else{
                var str = sb.ToString();
                if(hs.Contains(str))
                    continue;
                hs.Add(str);
                ans += cur;
                cur = 1;
                curCnt = 2;
                prev = arr[i];
                sb.Clear();
                sb.Append(arr[i]);
            }
        }
        
        if(!hs.Contains(sb.ToString())){
            ans += cur;
        }


        return ans;
    }
}