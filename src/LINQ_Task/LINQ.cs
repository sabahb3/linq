using System.Linq;
namespace LINQ_Task
{
    public class LINQ
    {
        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            return numbers.Select(number => number * number).SequenceEqual(squares);
            
        }
    }
}