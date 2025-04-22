namespace CSharp13
{
    public class Locks
    {
        private static readonly object _oldLock = new();

        //We used to use the general object type for lock but now we have a dedicated Lock type
        private static readonly Lock _newLock = new Lock();

        public static void Run()
        {
            Console.WriteLine("Old lock object");

            lock (_oldLock)
            {
                Console.WriteLine("We're inside old lock");
            }

            Console.WriteLine("New lock object using System.Threading");

            lock (_newLock)
            {
                Console.WriteLine("We're inside new lock");
            }
        }
    }
}
