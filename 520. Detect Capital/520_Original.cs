public class Solution {
    public bool DetectCapitalUse(string word) {
        //1. All UpperCase, 2. all lower case, 3. fist letter Uppercase, 
        bool case1, case2, case3;
        case1 = case2 = case3 = true;
        for(var i = 0; i < word.Length; ++i){
            if(!case1 && !case2 && !case3) return false;
            if(i == 0){
                if(word[i] >= 97) { //a
                    case1 = false;
                    case3 = false;
                }
                else 
                    case2 = false;
            }
            else{
                if(word[i] >= 97){ //a
                    case1 = false;
                }
                else{
                    case2 = false;
                    case3 = false;
                }
            }
        }
        return case1 || case2 || case3;
    }
}