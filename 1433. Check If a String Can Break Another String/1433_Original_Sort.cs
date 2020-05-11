public class Solution {
    public bool CheckIfCanBreak(string s1, string s2) {
        var arr1 = s1.ToCharArray();
        var arr2 = s2.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        
        //Console.WriteLine(new string(arr1));
        //Console.WriteLine(new string(arr2));
        //check if s1 can break s2
        var l = arr1.Length;
        var ans1 = true;
        var ans2 = true;
        for(var i = 0; i < l; ++i){
            if(arr1[i] - arr2[i] < 0)
                ans1 = false;
            if(arr2[i] - arr1[i] < 0)
                ans2 = false;
            if(!ans1 && !ans2)
                return false;
        }
        return true;
    }
    
    
}