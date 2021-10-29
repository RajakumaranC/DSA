namespace Algorithms
{
    public partial class Sorting
    {
        public static void HeapSort<T>(T[] array, bool descending = false) where T : IComparable
        {
            Comparer<T> comparer = Comparer<T>.Default;
            if(descending)
            {
                comparer = Comparer<T>.Create((a, b) => b.CompareTo(a));
            }

            BuildHeap(array, comparer);

            for(int end = array.Length - 1; end >= 0; end--)
            {
                Swap(array, 0, end);
                ShiftDown(array, 0, end - 1, comparer);
            }

        }

        private static void BuildHeap<T>(T[] array, Comparer<T> comparer)
        {
            int parrent = (array.Length - 2 ) / 2;
            for(int current = parrent; current >= 0; current--)
            {
                ShiftDown(array, current, array.Length - 1, comparer);
            }
        }

        private static void ShiftDown<T>(T[] array, int start, int end, Comparer<T> comparer)
        {
            int current = start;
            int left = current * 2 + 1;
            while(left <= end)
            {
                int idxToSwap = left;
                int right = current * 2 + 2;
                if(right <= end && comparer.Compare(array[left], array[right]) < 0)
                    idxToSwap = right;

                if(comparer.Compare(array[current], array[idxToSwap]) < 0)
                    Swap(array, idxToSwap, current);

                current = idxToSwap;
                left = current * 2 + 1;
            }
        }
    }
}