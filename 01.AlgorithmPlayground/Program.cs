using System;

namespace AlgorithmPlayground
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bucketsort= new HeapSortClass();
            var array2 = new []{5,8,2,9,0,6,10,3,5,2,9,11,6,12,7,3};
            var array = new []{4,2,1,6,8,9,5};
            bucketsort.HeapSort(array2);
            Console.ReadLine();
        }
    }
}
