public class Solution {
    private enum IPResult {
        IPv4,
        IPv6,
        Neither
    }
    public string ValidIPAddress(string IP) {
        var result = IPResult.Neither;
        var iDot = IP.IndexOf('.');
        var iColon = IP.IndexOf(':');
        if(iDot >= 0 && iColon < 0){
            if(ValidateIPv4(IP))
                result = IPResult.IPv4;
        }
        else if(iDot < 0 && iColon >= 0){
            if(ValidateIPv6(IP))
                result = IPResult.IPv6;
        }
        return result.ToString();
    }
    
    private bool ValidateIPv4(string IP){
        var isValid = true;
        var components = IP.Split('.');
        if(components.Length != 4) return false;
        foreach(var c in components){
            if(c.Length == 0 || c.Length > 3 || c.Length > 1 && c[0] == '0' || c == "-0") return false;
            
            if(int.TryParse(c, out var num)){
                if(num < 0 || num > 255) return false;
            }
            else return false;
        }
        return isValid;
    }
    
    private bool ValidateIPv6(string IP){
        var isValid = true;
        var components = IP.Split(":");
        if(components.Length != 8) return false;
        foreach(var c in components){
            if(string.IsNullOrEmpty(c) || c.Length > 4) return false;
            // if(c.Length > 1 && int.TryParse(c, out var num))
            //     if(num == 0) return false;
            for(var i = c.Length - 1; i >= 0; i--)
            {
                // if(c.Length - 1 - i >= 4) return false;
                if(c[i] >= '0' && c[i] <= '9' 
                   || c[i] >= 'a' && c[i] <= 'f' 
                   || c[i] >= 'A' && c[i] <= 'F')
                    continue;
                //if(c[i] >= 'a' && c[i] <= 'f') continue;
                //if(c[i] >= 'A' && c[i] <= 'F') continue;
                return false;
            }   
        }
        return isValid;
    }
}