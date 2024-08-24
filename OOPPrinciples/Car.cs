namespace OOPPrinciples
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors)
        {
            Make = make;
            Model = model;
            Year = year;
            NumberOfDoors = numberOfDoors;
        }

        // Overrides the StartEngine method
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        // Overrides the StopEngine method to add custom behavior
        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped with the key.");
        }
    }
}
