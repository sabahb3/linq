using System.Linq;
namespace LINQ_Task
{
    public static class Transformation
    {
        public delegate int TransformationFunction (int number);
        public static IEnumerable<int> Transform(this IEnumerable<int>sequence, TransformationFunction t ){
            return sequence.Select(number=>t(number));
        }
    }
}