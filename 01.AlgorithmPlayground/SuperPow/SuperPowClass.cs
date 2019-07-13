namespace AlgorithmPlayground{
    public class SuperPowClass{
        public SuperPowClass(){
            var a = 2147483647;
            var b = new int[]{2, 0, 0};
            var result = SuperPow(a, b);
        }
        private int mod = 1337;
        public int SuperPow(int a, int[] b) {
            if(b.Length == 0) return 1;
            var lastNum = b[b.Length - 1];
            var newb = new int[b.Length - 1];
            for(var i = 0; i < newb.Length; i++){
                newb[i] = b[i];
            }
            return (PowMod(SuperPow(a, newb), 10) * PowMod(a, lastNum)) % mod;
        }
    
        private int PowMod(int a, int b){
            int result = 1;
            a %= mod;
            for(var i = 0; i < b; i++){
                result = (result * a) % mod;
            }
            return result;
        }
    }
}