*** Purchase Attribution ***
Let’s write a purchase attribution algorithm. You’ll be given a file of ad impressions 
and a separate file of purchase events. 
The goal is to figure out how many total impressions each ad served, 
and how many purchases can be attributed to each ad. 
If multiple ad impressions could be attributed to the same purchase, then the most 
recent ad impression should be picked 
(unless it takes place after the purchase event). Assume that the files are sorted in 
ascending order on the timestamp field.

Ad traffic log:

 <timestamp>     <ad-id>          <customer-id>     <product-id>
 00:00:01        123456           345743328134831     B000RTX762
 00:00:02        123456           345743328134831     B000RTX762
 ...

Purchase log:

 <timestamp>     <customer-id>       <product-id>
 00:00:01        345743328134831     B000RTX762
 ...

Desired Output:

 <ad-id>        <total-impressions>     <total-purchases>
 123456         1                       1
 ...
 
 hashtable 
 ad-id -> impression count
 
Impression AD1-Product1-Customer1
Impression AD1-Product1-Customer1
Purchase   Product1-Customer1
Impression AD1-Product1-Customer1
Impression AD1-Product1-Customer1

public void attribute(Impression[] impressions, Purchase[] purchases) {
    var impressionDict = new Dictionary<int, List<Tuple<DateTime, Tuple<int, string>>();
    var pruchaseDict = new Dictionary<Tuple<int, string>, Datetime>();
    
    foreach(var ip in impressions){
        var adid = ip.getAdId();
        var timeStamp = ip.getTimeStamp();
        var custID = ip.getCustomerId;
        var productId = ip.getProductId();
        if(!impressionDict.ContiansKey(custID)){
            impressionDict[cust] = new List<Tuple<DateTime, Tuple<int, string<>>();
        }
        impressionDict[cust].Add(new Tuple<DateTime, Tuple<int, string>>(timeStamp, new Tuple<int, string>(custId, productId)));
    }
    
    foreach(var p in purchases) {
        var timeStamp = p.getTimeStamp();
        var custID = p.getCustomerId;
        var productId = p.getProductId();
        var tp = new Tuple<int, string<>(custId, productId);
        purchaseDict[tp] = timeStamp;
    }
    var result = new Dictionary<int, int[]>();
    foreach(var kvp in impressionDict){
        var adid = kvp.Key;
        var list = kvp.Value;
        var tpcustIdPId = list[0].Item2;
        var purchaseTime = purchaseDict[tpCustIdPId];
        DateTime previousImpressionTime;
        foreach(var tp in list){
            if(tp.Item1 < purchaseTime){
                previousPurchaseTime = tp.Item1;
                continue;
            }
            
            result[]
            
        }
    }

}
