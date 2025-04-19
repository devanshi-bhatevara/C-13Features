namespace CSharp13
{
    public partial class PartialProperties
    {
        //same as partial class we can now define partial properties as well
        //declaration
        public partial string Name { get; set; }

    }


    public partial class PartialProperties
    {
        //implementation, applying some logic
        private string _name;
        public partial string Name
        {
            get => _name.ToUpper();
            set => _name = value;
        }
    }
}
