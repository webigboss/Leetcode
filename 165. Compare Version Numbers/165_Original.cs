public class Solution {
    public int CompareVersion(string version1, string version2) {
        var arrv1 = version1.Split('.');
        var arrv2 = version2.Split('.');
        string cur1, cur2;
        var i = 0;
        var result = 0;
        while(true){
            if(i > arrv1.Length - 1 && i > arrv2.Length - 1)
                break;
            cur1 = i < arrv1.Length ? arrv1[i] : "0";
            cur2 = i < arrv2.Length ? arrv2[i] : "0";
            if(int.Parse(cur1) > int.Parse(cur2)){
                result = 1;
                break;
            }
            else if(int.Parse(cur1) < int.Parse(cur2)){
                result = -1;
                break;
            }
            else
                i++;
        }
        
        return result;
    }
}