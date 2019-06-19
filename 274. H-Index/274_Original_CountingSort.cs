public class Solution {
    public int HIndex(int[] citations) {
        var h = 0;
        //var dict = new Dictionary<int, int>();
        // an array that holds the citation count, if a citation is bigger that the length of citations array, then count it as the length of citations, because a valid answer cannot be bigger than the length of the citations array
        var citationCount = new int[citations.Length];
        for(var i = 0 ; i < citations.Length; i++){
            if(citations[i] == 0)
                continue;
            if(citations[i] > citations.Length)
                citationCount[citationCount.Length - 1]++;
            else
                citationCount[citations[i] - 1]++;
        }
        
        for(var i = citationCount.Length - 2; i >= 0; i--)
            citationCount[i] += citationCount[i + 1];
        for(var i = citationCount.Length - 1; i >=0; i--){
            if(citationCount[i] >= i + 1){
                h = i + 1;
                break;
            }
        }
        
        return h;
    }
}