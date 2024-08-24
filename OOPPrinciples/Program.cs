namespace OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Car object (demonstrating inheritance and encapsulation)
            Car car = new Car("Toyota", "Corolla", 2020, 4);
            Console.WriteLine($"{car.Make} {car.Model} {car.Year} with {car.NumberOfDoors} doors.");
            car.StartEngine();  // Demonstrating polymorphism
            car.StopEngine();   // Demonstrating polymorphism

            Console.WriteLine("\n*****************************\n");

            // Create a Motorcycle object (demonstrating inheritance and encapsulation)
            Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2018, false);
            Console.WriteLine($"{motorcycle.Make} {motorcycle.Model} {motorcycle.Year} with sidecar: {motorcycle.HasSidecar}");
            motorcycle.StartEngine();  // Demonstrating polymorphism
            motorcycle.StopEngine();   // Demonstrating inheritance
        }
    }
}
