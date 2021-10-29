
namespace  Algorithms
{
    public partial class Sorting
    {
        // O(n * n) time complexity for both worst and best case --> reason is simple --> we iterate in two loops, just that the second loop goes backwards instead of forwards
        public static void InsertionSort<T>(T[] array) where T : IComparable
        {
            InsertionSort(array, Comparer<T>.Default);
        }

        public static void InsertionSort<T>(T[] array, Comparer<T> comparer) where T : IComparable
        {
            if(array.Length <= 1) return;

            for(int i = 1; i < array.Length; i++)
            {
                int j = i;
                while(j > 0 && comparer.Compare(array[j], array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }
    }
}