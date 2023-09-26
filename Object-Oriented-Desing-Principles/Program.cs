
using Object_Oriented_Desing_Principles;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();

        do
        {
            Console.WriteLine("Enter Brand of a car, please");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter model of a car, please");
            string model = Console.ReadLine();
            Console.WriteLine("Enter price of a car in $, please");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of cars for this brand and model");
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                cars.Add(new Car(brand, model, price));
            }
            Console.WriteLine("To finish, press <Esc> ");
            Console.WriteLine("If you want to continue, press any other button");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Invoker invoker = new Invoker();
        CarHelper carHelper = CarHelper.Instance;
        carHelper.Cars = cars;
        CarsCommand carsCommand1 = new CarsCommand(carHelper, CarsAction.Count);
        CarsCommand carsCommand2 = new CarsCommand(carHelper, CarsAction.AveragePrice);
        CarsCommand carsCommand3 = new CarsCommand(carHelper, CarsAction.AveragePriceType);
        CarsCommand carsCommand4 = new CarsCommand(carHelper, CarsAction.CountBrands);

        invoker.SetCommand(carsCommand1);
        invoker.Invoke();
        invoker.SetCommand(carsCommand2);
        invoker.Invoke();
        invoker.SetCommand(carsCommand3);
        invoker.Invoke();
        invoker.SetCommand(carsCommand4);
        invoker.Invoke();
    }
}




