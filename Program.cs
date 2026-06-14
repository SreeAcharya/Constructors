namespace Constructors
{
    class SmartBulb
    {
        public Boolean IsOn;
        public int brightness;
        public SmartBulb() 
        {
            IsOn = false;
            brightness = 0;
        }
        public SmartBulb(Boolean IsActuallyOn, int ActualBrightness)
        {
            IsOn = IsActuallyOn;
            brightness = ActualBrightness;
        }
        public void ShowStatus()
        {
            Console.WriteLine($"The current state of BULB is:{IsOn}, and its Brightness:{brightness}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SmartBulb SmartBulb1 = new SmartBulb(true, 70);
            SmartBulb1.ShowStatus();
        }
    }
}
