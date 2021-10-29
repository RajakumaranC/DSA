namespace Algorithms
{
    public partial class Sorting
    {
        // O(n*n) Time in best and worst case coz we just do two loops | O(1) space coz we don't use additional space
        public static void SelectionSort<T>(T[] array) where T : IComparable
        {
            SelectionSort(array, Comparer<T>.Default);
        }

        public static void SelectionSort<T>(T[] array, IComparer<T> comparer) where T : IComparable
        {
            if(array.Length <= 0) return;
        
           for(int i = 0; i < array.Length - 1; i++)
           {
               int minIdx = i;
                T minValue = array[i];
               
               for(int j = i + 1; j < array.Length; j++)
               {
                   if(comparer.Compare(array[j], minValue) < 0)
                   {
                       minIdx = j;
                       minValue = array[j];
                   }
               }
               Swap(array, i, minIdx);
           }
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
        
    }
    
}