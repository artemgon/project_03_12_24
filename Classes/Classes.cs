
namespace project_03_12_24.Classes
{
    public interface IOutput
    {
        void Show();
        void Show(string message);
    }
    public class IntArray : IOutput
    {
        private int[] _array;
        public IntArray(int[] array)
        {
            _array = array;
        }
        public void Show()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }
        public void Show(string message)
        {
            Console.WriteLine(message);
            Show();
        }
    }
}
