using System.Linq;
namespace LINQ_Task
{
    public class linq
    {
        public static string? GetTheLastWord(IEnumerable<string> words)
        {
            return words.Where(word => word.Contains('e')).OrderBy(word => word).Select(word => $"The last word is {word}").LastOrDefault();
        }
    }
}