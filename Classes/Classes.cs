
using System.Collections.Generic;

namespace project_03_12_24.Classes
{
    public interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    public class IntArray(int[] array) : IOutput2
    {
        private readonly int[] _array = array;
        public void ShowEven()
        {
            foreach (var i in _array)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void ShowOdd()
        {
            foreach (var i in _array)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
