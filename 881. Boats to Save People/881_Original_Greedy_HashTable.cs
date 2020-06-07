public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        var dict = new Dictionary<int, int>();
        int n = people.Length, ans = 0, cnt = people.Length;
        for(var i = 0; i < n; ++i){
            if(!dict.ContainsKey(people[i]))
                dict[people[i]] = 1;
            else
                dict[people[i]]++;
        }

        for(var j = 0; j < n; ++j){
            var key = people[j];
            if(dict[key] == 0) 
                continue;
            for(var i = limit - key; i > 0; --i){
                if(dict.ContainsKey(i) && (i != key && dict[i] > 0 || i == key && dict[i] > 1)){
                    dict[i]--;
                    cnt--;
                    // Console.WriteLine($"dict[{i}]-- to:{dict[i]}, cnt-- to :{cnt}");
                    break;
                }
            }
            dict[key]--;
            cnt--;
            // Console.WriteLine($"dict[key:{key}]-- to:{dict[key]}, cnt-- to :{cnt}");
            
            ans++;
            if(cnt == 0)
                break;
        }
        return ans;
    }
}