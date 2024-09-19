
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RubanovEO.Sprint2.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = [x != y, x > y, x >= y, x < y, x <= y,x == y];         
            return result; 
        }
    }
}
