using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

public class Wayfair_VO_CouponAndCategory
{
    public void Test()
    {
        string coupon = @"
        [
            {""Coupon Name"" : ""50% off"", ""Category Name"": ""Bedding""},
            {""Coupon Name"" : ""BOGO"", ""Category Name"": ""Kitchen""}
        ]";
        string categories = @"
        [
            {""Category Name"" : ""Comforter""， “Parent category Name”: ""Bedding""},
            {""Category Name"" : ""Kitchen""， Parent category Name”: null},
            {""Category Name"" : ""Patio""， “Parent category Name”: ""Garden""}
        ]";

        var deserializer = new DataContractJsonSerializer(typeof(List<CouponJson>));
        List<CouponJson> couponsJson = null;
        using (var ms = new MemoryStream(System.Text.Encoding.Unicode.GetBytes(coupon)))
        {
            couponsJson = (List<CouponJson>)deserializer.ReadObject(ms);
        }

        Console.WriteLine($"couponsJson.Length = {couponsJson.Count}");
        Console.WriteLine($"couponsJson[0]-> Name:{couponsJson[0].Name}, CategoryName:{couponsJson[0].CategoryName}");
        Console.WriteLine($"couponsJson[1]-> Name:{couponsJson[1].Name}, CategoryName:{couponsJson[1].CategoryName}");
    }
}

[DataContract]
class CouponJson
{
    [DataMember(Name = "Coupon Name")]
    public string Name { get; set; }

    [DataMember(Name = "Category Name")]
    public string CategoryName { get; set; }
}