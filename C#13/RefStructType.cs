namespace CSharp13
{
    public class RefStructType
    {
        public static void Run()
        {
            int[] array = { 1, 2, 3 };
            var processor = new DataProcessor(array);
            processor.Process();

            //This avoids heap boxing
            //IProcessor p = processor; // ❌ Not allowed

            Console.WriteLine(string.Join(", ", array)); // Output: 11, 12, 13
        }
    }
    public interface IProcessor
    {
        void Process();
    }

    //ref struct type can inherit intefaces, but they cannot be assigned to interface variables to prevent boxing
    public ref struct DataProcessor : IProcessor
    {
        private Span<int> _data;

        public DataProcessor(Span<int> data)
        {
            _data = data;
        }

        public void Process()
        {
            for (int i = 0; i < _data.Length; i++)
            {
                _data[i] += 10;
            }
        }
    }
}
