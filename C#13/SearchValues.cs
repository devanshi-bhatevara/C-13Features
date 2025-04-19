using System.Buffers;

namespace CSharp13
{
    public class SearchValuesDemo
    {
        public static void Run()
        {
           
            var text = "Hello world! Welcome to C# 13 features POC".AsSpan();

            //Before 
            Console.WriteLine("Worked only with characters/bytes");
            var vowelSearch = SearchValues.Create(['n', 'e', 'w']);
            Console.WriteLine(text.ContainsAny(vowelSearch));

            //After
            Console.WriteLine("Works with strings now");
            var keywordSearch = SearchValues.Create(["world", "features"], StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(text.ContainsAny(keywordSearch));
        }
    }
}
