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
            for(int i = 0; i < 1000; i++)
            {
                list.Add(rand.Next(-1000, 1000));
            }

            int[] array = list.ToArray();

            WriteLine(String.Join(", ", array));
            WriteLine("===========================================");
            WriteLine("Sorting it now");
            Sorting.HeapSort(array);

            WriteLine(String.Join(", ", array));
            WriteLine("===========================================");


        }
    }
}