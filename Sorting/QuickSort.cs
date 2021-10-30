namespace Algorithms
{
    public partial class Sorting
    {

        public static void QuickSort<T>(T[] array) where T : IComparable
        {
            
            QuickSort(array, 0, array.Length - 1, Comparer<T>.Default);
        }

        public static void QuickSort<T>(T[] array, Comparer<T> comparer)
        {
            QuickSort(array, 0, array.Length - 1, comparer);
        }

        
        public static void QuickSort<T>(T[] array, int lower, int upper, IComparer<T> comparer)
        {
            if(lower < upper)
            {
                int p = Partition(array, lower, upper, comparer);
                QuickSort(array, lower, p - 1, comparer);
                QuickSort(array, p + 1, upper, comparer);
            }
        }

        private static int Partition<T>(T[] array, int lower, int upper, IComparer<T> comparer)
        {
            int p = lower;
            T pivot = array[p];
            int i = lower + 1;
            int j = upper;

            
           while(i < j)
           {
                // while(array[i].CompareTo(pivot) <= 0) { i++; }
                // while(array[j].CompareTo(pivot) > 0) { j--; }

                while(comparer.Compare(array[i], pivot) <= 0) { i++; }
                while(comparer.Compare(array[j], pivot) > 0) { j--; }

                if(i < j)
                    Swap(array, i, j);

            }

            Swap(array, p, j);

            return j;
        }
    }
}