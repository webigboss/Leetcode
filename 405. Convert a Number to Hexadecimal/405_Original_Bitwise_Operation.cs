public class Solution {
    public string ToHex(int num) {
        //bitwise shift operation approach
        if(num == 0) return "0";
        var unum = (uint)num;
        var hexChars = new []{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
        var list = new List<char>();
        var hex = string.Empty;
        while(unum != 0){
            list.Add(hexChars[unum & 15]);
            unum = unum >> 4;
        }
        list.Reverse();
        hex = string.Concat(list);
        return hex;
    }
}