public class Solution {
    public int Compress(char[] chars) {
        //2 pointers apporach
        if(chars.Length == 0) return 0;
        var iNew = 0; //index of the last element of the new array
        // var iCur = 0; //index of the current iteration cursor
        var count = 0;
        var prev = chars[0];
        for(var iCur = 0; iCur < chars.Length; iCur++){
            if(chars[iCur] == prev){
                count++;
            }
            else{
                chars[iNew] = prev;
                iNew++;
                if(count > 1){
                    var strCount = count.ToString();
                    foreach(var c in strCount){
                        chars[iNew] = c;
                        iNew++;
                    }
                }
                count = 1;
            }
            prev = chars[iCur];
            //spcaial case when iCur is the last element in chars
            if(iCur == chars.Length - 1){
                chars[iNew] = chars[iCur];
                iNew++;
                if(count > 1){
                    var strCount = count.ToString();
                    foreach(var c in strCount){
                        chars[iNew] = c;
                        iNew++;
                    }
                }
            }
        }

        
        return iNew;
    }
}