/*
// Definition for Employee.
class Employee {
    public int id;
    public int importance;
    public IList<int> subordinates;
}
*/

class Solution {
    public int GetImportance(IList<Employee> employees, int id) {
        //BFS appraoch
        var dict = new Dictionary<int, Employee>();
        foreach(var e in employees){
            if(!dict.ContainsKey(e.id))
                dict[e.id] = e;
        }
        if(!dict.ContainsKey(id)) return 0;
        var q = new Queue<int>();
        q.Enqueue(id);
        var ans = 0;
        while(q.Count > 0){
            var curId = q.Dequeue();
            ans += dict[curId].importance;
            foreach(var s in dict[curId].subordinates){
                q.Enqueue(s);
            }
        }
        return ans;
    }
}