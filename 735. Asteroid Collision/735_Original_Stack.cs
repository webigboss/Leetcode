public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        //stack
        var st = new Stack<int>();
        
        for(var i = 0; i < asteroids.Length; ++i){
            var a = asteroids[i];
            //Console.WriteLine($"a->{a}");

            while(true){
                if(st.Count == 0){
                    st.Push(a);
                    //Console.WriteLine($"st.Push() -> {a}");
                    break;
                }
                var t = st.Peek();
                if(t < 0 || a > 0){
                    st.Push(a);
                    //Console.WriteLine($"st.Push() -> {a}");
                    break;
                }
                else {
                    if(Math.Abs(t) == Math.Abs(a)){
                        // Console.WriteLine($"Math.Abs({t}) == Math.Abs({a})");
                        st.Pop();
                        break;
                    }
                    else if(Math.Abs(t) < Math.Abs(a)){
                        // Console.WriteLine($"Math.Abs({t}) < Math.Abs({a})");
                        st.Pop();
                    }
                    else{
                        // Console.WriteLine($"Math.Abs({t}) > Math.Abs({a})");
                        break;
                    }
                }
            }
        }
        
        var ans = new List<int>();
        while(st.Count > 0)
            ans.Add(st.Pop());
        
        ans.Reverse();
        return ans.ToArray();
    }
}