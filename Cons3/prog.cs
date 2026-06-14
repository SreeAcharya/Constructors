namespace Cons3
{
    class TravelBus
    {
        public string licensePlate;
        public string Brand;
        public string color;
        public int wheels;
        public double Passengers;

        public TravelBus(string ActuallicensePlate)
        {
            licensePlate = ActuallicensePlate;
            Brand = "SreeDurga";
            color = "Blue";
            wheels = 4;
            Passengers = 30;
            Console.WriteLine($"For the Brand:{Brand}, with color:{ color}, and wheels:{ wheels}, having passengers:{Passengers}, the license:{licensePlate}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TravelBus Bus1 = new TravelBus("12334");
        }
    }
}
