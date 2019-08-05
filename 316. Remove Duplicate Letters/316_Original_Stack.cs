public class Solution {
    public string RemoveDuplicateLetters(string s) {
        //stack approach
        var st = new Stack<char>();
        var inStack = new bool[26];
        var letterCount = new int[26];
        foreach(var c in s)
            letterCount[c - 'a']++;
        
        for(var i = 0; i < s.Length; i++){
            var index = s[i] - 'a';
            letterCount[index]--;
            //if letter is already in the stack, skip this letter;
            if(inStack[index]) continue;
            //if cur letter is less than the letter on the top of stack and top letter remainings in the letterCount array is greater than 0, then keep poping up the top letter, and update bool array of this letter to false
            while(st.Count > 0 && s[i] < st.Peek() && letterCount[st.Peek() - 'a'] > 0){
                var top = st.Pop();
                inStack[top - 'a'] = false;
            }
            // if cur letter is greater or equal to top letter in the stack and it's not in the stack, push into the stack
            st.Push(s[i]);
            inStack[index] = true; 
        }
        
        var result = string.Empty;
        while(st.Count > 0){
            result = st.Pop() + result;
        }
        return result;
    }
}