public class Solution {
    public string[] FindWords(string[] words) {
        var hs1 = new HashSet<char>();
        var hs2 = new HashSet<char>();
        var hs3 = new HashSet<char>();
        var line1 = "qwertyuiop";
        var line2 = "asdfghjkl";
        var line3 = "zxcvbnm";
        var isInLine1 = true;
        var isInLine2 = true;
        var isInLine3 = true;
        var result = new List<string>();
        foreach(var c in line1) hs1.Add(c);
        foreach(var c in line2) hs2.Add(c);
        foreach(var c in line3) hs3.Add(c);
        
        for(var i = 0; i < words.Length; i++){
            isInLine1 = true;
            isInLine2 = true;
            isInLine3 = true;
            foreach(var c in words[i]){
                if(!isInLine1 && !isInLine2 && !isInLine3) break;
                //a~z 97-122 A-Z 65-90
                var temp = c;
                if(temp < 97)
                    temp = (char)(temp + 32);
                if(isInLine1){
                    if(!hs1.Contains(temp)) isInLine1 = false;
                }
                if(isInLine2){
                    if(!hs2.Contains(temp)) isInLine2 = false;
                }
                if(isInLine3){
                    if(!hs3.Contains(temp)) isInLine3 = false;
                }
            }
            if(isInLine1 || isInLine2 || isInLine3){
                result.Add(words[i]);
            }
        }
        return result.ToArray();
    }
}