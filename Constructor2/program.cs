namespace Constructor2
{
    class MovieTicket
    {
        public string MovieTitle;
        public double price;

        public MovieTicket(string ActualmovieTitle, double Actualprice)
        {
            MovieTitle = ActualmovieTitle;
            price = Actualprice;

            if ((MovieTitle == "") || (Actualprice < 0))
            {
                Console.WriteLine("UnKnown Movie");
            }
            else 
            {
                Console.WriteLine($"Movie name:{MovieTitle}, Price:{price}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieTicket MovieTicket1 = new MovieTicket("", -56);
        }
    }
}
