namespace Algorithms.Searching
{
    public class BinarySearch
    {
        public static int Find<T>(T[] array, T target) where T : IComparable
        {
            if( array == null || array.Length == 0 )
                throw new ArgumentOutOfRangeException(nameof(array), "Empty collection passed");

            
            return Find(array, 0, array.Length - 1, target);
        }

        private static int Find<T>(T[] array, int start, int end, T target) where T : IComparable
        {
            if(start > end)
            {
                return -1;
            }

            int mid = (start + end) / 2;

            if(array[mid].CompareTo(target) == 0)
                return mid;

            else if(array[mid].CompareTo(target) < 0)
            {
                return Find(array, start, mid - 1, target);
            }
            else
            {
                return Find(array, mid + 1, end, target);
            }
        }
    }
}