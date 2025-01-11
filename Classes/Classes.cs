
namespace project_03_12_24.Classes
{
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    public class IntArray(int[] array) : ISort
    {
        private readonly int[] _array = array;
        public void SortAsc()
        {
            Array.Sort(_array);
        }
        public void SortDesc()
        {
            Array.Sort(_array);
            Array.Reverse(_array);
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
