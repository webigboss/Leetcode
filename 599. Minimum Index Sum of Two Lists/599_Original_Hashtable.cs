public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        var dict = new Dictionary<string, int>();
        for(var i = 0; i < list1.Length; ++i)
            dict[list1[i]] = i;
        
        var result = new List<string>();
        var minIndexSum = int.MaxValue;
        
        for(var i = 0; i < list2.Length; ++i){
            if(dict.ContainsKey(list2[i])){
                if(dict[list2[i]] + i < minIndexSum){
                    result.Clear();
                    result.Add(list2[i]);
                    minIndexSum = dict[list2[i]] + i;
                }
                else if(dict[list2[i]] + i == minIndexSum)
                    result.Add(list2[i]);
            }
        }
        return result.ToArray();
    }
}