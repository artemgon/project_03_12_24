
using System.Collections.Generic;

namespace project_03_12_24.Classes
{
    interface ICalc
    {
        int Less(int valueToCompare); // quantity of elements less than valueToCompare
        int Greater(int valueToCompare); // quantity of elements greater than valueToCompare
    }
    public class IntArray(int[] array) : ICalc
    {
        private readonly int[] _array = array;
        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var item in _array)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var item in _array)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
