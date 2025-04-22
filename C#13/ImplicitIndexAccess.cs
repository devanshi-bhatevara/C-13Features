namespace CSharp13
{
    public class ImplicitIndexAccess
    {
        //Implicit index access allows you to use the ^ operator to index elements from the end of a collection
        public int[] oldBuffer { get; set; } = new int[10];
        public int[] newBuffer { get; set; } = new int[10];

        public void Run()
        {
            //before
            oldBuffer[oldBuffer.Length - 1] = 5;   // last
            oldBuffer[oldBuffer.Length - 2] = 15;  // second last
            oldBuffer[oldBuffer.Length - 5] = 48;  // fifth from last
            oldBuffer[oldBuffer.Length - 10] = 91; // tenth from last

            Console.WriteLine("Timer Countdown Buffer with old way:");
            for (int i = 0; i < oldBuffer.Length; i++)
            {
                Console.WriteLine($"Old Buffer[{i}] = {oldBuffer[i]}");
            }

            //after
            newBuffer[^1] = 5; //assign 5 to last element
            newBuffer[^2] = 15; //last to second element
            newBuffer[^5] = 48; //fifth from last
            newBuffer[^10] = 91; //tenth from last

            Console.WriteLine("Timer Countdown Buffer with new way:");
            for (int i = 0; i < newBuffer.Length; i++)
            {
                Console.WriteLine($"New Buffer[{i}] = {newBuffer[i]}");
            }
        }
    }
}
