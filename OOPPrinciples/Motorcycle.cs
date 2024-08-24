namespace OOPPrinciples
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, bool hasSidecar)
        {
            Make = make;
            Model = model;
            Year = year;
            HasSidecar = hasSidecar;
        }

        // Overrides the StartEngine method
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started.");
        }

        // Uses base class's StopEngine method
    }
}
