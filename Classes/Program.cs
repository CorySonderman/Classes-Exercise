using Microsoft.VisualBasic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Year = 2007;
            car1.Make = "Koenigsegg";
            car1.Model = "CCXR";

            Console.Write($"{car1.Year} {car1.Make} {car1.Model}");
            Console.WriteLine();
        }
        
    }
}
