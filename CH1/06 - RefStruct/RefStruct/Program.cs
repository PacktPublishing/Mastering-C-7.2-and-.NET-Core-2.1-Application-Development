namespace RefStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a normal struct
            var jane = new PersonStruct() { Name = "Jane", Age = 100 };
            // Create a ref struct
            var bob = new PersonRefStruct() { Name = "Bob", Age = 100 };

            // Since a struct is a value type, it can be boxed
            jane.GetHashCode();
            jane.ToString();

            // But a ref struct does not alow boxing, so these cause a compler error
            //bob.GetHashCode();
            //bob.ToString();
        }
        public ref struct PersonRefStruct
        {
            public int Age;
            public string Name;
        }
        public struct PersonStruct
        {
            public int Age;
            public string Name;
        }
    }
}
