using System;
using System.Collections.Generic;

namespace AlgorithmPlayground{

    public class RandomSetTest{
        public RandomSetTest(){
            var rndSet = new RandomizedSet();
            Console.WriteLine(rndSet.Insert(3));
            Console.WriteLine(rndSet.Insert(-2));
            Console.WriteLine(rndSet.Remove(2));
            Console.WriteLine(rndSet.Insert(1));
            Console.WriteLine(rndSet.Insert(-3));
            Console.WriteLine(rndSet.Insert(-2));
            Console.WriteLine(rndSet.Remove(-2));
            Console.WriteLine(rndSet.Remove(3));
            Console.WriteLine(rndSet.Insert(-1));
            Console.WriteLine(rndSet.Remove(-3));
            Console.WriteLine(rndSet.Insert(1));
            Console.WriteLine(rndSet.Insert(-2));
            Console.WriteLine(rndSet.Insert(-2));
            Console.WriteLine(rndSet.Insert(-2));
            Console.WriteLine(rndSet.Insert(1));
        }
    }
    public class RandomizedSet {

        private Dictionary<int, int> _dict;
        private List<int> _list;
        private Random _rdn;
        /** Initialize your data structure here. */
        public RandomizedSet() {
            _dict = new Dictionary<int, int>();
            _rdn = new Random();
            _list = new List<int>();
        }
        
        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val) {
            if(_dict.ContainsKey(val)) return false;
            
            if(_dict.Count < _list.Count)
                _list[_dict.Count] = val;
            else
                _list.Add(val);
            _dict[val] = _dict.Count;
            return true;
        }
        
        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val) {
            if(!_dict.ContainsKey(val)) return false;
            if(_dict[val] != _list.Count - 1){
                //if removed num is not at the tail of _list,
                //swap _list's tail to the index of element being removed.
                _dict[_list[_dict.Count - 1]] = _dict[val];
                Swap(_list, _dict.Count - 1, _dict[val]);
            }
            _dict.Remove(val);
            return true;
        }
        
        /** Get a random element from the set. */
        public int GetRandom() {
            var i = _rdn.Next() % _dict.Count;
            return _list[i];
        }
        
        private void Swap(List<int> list, int i, int j){
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}