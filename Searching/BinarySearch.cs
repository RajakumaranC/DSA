namespace Algorithms.Searching
{
    public class BinarySearch
    {
        public static int Find<T>(T[] array, T target) where T : IComparable
        {
            if( array == null || array.Length == 0 )
                throw new ArgumentOutOfRangeException(nameof(array), "Empty collection passed");

            
            return Find_Loop(array, 0, array.Length - 1, target); // using the looping solution. O(1) space
        }

        /// <summary>
        /// Binary Search with Recusive solution 
        /// O(log N) time | O(log N) space
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="target"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static int Find_Recursive<T>(T[] array, int start, int end, T target) where T : IComparable
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
                return Find_Recursive(array, start, mid - 1, target);
            }
            else
            {
                return Find_Recursive(array, mid + 1, end, target);
            }
        }


        /// <summary>
        /// Binary Search with looping solution
        /// O(log N) time | O(1) space
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="target"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static int Find_Loop<T>(T[] array, int start, int end, T target) where T : IComparable
        {
            while(start <= end)
            {
                int mid = (start + end) / 2;

                if(array[mid].CompareTo(target) == 0)
                    return mid;

                else if(array[mid].CompareTo(target) < 0)
                    end = mid - 1;
                
                else
                    start = mid + 1;
            }

            return -1;
        }
    }
}