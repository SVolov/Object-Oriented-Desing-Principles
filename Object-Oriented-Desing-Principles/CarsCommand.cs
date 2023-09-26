using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Desing_Principles
{
    public class CarsCommand : ICommand
    {
        private readonly CarHelper carHelper;
        private readonly CarsAction carsAction;

        public CarsCommand(CarHelper carHelper, CarsAction carsAction)
        {
            this.carHelper = carHelper;
            this.carsAction = carsAction;
        }

        public void Execute()
        {
            switch (carsAction)
            {
                case CarsAction.Count:
                    carHelper.Count();
                    break;
                case CarsAction.AveragePrice:
                    carHelper.AveragePrice();
                    break;
                case CarsAction.AveragePriceType:
                    carHelper.AveragePriceType();
                    break;
                case CarsAction.CountBrands:
                    carHelper.CountBrands();
                    break;
                default:
                    Console.WriteLine("No such command");
                    break;
            }
        }
    }
}
