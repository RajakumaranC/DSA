using Famous_Algorithms;
using static System.Console;

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
            int[] array = list.ToArray();
            WriteLine(String.Join(", ", names));
            WriteLine("===========================================");
            WriteLine("Sorting it now");
            Sorting.QuickSort(names, descending:false);
            WriteLine(String.Join(", ", names));
            WriteLine("===========================================");
        }
    }
}