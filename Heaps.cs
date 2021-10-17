using System;

namespace Algorithms
{

    /// <summary>
    /// This is a simple Heap implementaiton that stores integer data.
    /// To idenfity min heap or max heap, pass appropriate static delegate within Heap class to the constructor.
    /// To create min heap do --- new Heap(Heap.MIN_HEAP);
    /// To create max heap do --- new Heap(Heap.MAX_HEAP);
    /// </summary>
    public class Heap
    {

        private List<int> _heap;
        private Func<int, int, bool> _comparer;

        public Heap(Func<int, int, bool> comparer)
        {
            _comparer = comparer;
            _heap = new List<int>();
        }


        public int? Peek()
        {
            if(_heap.Count == 0) return null;
            return _heap[0];
        }

        public void Insert(int value)
        {
            _heap.Add(value);
            ShiftUp(); // todo;


        }

        public int? Remove()
        {
            if(_heap.Count == 0) return null;


            int extracted = _heap[0];
            _heap[0] = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);
            ShiftDown(); //todo;
            return extracted;

        }

        private int LeftChildIndex(int partentIdx) => 2 * partentIdx + 1;
        private int RightChildIndex(int partentIdx) => 2 * partentIdx + 2;
        private int ParentIdx(int childIdx) => (childIdx - 1) / 2;

        
        public void printHeap()
        {
            foreach(var a in _heap)
            {
                System.Console.WriteLine(a);
            }
        }

        private void ShiftDown()
        {
            int parent = 0;
            int end = _heap.Count - 1;

            int leftChild = LeftChildIndex(parent);
            while(leftChild <= end)
            {
                int idxToChange = leftChild;
                int rightChild = RightChildIndex(parent);
                if(rightChild <= end && _comparer(_heap[rightChild], _heap[leftChild]))
                {
                    idxToChange = rightChild;
                }

                if(_comparer(_heap[idxToChange], _heap[parent]))
                {
                    Swap(idxToChange, parent); // todo
                    parent = idxToChange;
                    leftChild = LeftChildIndex(parent);
                    
                }
                else
                {
                    break;
                }
                
            }
        }


        private void ShiftUp()
        {
            int current = _heap.Count - 1;
            int parentIdx = ParentIdx(current);
            while(current > 0 && _comparer(_heap[current], _heap[parentIdx]))
            {
                Swap(parentIdx, current);
                current = parentIdx;
                parentIdx = ParentIdx(current);
            }
        }

        private void Swap(int sourceIdx, int targetIdx)
        {
            int temp = _heap[sourceIdx];
            _heap[sourceIdx] = _heap[targetIdx];
            _heap[targetIdx] = temp;
        }



        public static bool MAX_HEAP(int a, int b)
        {
            return a > b;
        } 

        public static bool MIN_HEAP(int a, int b)
        {
            return a < b;   
        }
        
    }
}