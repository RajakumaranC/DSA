using static System.Console;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Heap sample = new Heap(Heap.MIN_HEAP);
            sample.Insert(10);
            sample.Insert(15);
            sample.Insert(0);
            sample.Insert(4);
            sample.Insert(6);
            sample.Insert(3);
            sample.Insert(1);
            sample.Insert(-1);
            sample.Insert(7);
            sample.Insert(-4);
            sample.Insert(3);

            sample.printHeap();
            ReadLine();

            WriteLine(sample.Remove());
            WriteLine(sample.Remove());
            WriteLine(sample.Remove());
            WriteLine(sample.Remove());
            WriteLine(sample.Remove());
            WriteLine(sample.Remove());
            WriteLine(sample.Remove());
            WriteLine(sample.Remove());
            WriteLine(sample.Remove());
            WriteLine(sample.Remove());
            WriteLine(sample.Remove());




        }
    }
}