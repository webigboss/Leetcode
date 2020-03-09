public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        var digitLogs = new List<string>();
        var letterLogs = new List<string[]>();
        int index = 0;
        for(var i = 0; i < logs.Length; ++i){
            index = 0;
            while(logs[i][index] != ' ') index++;
            if(char.IsDigit(logs[i][index + 1])){
                //digit log
                digitLogs.Add(logs[i]);
            }
            else{
                //letter log
                letterLogs.Add(new []{logs[i].Substring(0, index), logs[i].Substring(index + 1)});
            }
        }
        
        //sorting the letter logs
        letterLogs.Sort((a, b) => {
            var contentCompare = string.Compare(a[1], b[1]);
            if(contentCompare == 0){
                return string.Compare(a[0], b[0]);
            }
            else return contentCompare;
        });
        var result = letterLogs.Select(l => l[0] + ' ' + l[1]).ToList();
        result.AddRange(digitLogs);
        return result.ToArray();
    }
}