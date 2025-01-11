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
                var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                IntArray intArray = new (array);
                Console.WriteLine($"Max: {intArray.Max()}");
                Console.WriteLine($"Min: {intArray.Min()}");
                Console.WriteLine($"Avg: {intArray.Avg()}");
                Console.WriteLine($"Search: {intArray.Search(5)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
