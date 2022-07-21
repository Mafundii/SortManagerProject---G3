using SortAlgorithms;

namespace SortManagerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = MergeSort.Sort(new int[] { -4, 12, -1, 0, 89, 1000, 9, -1 }); 
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
                

        }
    }
}