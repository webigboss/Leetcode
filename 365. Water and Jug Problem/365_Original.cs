public class Solution {
    public bool CanMeasureWater(int x, int y, int z) {
        if(x + y < z) return false;
        
        if(x == z || y == z || x + y == z) return true;
        
        return z % Gcd(x, y) == 0;
    }
    
    //Euclidean algorith https://en.wikipedia.org/wiki/Euclidean_algorithm#Implementations
    private int Gcd(int a, int b){
        while(b != 0){
            int temp = b;
            b = a%b;
            a = temp;
        }
        return a;
    }
}