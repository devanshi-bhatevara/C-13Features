namespace CSharp13
{
    public class UUIDGeneration
    {
        public static void Run()
        {
            //before - we used an external library for GUID generation
            var guid = Guid.NewGuid(); // v4 UUID - uses external library
            Console.WriteLine($"v4 GUID: {guid}", guid);

            //after - now we use internal library
            guid = Guid.CreateVersion7(); // v7 UUID - built in in .NET
            Console.WriteLine($"v7 GUID: {guid}", guid);
            guid = Guid.CreateVersion7(TimeProvider.System.GetUtcNow()); // v7 UUID with timestamp
            Console.WriteLine($"v7 GUID with timestamp: {guid}", guid);

        }
    }
}
