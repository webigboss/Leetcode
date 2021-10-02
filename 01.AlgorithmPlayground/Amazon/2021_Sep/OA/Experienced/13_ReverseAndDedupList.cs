using System;
using System.Collections.Generic;

public class AmazonOA_13_ReverseAndDedupList {

    public void Test(){
        List<string> entries;
        entries = new List<string>{"a", "b", "d", "a", "c", "d"};
        Console.WriteLine($"[{string.Join(',', entries)}] -> [{string.Join(',', ReverseAndDedupList(entries))}]");
    }

    public List<string> ReverseAndDedupList(List<string> entries) {
        var ans = new List<string>();
        var hs = new HashSet<string>();
        int n = entries.Count;

        for(var i = n-1; i >=0; --i) {
            if(hs.Contains(entries[i])){
                continue;
            }
            hs.Add(entries[i]);
            ans.Add(entries[i]);
        } 
        return ans;
    }
}
