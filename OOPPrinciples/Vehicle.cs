namespace OOPPrinciples
{
    // Demonstrates Encapsulation and Abstraction
    public abstract class Vehicle
    {
        // Encapsulated fields (private access)
        private string make;
        private string model;
        private int year;

        // Encapsulated properties with public access
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1885) // The first car was invented in 1886
                    year = value;
                else
                    throw new Exception("Invalid year for a vehicle.");
            }
        }

        // Abstract method (to demonstrate polymorphism)
        public abstract void StartEngine();

        // Virtual method (to demonstrate polymorphism)
        public virtual void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }
}
