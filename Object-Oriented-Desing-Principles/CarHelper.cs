using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Desing_Principles
{
    public sealed class CarHelper
    {
        public List<Car> Cars;
        private static CarHelper instance = null;

        public static CarHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CarHelper();
                }
                return instance;
            }
        }

        private CarHelper() {}

        public void Count()
        {
            Console.WriteLine("Number of cars: " + Cars.Count);
        }

        public void AveragePrice()
        {
            Console.WriteLine("Average price of all cars " + Cars.Average(Car => Car.Price));
        }

        public void AveragePriceType()
        {
            var output = Cars.GroupBy(c => c.Brand).Select(g => new { Brand = g.Key, Avg = g.Average(car => car.Price) }).ToDictionary(x => x.Brand, x => x.Avg);
            foreach (var el in output)
            {
                Console.WriteLine($"Average price for brand {el.Key} is {el.Value}");
            }
        }

        public void CountBrands()
        {
            Console.WriteLine("Count of brands " + Cars.GroupBy(c => c.Brand).Count());
        }
    }
}
