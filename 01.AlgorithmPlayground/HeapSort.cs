using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class HeapSortClass{
        public void HeapSort(int[] array){
            int length = array.Length;
            //1. Heapify (restore the heap), iterate first half of the array and bubble down every element;
            for(var i = length / 2; i >= 0; i--){
                var curIndex = i;
                BubbleDown(array, curIndex, length);
            }

            //2. extraction (sort)
            while(length > 1){
                //remove top of the heap by swapping the first and last element. shrink the length by 1;
                Swap(array, 0, length - 1);
                length--;
                var curIndex = 0;
                BubbleDown(array, curIndex, length);
            }
        }

        public void BubbleDown(int[] array, int curIndex, int length){
            while(HasLeftChild(curIndex, length)){
                    var biggerChildIndex = GetLeftChild(curIndex);
                    if(HasRightChild(curIndex, length)){
                        var rightChildIndex = GetRightChild(curIndex);
                        biggerChildIndex = array[biggerChildIndex] > array[rightChildIndex] ? biggerChildIndex : rightChildIndex;
                    }
                    if(array[biggerChildIndex] > array[curIndex]){
                        Swap(array, curIndex, biggerChildIndex);
                    }
                    curIndex = biggerChildIndex;
                }
        }
        public int GetLeftChild(int parent){
            return parent * 2 + 1;
        }

        public int GetRightChild(int parent){
            return parent * 2 + 2;
        }

        public int GetParent(int index){
            return (index - 1) / 2;
        }

        public bool HasLeftChild(int parent, int length){
            return GetLeftChild(parent) < length;
        }

        public bool HasRightChild(int parent, int length){
            return GetRightChild(parent) < length;
        }

        public void Swap(int[] array, int parent, int child){
            var temp = array[parent];
            array[parent] = array[child];
            array[child] = temp;
        }
    }
}
