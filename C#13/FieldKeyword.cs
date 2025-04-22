namespace CSharp13
{
    public class FieldKeyword
    {
        //before
        private int _oldValue;
        public int OldValue
        {
            get { return _oldValue; }
            set { _oldValue = value; }
        }

        //after
        public int Value
        {
            get => field; // Directly accesses the backing field
            set => field = value; // Directly sets the backing field
        }
    }
}
