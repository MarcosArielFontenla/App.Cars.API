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
                Make = "Toyota",
                ModelName = "Corolla",
                Description = "Car Toyota description",
                Color = "Red",
                Year = 2019,
                Price = 8000
            },
            new Car
            {
                Id = 2,
                Make = "Honda",
                ModelName = "Civic",
                Description = "Car Honda description",
                Color = "Blue",
                Year = 2020,
                Price = 9000
            },
            new Car
            {
                Id = 3,
                Make = "Ford",
                ModelName = "Focus",
                Description = "Car Ford description",
                Color = "Orange",
                Year = 2023,
                Price = 7000
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

        public void UpdateCar(int id, Car updateCar)
        {
            var existingCar = cars.FirstOrDefault(c => c.Id == id);

            if (existingCar is not null)
            {
                existingCar.Make = updateCar.Make;
                existingCar.ModelName = updateCar.ModelName;
                existingCar.Description = updateCar.Description;
                existingCar.Color = updateCar.Color;
                existingCar.Year = updateCar.Year;
                existingCar.Price = updateCar.Price;
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
