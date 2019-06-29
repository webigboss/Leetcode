public class Solution {
    public string ReverseVowels(string s) {
        if(string.IsNullOrWhiteSpace(s))
            return s;
        var left = 0;
        var right = s.Length - 1;
        var cArray = s.ToCharArray();
        char temp;
        while(true){
            while(left <= right && !IsVowel(cArray[left])) left++;
            while(right >= left && !IsVowel(cArray[right])) right--;
               
            if(left <= right && IsVowel(cArray[left]) && IsVowel(cArray[right])){
                temp = cArray[left];
                cArray[left] = cArray[right];
                cArray[right] = temp;
                left++;
                right--;
            }
            else break;
        }
        return new String(cArray);
    }
    
    private bool IsVowel(char c){
        return c =='a' || c == 'A' || c == 'e' || c == 'E' 
            || c == 'i' || c == 'I' || c == 'o' ||  c == 'O' || c == 'u' || c == 'U' ; 
    }
}