using project_03_12_24.Classes;

namespace project_03_12_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var intArray = new IntArray(array);
                Console.WriteLine("Even numbers:");
                intArray.ShowEven();
                Console.WriteLine();
                Console.WriteLine("Odd numbers:");
                intArray.ShowOdd();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
