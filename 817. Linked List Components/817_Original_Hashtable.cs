public class Solution {
    public int NumComponents(ListNode head, int[] G) {
        var hs = new HashSet<int>();
        foreach(var g in G){
            hs.Add(g);
        }
        
        var ans = 0;
        var cur = head;
        var cnt = 0;
        while(cur != null){
            if(hs.Contains(cur.val)){
                if(cnt == 0) ans++;
                cnt++;
            }
            else{
                cnt = 0;
            }
            cur = cur.next;
        }
        return ans;
    }
}