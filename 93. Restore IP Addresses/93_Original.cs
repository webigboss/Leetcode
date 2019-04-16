public class Solution {
    public IList<string> RestoreIpAddresses(string s) { var result = new List<string>();
        RestoreIpAddressBacktracking(s, 0, string.Empty, result);
        return result;
    }
    
    private void RestoreIpAddressBacktracking(string remain, int count, string ip, IList<string> result) {
        if(count > 4)
           return;
        if(count < 4 && remain == string.Empty)
            return;
        if(count == 4 && remain == string.Empty){
            result.Add(ip);
            return;
        }
        for(var i = 1; i <= Math.Min(remain.Length, 3); i++){
            var tempIp = remain.Substring(0, i);
            if(int.Parse(tempIp) > 255 || (tempIp.StartsWith('0') && i > 1))
                continue;
            RestoreIpAddressBacktracking(remain.Substring(i, remain.Length - i), count + 1, ip == string.Empty ? tempIp : ip + "." + tempIp, result);
        }
    }
}
