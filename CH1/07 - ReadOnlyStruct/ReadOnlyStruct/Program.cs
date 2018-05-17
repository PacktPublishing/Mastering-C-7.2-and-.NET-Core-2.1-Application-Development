namespace ReadOnlyStruct
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        // A normal struct
        public struct CarStruct
        {
            public string Name { get; set; }
            public byte YearOfManufacture { get; set; }
            public CarStruct(string Name, byte YearOfManufacture)
            {
                this.Name = Name;
                this.YearOfManufacture = YearOfManufacture;
            }
            // Constructor with another car struct
            public CarStruct(CarStruct otherCar)
            {
                this = otherCar;
            }
            // Swap put
            public CarStruct Swap(CarStruct replacement)
            {
                var temp = this;
                this = replacement;
                return temp;
            }
        }
        // A read only struct
        public readonly struct CarReadonlyStruct
        {
            // There cannot be a setter for properties - compiler error
            public string Name { get; }
            public byte YearOfManufacture { get; }
            public CarReadonlyStruct(string Name, byte YearOfManufacture)
            {
                this.Name = Name;
                this.YearOfManufacture = YearOfManufacture;
            }
            // Constructor with another car struct
            public CarReadonlyStruct(CarReadonlyStruct otherCar)
            {
                this = otherCar;
            }
            // This will not compile
            //public CarStruct Swap(CarStruct replacement)
            //{
            //    var temp = this;
            //    this = replacement;
            //    return temp;
            //}
        }
    }
}
