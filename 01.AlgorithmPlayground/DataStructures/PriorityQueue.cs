using System;
using System.Collections.Generic;
public class PriorityQueue<T>
{
    private List<T> list;
    private Comparison<T> comparison;

    public PriorityQueue(Comparison<T> comparison)
    {
        list = new List<T>();
        this.comparison = comparison;
    }

    public void Enqueue(T item)
    {
        list.Add(item);
        list.Sort(this.comparison);
    }

    public T Dequeue()
    {
        var ret = list[0];
        list.RemoveAt(0);
        list.Sort(this.comparison);
        return ret;
    }
    public T Peek()
    {
        return list[0];
    }
    public int Count
    {
        get => list.Count;
    }

}