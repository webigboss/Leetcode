using System;
using System.Collections.Generic;

// find the sum of the max difference between the max and min element in all subarray of an array
// e.g. array: [3,1,2,4], one subarray could be [3,1,2], max is 3, min is 1, difference is 3-1 = 2
// this is similar to LC 907
// using 2 monitonic stack to get the sum of all miminum element of an subarray
// using 2 monotonic stack to get the sum of all maximum element of an subarray
// answer is sum_Max - sum_Min
public class AmazonOA_11_MaxDifferenceOfNumbersInSubarray{
    public void Test() {
        int[] arr;
        arr = new int[]{3,1,2,4};
        Console.WriteLine($"MaxDifferenceOfNumbersInSubarray([{string.Join(',',arr)}]) - {MaxDifferenceOfNumbersInSubarray(arr)}");
    }

    public int MaxDifferenceOfNumbersInSubarray(int[] arr) {
        var sumMin = SumOfMinNumberInSubarray(arr);
        var sumMax = SumOfMaxNumberInSubarray(arr);
        Console.WriteLine($"sumMin={sumMin}; sumMax={sumMax}");
        return sumMax - sumMin;
    }
    public int SumOfMinNumberInSubarray(int[] arr) {
        int ans = 0, n = arr.Length;
        var stl = new Stack<int[]>();
        var str = new Stack<int[]>();
        var left = new int[n];
        var right = new int[n];
        for (int i = 0, j = n-1; i < n; ++i, --j){
            int cnt = 1, val = arr[i];
            while (stl.Count > 0 && val <= stl.Peek()[0] ) {
                cnt += stl.Pop()[1];
            }
            left[i] = cnt;
            stl.Push(new int[]{val, cnt});
            
            cnt = 1;
            val = arr[j];
            while(str.Count > 0 && val < str.Peek()[0]){
                cnt += str.Pop()[1];
            }
            right[j] = cnt;
            str.Push(new int[]{val, cnt});
        }

        for(var i = 0; i < n; ++i){
            ans += arr[i] * left[i] * right[i];
        }
        return ans;
    }

    public int SumOfMaxNumberInSubarray(int[] arr) {
        int ans = 0, n = arr.Length;
        var stl = new Stack<int[]>();
        var str = new Stack<int[]>();
        var left = new int[n];
        var right = new int[n];
        for(int i = 0, j = n-1; i < n; i++, j--) {
            int cnt = 1, val = arr[i];
            while(stl.Count > 0 && val >= stl.Peek()[1]){
                cnt += stl.Pop()[1];
            }
            left[i] = cnt;
            stl.Push(new int[]{val, cnt});

            cnt = 1; val = arr[j];
            while(str.Count > 0 && val > str.Peek()[1]){
                cnt += str.Pop()[1];
            }
            right[j] = cnt;
            str.Push(new int[]{val, cnt});
        }
        for(var i = 0; i < n; ++i) {
            ans += arr[i] * left[i] * right[i];
        }
        return ans;
    }
}