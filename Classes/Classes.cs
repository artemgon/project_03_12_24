
namespace project_03_12_24.Classes
{
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    public class IntArray(int[] array) : IMath
    {
        private readonly int[] _array = array;
        public int Max()
        {
            int max = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }
        public float Avg()
        {
            float sum = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                sum += _array[i];
            }
            return sum / _array.Length;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
