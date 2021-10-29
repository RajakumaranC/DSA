namespace Algorithms
{
    public partial class Sorting
    {

        public static void QuickSort<T>(T[] array) where T : IComparable
        {
            QuickSort(array, 0, array.Length - 1, Comparer<T>.Default);
        }

        public static void QuickSort<T>(T[] array, Comparer<T> comparer) where T : IComparable
        {
            QuickSort(array, 0, array.Length - 1, comparer);
        }

        
        public static void QuickSort<T>(T[] array, int lower, int upper, IComparer<T> comparer) where T : IComparable
        {
            if(lower < upper)
            {
                int p = Partition(array, lower, upper, comparer);
                QuickSort(array, lower, p, comparer);
                QuickSort(array, p + 1, upper, comparer);
            }
        }

        private static int Partition<T>(T[] array, int lower, int upper, IComparer<T> comparer) where T : IComparable
        {
            int p = lower;
            T pivot = array[p];
            int i = lower + 1;
            int j = upper;

            
            do{
                while(comparer.Compare(array[i], array[p]) < 0) { i++; }
                while(comparer.Compare(array[j], array[p]) > 0) { j--; }

                if(i >= j)
                {
                    break;
                }
                Swap(array, i, j);

            }while(i <= j);

            return j;
        }
    }
}