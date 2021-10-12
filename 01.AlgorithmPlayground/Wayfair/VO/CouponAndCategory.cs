using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

public class Wayfair_VO_CouponAndCategory
{
    public void Test()
    {
        string coupon, categories, ans, categoryName;
        coupon = @"
        [
            {""Coupon Name"" : ""50% off"", ""Category Name"": ""Bedding""},
            {""Coupon Name"" : ""BOGO"", ""Category Name"": ""Kitchen""},
            {""Coupon Name"" : ""20% off"", ""Category Name"": ""Cookware""}
        ]";
        categories = @"
        [
            {""Category Name"" : ""Comforter"", ""Parent category Name"": ""Bedding""},
            {""Category Name"" : ""Kitchen"", ""Parent category Name"": null},
            {""Category Name"" : ""Cookware"", ""Parent category Name"": ""Kitchen""},
            {""Category Name"" : ""Pan"", ""Parent category Name"": ""Cookware""}            
        ]";
        categoryName = "Pan";
        ans = GetCouponByCategory(coupon, categories, categoryName);
        Console.WriteLine($"categoryName: {categoryName} -> {ans}");
        categoryName = "Comforter";
        ans = GetCouponByCategory(coupon, categories, categoryName);
        Console.WriteLine($"categoryName: {categoryName} -> {ans}");
    }

    public string GetCouponByCategory(string couponJson, string categoryJson, string categoryName) {
        var coupon_deserializer = new DataContractJsonSerializer(typeof(List<Coupon>));
        var category_deserializer = new DataContractJsonSerializer(typeof(List<Category>));
        var categoryToCouponMap = new Dictionary<string, List<string>>();
        var parentCategoryMap = new Dictionary<string, string>();

        using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(couponJson))) {
            var coupons = (List<Coupon>)coupon_deserializer.ReadObject(ms);
            foreach(var coupon in coupons) {
                if(!categoryToCouponMap.ContainsKey(coupon.CategoryName))
                    categoryToCouponMap[coupon.CategoryName] = new List<string>();
                categoryToCouponMap[coupon.CategoryName].Add(coupon.Name);
            }
        }
        using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(categoryJson))) {
            var categories = (List<Category>)category_deserializer.ReadObject(ms);
            foreach(var category in categories) {
                if(!string.IsNullOrEmpty(category.ParentCategoryName))
                    parentCategoryMap[category.Name] = category.ParentCategoryName;
            }
        }

        //iterave using a while loop
        while(true){
            if(categoryToCouponMap.ContainsKey(categoryName)){
                return categoryToCouponMap[categoryName][categoryToCouponMap[categoryName].Count - 1];
            }
            if(!parentCategoryMap.ContainsKey(categoryName) || string.IsNullOrEmpty(parentCategoryMap[categoryName]))
                break;
            categoryName = parentCategoryMap[categoryName];
        }
        return null;
    }
}

[DataContract]
public class Coupon
{
    [DataMember(Name = "Coupon Name")]
    public string Name { get; set; }

    [DataMember(Name = "Category Name")]
    public string CategoryName { get; set; }
}

[DataContract]
public class Category {
    [DataMember(Name="Category Name")]
    public string Name {get;set;}

    [DataMember(Name="Parent category Name")]
    public string ParentCategoryName {get;set;}
}