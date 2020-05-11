public class Solution {
    public int MaxDiff(int num) {
        var arrMax = num.ToString().ToCharArray();
        var l = arrMax.Length;
        var arrMin = new char[l];
        Array.Copy(arrMax, arrMin, arrMax.Length);
        
        char temp = '\0';
        for(var i = 0; i < l; ++i){
            if(temp == '\0' && arrMax[i] != '9'){
                temp = arrMax[i];
                arrMax[i] = '9';
            }
            if(temp != '\0' && arrMax[i] == temp){
                arrMax[i] = '9';
            }
        }
        Console.WriteLine("arrMax:" + new string(arrMax));
        temp = '\0';
        char tempTo = '\0';
        for(var i = 0; i<l; ++i){
            
            if(temp == '\0' && arrMin[i] != '1' && arrMin[i] != '0'){
                temp = arrMin[i];
                if(i == 0)
                    arrMin[i] = '1';
                else
                    arrMin[i] = '0';
                tempTo = arrMin[i];
            }
            
            if(temp != '\0' && arrMin[i] == temp){
                arrMin[i] = tempTo;
            }
        }
        Console.WriteLine("arrMin:" + new string(arrMin));
        return int.Parse(new string(arrMax)) - int.Parse(new string(arrMin));
    }
}