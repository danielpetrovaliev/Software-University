namespace Cars.Controllers
{
    using System;
    using System.Collections.Generic;

    using Cars.Contracts;
    using Cars.Data;
    using Cars.Infrastructure;
    using Cars.Models;

    public class CarsController
    {
        private const string CarMakePropertyName = "make";
        private const string CarYearPropertyName = "year";

        private readonly ICarsRepository carsData;

        public CarsController()
            : this(new CarsRepository())
        {
        }

        public CarsController(ICarsRepository data)
        {
            this.carsData = data;
        }

        public IView Index()
        {
            var cars = this.carsData.All();
            return new View(cars);
        }

        public IView Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException("car", "Car cannot be null!");
            }

            if (string.IsNullOrWhiteSpace(car.Make) || string.IsNullOrWhiteSpace(car.Model))
            {
                throw new ArgumentOutOfRangeException("car", "Car make and model cannot be empty!");
            }

            this.carsData.Add(car);
            return this.Details(car.Id);
        }

        public IView Details(int id)
        {
            var car = this.carsData.GetById(id);
            if (car == null)
            {
                throw new ArgumentException("Car could not be found!", "id");
            }

            return new View(car);
        }

        public IView Search(string searchTerm)
        {
            var result = this.carsData.Search(searchTerm);
            return new View(result);
        }

        public IView Sort(string sortType)
        {
            ICollection<Car> cars;

            switch (sortType)
            {
                case CarMakePropertyName:
                    cars = this.carsData.SortedByMake();
                    break;
                case CarYearPropertyName:
                    cars = this.carsData.SortedByYear();
                    break;
                default:
                    throw new ArgumentException("Invalid sorting parameter!");
            }

            return new View(cars);
        }
    }
}
