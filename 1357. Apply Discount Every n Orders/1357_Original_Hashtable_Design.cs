public class Cashier {

    private int _discount;
    private int _n;
    private int _cur;
    private Dictionary<int, int> _dictPrices;
    
    public Cashier(int n, int discount, int[] products, int[] prices) {
        _discount = discount;
        _n = n;
        _cur = 0;
        _dictPrices = new Dictionary<int, int>();
        
        for(var i = 0; i < products.Length; i++) {
            _dictPrices[products[i]] = prices[i];
        }
    }
    
    public double GetBill(int[] product, int[] amount) {
        double cost = 0;
        for(var i = 0; i < product.Length; i++){
            cost += _dictPrices[product[i]] * amount[i];
        }
        
        if(_cur + 1 == _n){
            cost -= cost * _discount / 100;
            _cur = 0;
        }
        else
            _cur++;
        return cost;
    }
}

/**
 * Your Cashier object will be instantiated and called as such:
 * Cashier obj = new Cashier(n, discount, products, prices);
 * double param_1 = obj.GetBill(product,amount);
 */