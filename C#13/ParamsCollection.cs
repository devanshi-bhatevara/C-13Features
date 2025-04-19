namespace CSharp13
{
    public class ParamsCollection
    {
        public static void Run()
        {
            Console.WriteLine("Params Collection Demo in C# 13");
            PrintNames("Alice", "Bob", "Charlie");
        }

        static void PrintNames(params IEnumerable<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }

        //Before - Params were only limited to arrays earlier
        static void ParamsCollectionDemo(params int[] listOfNumbers)
        {

        }

        //After - But now we can use HashSets, Lists, Spans
        static void ParamsCollectionDemo(params HashSet<int> listOfNumbers)
        {

        }

        static void ParamsCollectionDemo(params List<int> listOfNumbers)
        {

        }
        static void ParamsCollectionDemo(params Span<int> listOfNumbers)
        {

        }
    }
}
