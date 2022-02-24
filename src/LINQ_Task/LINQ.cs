namespace LINQ_Task
{
    public class LINQ
    {
        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            return numbers.Select(number => number * number).SequenceEqual(squares);
            
        }
        public static string? GetTheLastWord(IEnumerable<string> words)
        {
          return words.Where(word=>word.Contains('e')).OrderBy(word=>word).Select(word=>$"The last word is {word}").LastOrDefault();
        }
    }
}