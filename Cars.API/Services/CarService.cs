using Cars.API.Models;

namespace Cars.API.Services
{
    public class CarService
    {
        private static List<Car> cars = new List<Car>
        {
            new Car
            {
                Id = 1,
                Age = "2019",
                ModelName = "Toyota",
                Color = "Red"
            },
            new Car
            {
                Id = 2,
                Age = "2020",
                ModelName = "Honda",
                Color = "Blue"
            },
            new Car
            {
                Id = 3,
                Age = "2021",
                ModelName = "Ford",
                Color = "Green"
            }
        };

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public Car GetCarById(int id)
        {
            return cars.FirstOrDefault(c => c.Id == id);
        }

        public void CreateCar(Car car)
        {
            car.Id = cars.Max(c => c.Id) + 1;
            cars.Add(car);
        }

        public void UpdateCard(int id, Car updateCar)
        {
            var existingCar = cars.FirstOrDefault(c => c.Id == id);

            if (existingCar is not null)
            {
                existingCar.Age = updateCar.Age;
                existingCar.ModelName = updateCar.ModelName;
                existingCar.Color = updateCar.Color;
            }
        }

        public void DeleteCar(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);

            if (car is not null)
                cars.Remove(car);
        }
    }
}
