namespace CSharp13
{
    public class Locks
    {
        //using general object
        private static readonly object _oldLock = new();

        //We used to use the general object type for lock but now we have a dedicated Lock type - System.Threading.Lock
        private static readonly Lock _newLock = new Lock();

        public static void Run()
        {
            Console.WriteLine("Old lock object");

            lock (_oldLock)
            {
                Console.WriteLine("We're inside old lock");
            }

            Console.WriteLine("New lock object using System.Threading");

            //Only one thread can execute this block at a time
            lock (_newLock)
            {
                Console.WriteLine("We're inside new lock");
            }
        }
    }
}
