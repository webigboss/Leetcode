public class Solution {
    public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs) {
        //recursion with index optimization
        return Helper(price, special, needs, 0);
    }
    
    //use index to remove duplicate case if choose special[0], special[1], then avoid choose special[1], special[0]
    private int Helper(IList<int> price, IList<IList<int>> special, IList<int> curneeds, int index){
        
        var ans = AllRegularPrices(price, curneeds);
        
        for(var i = index; i < special.Count; ++i){
            var canBuy = true;
            var newneeds = new List<int>();
            for(var j = 0; j < special[i].Count - 1; ++j){
                if(special[i][j] > curneeds[j]){
                    canBuy = false;
                    break;
                }
                newneeds.Add(curneeds[j] - special[i][j]);
            }
            if(!canBuy) continue;
            
            ans = Math.Min(ans, special[i][special[i].Count - 1] + Helper(price, special, newneeds, i));
        }
        return ans;
    }
    
    private int AllRegularPrices(IList<int> price, IList<int> curneeds){
        var ans = 0;
        for(var i = 0; i < price.Count; ++i){
            if(curneeds[i] == 0) continue;
            ans += curneeds[i]*price[i];
        }
        return ans;
    }
}