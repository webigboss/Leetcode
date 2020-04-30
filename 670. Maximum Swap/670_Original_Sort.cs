public class Solution {
    public int MaximumSwap(int num) {
        var str = num.ToString().ToCharArray();
        var arr = num.ToString().ToCharArray();
        Array.Sort(arr, (a,b) => b-a);
        char temp = '\0';
        int ifrom, ito;
        ifrom = ito = 0;
        for(var i = 0; i < str.Length; ++i){
            if(temp == '\0' && str[i] != arr[i]){
                ifrom = i;
                temp = arr[i];
            }
            
            if(temp != '\0' && str[i] == temp){
                ito = i;
            }
        }
        
        var t = str[ifrom];
        str[ifrom] = str[ito];
        str[ito] = t;
        
        var newNum = new string(str);
        return int.Parse(newNum);
    }
}