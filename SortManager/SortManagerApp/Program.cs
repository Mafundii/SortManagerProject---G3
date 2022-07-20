using SortAlgorithms;

namespace SortManagerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = MergeSort.Sort(new int[] { 4, 3, 6, 7, 5 }); 
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
                

        }
    }
}