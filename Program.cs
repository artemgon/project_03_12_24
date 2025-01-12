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
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                ICalc calc = new IntArray(array);
                Console.WriteLine($"Less than 5: {calc.Less(5)}");
                Console.WriteLine($"Greater than 5: {calc.Greater(5)}");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
