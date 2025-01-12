
using System.Collections.Generic;

namespace project_03_12_24.Classes
{
    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
    public class IntArray(int[] array) : ICalc2
    {
        private readonly int[] _array = array;
        public int CountDistinct()
        {
            var distinct = new HashSet<int>();
            foreach (var i in _array)
            {
                distinct.Add(i);
            }
            return distinct.Count;
        }
        public int EqualToValue(int valueToCompare)
        {
            var count = 0;
            foreach (var i in _array)
            {
                if (i == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
