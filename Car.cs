namespace G12_20250227
{
    class Car : IComparables
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }

        public int CompareTo(object obj)
        {
            if (obj is not Car car) 
            {
                throw new Exception("invalid class");
            }

            if (Year < car.Year) 
            {
                return -1;
            }

            if (Year > car.Year)
            {
                return 1;
            }

            return 0;
        }
    }
}