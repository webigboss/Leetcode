public class Solution {
    public int LongestMountain(int[] A) {
        //check contiguous ascending
        int j = 0, k = 0, ans = 0;
        var asc = new List<int[]>();
        var des = new List<int[]>();
        for(var i = 0; i < A.Length; ++i){
            if(i == A.Length - 1){
                if(i > j) asc.Add(new []{j, i});
                if(i > k) des.Add(new []{k, i});
                continue;
            }
            if(A[i+1] <= A[i] ) {
                if(i > j) {
                    asc.Add(new []{j, i});
                }
                j = i+1;
            }
            
            if(A[i+1] >= A[i]){
                if(i > k) {
                    des.Add(new []{k, i});
                }
                k = i+1;
            }
        }
        if(asc.Count == 0 || des.Count == 0) return 0;
//         foreach(var i in asc){
//             Console.Write("asc: ");
//             Console.Write($"[{i[0]},{i[1]}]");
//             Console.Write("\n");
//         }
        
//         foreach(var i in des){
//             Console.Write("des: ");
//             Console.Write($"[{i[0]},{i[1]}]");
//         }
        
        j = 0;
        for(var i = 0; i < asc.Count; ++i){
            while(j < des.Count-1 && des[j][0] < asc[i][1]) j++;
            if(des[j][0] == asc[i][1]) ans = Math.Max(ans, des[j][1] - asc[i][0] + 1);
        }
        return ans;
        


    }
}