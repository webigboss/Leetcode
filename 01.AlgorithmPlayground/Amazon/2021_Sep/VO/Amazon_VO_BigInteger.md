BigInteger is an object that represents arbitrarily large numbers. BigIntegers can be larger than any number 
a primitive can represent (i.e. long). BigInteger has disappeared from our library 
and I need you to implement a replacement. Through your implementation, I should be able to: 

  * Construct a BigInteger object
  * Add two BigIntegers and get back a new BigInteger that represents the result of the summation
  * Negative numbers are not supported

"100" + "110" => "210"
can there any speciacl char in the string? No - only consider valid interger


public class BigInteger{
    public string strNum = string.Empty;
    public BigInteger(string strNumber) {
        this.strNum = strNumber;
    }
    
    // Time: O(n+m), Space: O(n+m)
    public BigInteger Add(BitInteger bigInteger) {
        var num1 = this.strNum; // "001"
        var num2 = bigInteger.strNum; //"09"
        var result = string.Empty;
        int i = num1.Length-1, j = num2.Length-1, adv = 0;
        while(i >= 0 || j >= 0) { // i = -1, j = -1; adv = 0
        //result = '010'
            int curNum;
            if(i < 0) {
                curNum = num2[j] - '0' + adv; 
                j--;
            }
            else if(j < 0){
                curNum = num1[i] - '0' + adv;
                i--;
            }
            else {
                curNum = num1[i] - '0' + num2[j] - '0' + adv; // num1[i] = '1', num2[j] = '1'
                i--;
                j--;
            }
            //curNum = 0
            result = (char)('0' + curNum % 10) + result;
            adv = curNum / 10;
        }
        
        if(adv > 0){
            result = (char)('0' + adv) + result;
        }
        
        //remove heading zeros
        var sb = new StringBuilder();
        foreach(var c in result){
            if(c == '0'){
                continue;
            }
            sb.Append(c);
        }
        
        return new BigInt(sb.ToString());
    }
    
    public BigInteger Print(BitInteger bigInt){
        var cur = this.Head
        var sb
        while(cur != null){
            if()
        }
    }
}
