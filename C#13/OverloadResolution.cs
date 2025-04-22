using System.Runtime.CompilerServices;

namespace CSharp13
{
    public class OverloadResolution
    {
        [OverloadResolutionPriority(1)]
        public void PrintMessage(string message) => Console.WriteLine($"String: {message}");

        // Default overload resolution priority
        public void PrintMessage(int number) => Console.WriteLine($"Integer: {number}");
    }
}
