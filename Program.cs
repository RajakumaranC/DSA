using Famous_Algorithms;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<int> list = new List<int>();
            Random rand = new Random();
            int max = 100;
            for(int i = 0; i < max; i++)
            {
                list.Add(rand.Next(-max, max));
            }

            string[] names = {"Raj", "raj", "RAJ"};
            string a = "rajr";
            WriteLine(a.Substring_KMP("aj"));
            // int[] array = list.ToArray();
            // WriteLine(String.Join(", ", array));
            // WriteLine("===========================================");
            // WriteLine("Sorting it now");
            // Sorting.QuickSort(array, Comparer<int>.Create((x,y) => y.CompareTo(x)));
            // WriteLine(String.Join(", ", array));
            // WriteLine("===========================================");
        }
    }
}