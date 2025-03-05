namespace lb1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product aplle = new Product("Aplle", 5, 100);
            Console.WriteLine(aplle.GetInfo());

            aplle.Sell(20);
            Console.WriteLine(aplle.GetInfo());

            aplle.Restock(50);
            Console.WriteLine(aplle.GetInfo());

            aplle.Price = 7;
            Console.WriteLine(aplle.GetInfo());

            aplle.Name = "Green Aplle";
            Console.WriteLine(aplle.GetInfo());

            aplle.Price = -10;
            aplle.Name = "";
            aplle.Sell(200);
        }
    }
}
