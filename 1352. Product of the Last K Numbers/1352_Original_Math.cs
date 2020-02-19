public class ProductOfNumbers {

    private List<int> _products;
    private int _maxZero = -1;
    public ProductOfNumbers() {
        _products = new List<int>();
        _products.Add(1);
    }
    
    public void Add(int num) {
        if(num == 0){
            _products.Add(1);
            _maxZero = Math.Max(_maxZero, _products.Count - 1);
        }
        else
            _products.Add(_products[_products.Count - 1] * num);
    }
    
    public int GetProduct(int k) {
        if(_products.Count - k <= _maxZero) 
            return 0;
        else
            return _products[_products.Count - 1] / _products[_products.Count - 1 - k];
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */