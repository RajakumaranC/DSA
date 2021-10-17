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
        public int Count {get; private set;}
        private Func<int, int, bool> _comparer;

        public Heap(Func<int, int, bool> comparer, List<int> seed)
        {
            _comparer = comparer;
            _heap = HeapBuilder(seed);
            Count = _heap.Count;
        }

        public List<int> HeapBuilder(List<int> seed)
        {
            int parent = ParentIdx(seed.Count - 1);
            for(int i = parent; i >= 0; i--)
            {
                ShiftDown(i, seed.Count - 1, seed);
                
            }

            return seed;
        }


        public int? Peek()
        {
            if(_heap.Count == 0) return null;
            return _heap[0];
        }

        public void Insert(int value)
        {
            _heap.Add(value);
            Count += 1;
            ShiftUp(_heap.Count - 1, _heap); 


        }

        public int? Remove()
        {
            if(Count == 0) return null;


            int extracted = _heap[0];
            _heap[0] = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);
            ShiftDown(0, _heap.Count - 1, _heap); 
            Count -= 1;
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

        private void ShiftDown(int current, int end, List<int> heap)
        {
            int parent = current;

            int leftChild = LeftChildIndex(parent);
            while(leftChild <= end)
            {
                int idxToChange = leftChild;
                int rightChild = RightChildIndex(parent);
                if(rightChild <= end && _comparer(heap[rightChild], heap[leftChild]))
                {
                    idxToChange = rightChild;
                }

                if(_comparer(heap[idxToChange], heap[parent]))
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


        private void ShiftUp(int current, List<int> heap)
        {
            
            int parentIdx = ParentIdx(current);
            while(current > 0 && _comparer(heap[current], heap[parentIdx]))
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