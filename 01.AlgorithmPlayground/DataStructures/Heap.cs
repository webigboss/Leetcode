using System.Collections.Generic;

namespace AlgorithmPlayground
{

    public class Heap<T>
    {
        private IList<T> _list;
        private IComparer<T> _comparer;
        private IComparer<T> Comparer
        {
            get
            {
                if (_comparer != null) return _comparer;
                return Comparer<T>.Default;
            }
        }
        public Heap(IEnumerable<T> collection, IComparer<T> comparer)
        {

        }

        public Heap(IComparer<T> comparer)
        {
            _list = new List<T>();
            _comparer = comparer;
        }

        public Heap()
        {
            _list = new List<T>();
        }

        public int Capacity
        {
            get { return _list.Count; }
        }

        public T Peek()
        {
            return _list[0];
        }

        public void Enqueue(T item)
        {
            _list.Add(item);
            BubbleupLastItem();
        }

        public T Dequeue()
        {
            var top = _list[0];
            Swap(0, _list.Count - 1);
            _list.RemoveAt(_list.Count - 1);
            BubbledownFirstItem();
            return top;
        }

        private void BubbleupLastItem()
        {
            var i = _list.Count - 1;
            var ip = ParentIndex(_list.Count - 1);
            while (i != 0)
            {
                if (Comparer.Compare(_list[i], _list[ip]) < 0)
                    Swap(i, ip);
                i = ip;
                ip = ParentIndex(ip);
            }
        }

        private void BubbledownFirstItem()
        {
            var i = 0;
            var il = LeftChild(i);
            var ir = RightChild(i);
            int ismall;
            while (true)
            {
                il = LeftChild(i);
                ir = RightChild(i);
                if (il != -1 && ir != -1)
                {
                    if (Comparer.Compare(_list[il], _list[ir]) <= 0)
                        ismall = il;
                    else
                        ismall = ir;
                }
                else if (il == -1 && ir != -1)
                    ismall = ir;
                else if (il != -1 && ir == -1)
                    ismall = il;
                else break;

                if (Comparer.Compare(_list[ismall], _list[i]) < 0)
                {
                    Swap(ismall, i);
                    i = ismall;
                    continue;
                }
                break;
            }
        }

        private void Heapify()
        {

        }

        private void Swap(int a, int b)
        {
            var temp = _list[a];
            _list[a] = _list[b];
            _list[b] = temp;
        }
        private int LeftChild(int index)
        {
            if (index >= Capacity) return -1;
            return index * 2 + 1 >= Capacity ? -1 : index * 2 + 1;
        }

        private int RightChild(int index)
        {
            if (index >= Capacity) return -1;
            return index * 2 + 2 >= Capacity ? -1 : index * 2 + 2;
        }

        private int ParentIndex(int index)
        {
            return (index - 1) / 2 >= Capacity ? -1 : (index - 1) / 2;
        }
    }
}