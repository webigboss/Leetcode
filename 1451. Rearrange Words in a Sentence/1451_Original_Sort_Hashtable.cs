public class Solution {
    public string ArrangeWords(string text) {
        var arr = text.Split(' ');
        var dict = new Dictionary<int, List<string>>();
        for(var i = 0; i < arr.Length; ++i){
            if(!dict.ContainsKey(arr[i].Length))
                dict[arr[i].Length] = new List<string>();
            dict[arr[i].Length].Add(arr[i]);
        }
        
        var arrKvp = dict.ToArray();
        Array.Sort(arrKvp, (a, b) => a.Key - b.Key);
        
        var list = new List<string>();
        for(var i = 0; i < arrKvp.Length; ++i){
            if(i == 0){
                var temp = arrKvp[i].Value[0].ToCharArray();
                if(temp[0] >= 97){
                    temp[0] = (char)(temp[0] - 32);
                }
                arrKvp[i].Value[0] = new string(temp);
            }
            else{
                if(arrKvp[i].Value[0][0] <= 90){
                    var temp = arrKvp[i].Value[0].ToCharArray();
                    temp[0] = (char)(temp[0] + 32);
                    arrKvp[i].Value[0] = new string(temp);
                }
            }
            list.Add(string.Join(" ", arrKvp[i].Value));
        }
        return string.Join(" ", list);
    }
}