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
                var array = new IntArray(new int[] { 1, 2, 3, 4, 5 });
                array.Show("Array:");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
