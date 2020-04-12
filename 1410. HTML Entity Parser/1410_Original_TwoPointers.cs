public class Solution {
    public string EntityParser(string text) {
        //two pointers approach
        var i = 0; 
        var j = 0;
        var sb = new StringBuilder();
        var sbSp = new StringBuilder();
        var specialChars = new List<string>(){
            @"&quot;",@"&apos;",@"&amp;",@"&gt;",@"&lt;",@"&frasl;"
        };
        
        while(i < text.Length) {
            if(text[j] == '&') {
                //max length = 7
                var length = 0;
                sbSp.Clear();
                while(length <= 7 && j < text.Length){
                    sbSp.Append(text[j]);
                    j++;
                    if(specialChars.Contains(sbSp.ToString())){
                        sb.Append(Decode(sbSp.ToString()));
                        i = j;
                        break;
                    }
                    length++;
                }
            }
            else{
                if(i == text.Length) break;
                sb.Append(text[i]);
                i++;
                j = i;
            }

        }
        return sb.ToString();
    }
    
    private char Decode(string s){
        switch(s){
            case @"&quot;":
                return '\"';
            case @"&apos;":
                return '\'';
            case @"&amp;":
                return '&';
            case @"&gt;":
                return '>';
            case @"&lt;":
                return '<';
            default:
                return '/';
        }
    }
}