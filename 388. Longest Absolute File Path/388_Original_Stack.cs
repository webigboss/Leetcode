public class Solution {
    public int LengthLongestPath(string input) {
            var st = new Stack<int[]>();
            var result = 0;
            var names = input.Split('\n');
            st.Push(new int[]{0, -1});
            for(var i = 0; i < names.Length; i++){
                var level = GetLevel(names[i]);
                if(st.Peek()[1] >= level){
                    while(st.Peek()[1] >= level)
                        st.Pop();
                }
                var length = st.Peek()[1] == -1 ? 
                            names[i].Length : st.Peek()[0] + names[i].Length - level + 1;
                if(IsFileName(names[i])){
                    result = Math.Max(result, length);
                }
                else{
                    st.Push(new int[]{length, level});
                }
            }
            return result;
        }
        
        private bool IsFileName(string name){
            var index = name.LastIndexOf('.');
            return index > -1 && index != name.Length - 1;
        }
        
        private int GetLevel(string name){
            var count = 0;
            for(var i = 0; i < name.Length; i++){
                if(name[i] == '\t') count++;
                if(name[i] != '\t') break;
            }
            return count;
        }
    
}