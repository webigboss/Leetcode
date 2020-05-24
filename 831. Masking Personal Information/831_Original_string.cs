public class Solution {
    public string MaskPII(string S) {
        if(Char.IsLetter(S[0])){
            return MaskEmail(S);
        }
        else
            return MaskPhone(S);
    }
    
    string MaskEmail(string s){
        var arr = s.ToLower().Split(new []{'.', '@'});
        var sb = new StringBuilder();
        for(var i = 0; i < arr.Length; ++i){
            if(i == 0)
                arr[i] = arr[i].Substring(0, 1) + new string('*', 5) + arr[i].Substring(arr[i].Length-1);
            sb.Append(arr[i]);
            if(i == 0)
                sb.Append('@');
            if(i == 1)
                sb.Append('.');
        }
        return sb.ToString();
    }
    
    string MaskPhone(string s){
        var nums = new List<char>();
        foreach(var c in s){
            if(Char.IsDigit(c))
                nums.Add(c);
        }
        var last = string.Empty;
        for(var i = nums.Count - 4; i < nums.Count; ++i)
            last += nums[i];
        
        if(nums.Count <= 10){
            return "***-***-" + last; 
        }
        else if(nums.Count == 11){
            return "+*-***-***-" + last;
        }
        else if(nums.Count == 12){
            return "+**-***-***-" + last;
        }
        else{
            return "+***-***-***-" + last;
        }
    }
}