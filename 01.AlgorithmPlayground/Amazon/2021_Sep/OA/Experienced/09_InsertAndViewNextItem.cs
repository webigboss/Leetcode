using System;
using System.Collections.Generic;
using System.Text;

public class AmazonOA_09_InsertAndViewNextItem
{
    public void Test()
    {
        List<string[]> entries;
        entries = new List<string[]>{
            new []{"INSERT", "milk", "4"},
            new []{"INSERT", "coffee", "3"},
            new []{"VIEW", "-", "-"},
            new []{"INSERT", "pizza", "5"},
            new []{"INSERT", "gum", "1"},
            new []{"VIEW", "-", "-"}
        };
        Console.WriteLine($"[{string.Join(',', GetItems(entries))}]"); // expected [coffee, coffee]
        entries = new List<string[]>{
            new []{"INSERT", "fries", "4"},
            new []{"INSERT", "soda", "2"},
            new []{"VIEW", "-", "-"},
            new []{"VIEW", "-", "-"},
            new []{"INSERT", "hamburger", "5"},
            new []{"VIEW", "-", "-"},
            new []{"INSERT", "nuggets", "4"},
            new []{"INSERT", "cookies", "1"},
            new []{"VIEW", "-", "-"},
            new []{"VIEW", "-", "-"}
        };
        Console.WriteLine($"[{string.Join(',', GetItems(entries))}]"); // expected [soda, fries, hamburger, nuggets, hamburger]
    }

    public List<string> GetItems(List<string[]> entries)
    {
        var pqMin = new PriorityQueue<Tuple<int, string>>((a, b) => {
            if(a.Item1 == b.Item1) return a.Item2.CompareTo(b.Item2);
            return a.Item1 - b.Item1; });
        var pqMax = new PriorityQueue<Tuple<int, string>>((a, b) => {
            if(a.Item1 == b.Item1) return b.Item2.CompareTo(a.Item2);
            return b.Item1 - a.Item1;
        });
        var ans = new List<string>();
        foreach (var e in entries)
        {
            if (e[0] == "INSERT")
            {
                int price = int.Parse(e[2]);
                pqMin.Enqueue(new Tuple<int, string>(price, e[1]));
                if (pqMax.Count > 0 && pqMax.Peek().Item1 > pqMin.Peek().Item1)
                {
                    var maxItem = pqMax.Dequeue();
                    var minItem = pqMin.Dequeue();
                    pqMax.Enqueue(minItem);
                    pqMin.Enqueue(maxItem);
                }
            }
            else
            {
                var minItem = pqMin.Dequeue();
                ans.Add(minItem.Item2);
                pqMax.Enqueue(minItem);
            }
        }
        return ans;
    }
}