public class Solution {
    public string PushDominoes(string dominoes) {
        if(dominoes.Length == 1) return dominoes;
        var prev = dominoes[0];
        var iprev = 0;
        var arr = dominoes.ToCharArray();
        for(var i = 1; i < arr.Length; ++i){
            if(arr[i] == 'R'){
                if(prev == 'R')
                    Update(arr, iprev+1, i-1, 'R');
                prev = 'R';
                iprev = i;
            }
            if(arr[i] == 'L'){
                if(prev == '.' || prev == 'L')
                    Update(arr, iprev, i-1, 'L');
                if(prev == 'R'){
                    if((i-iprev-1) % 2 == 0){ //even
                        Update(arr, iprev+1, iprev+(i-iprev-1)/2, 'R');
                        Update(arr, i-(i-iprev-1)/2, i-1, 'L');
                    }
                    else{//odd
                        Update(arr, iprev+1, iprev+(i-iprev-2)/2, 'R');
                        Update(arr, i-(i-iprev-2)/2, i-1, 'L');
                    }
                }
                prev = 'L';
                iprev = i;
            }
            if(i == arr.Length - 1 && prev == 'R'){
                Update(arr, iprev+1, arr.Length-1, 'R');
            }
        }
        return new string(arr);
    }
    
    void Update(char[] arr, int ifrom, int ito, char c){
        if(ifrom > ito) return;
        for(var i = ifrom; i <= ito; ++i)    
            arr[i] = c;
    }
}