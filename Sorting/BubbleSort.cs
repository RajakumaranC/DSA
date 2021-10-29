namespace Algorithms
{
    public partial class Sorting
    {
        public static void BubbleSort<T>(T[] array) where T : IComparable
        {
           BubbleSort(array, Comparer<T>.Default);
        }

        public static void BubbleSort<T>(T[] array, Comparer<T> comparer) where T : IComparable
        {
            if(array.Length <= 1) return;

            for(int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                    }
                }

                if(!isAnyChange)
                {
                    return;
                }
            }
        }
    }
}