

namespace ConsoleApp39
{
    public class AvtoSvit
    {
        private List<Car> cars;

        public AvtoSvit()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public List<Car> SearchByBrand(string brand)
        {
            return cars.Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void SaveToTextFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var car in cars)
                {
                    writer.WriteLine(car.ToString());
                }
            }
        }

        public void DisplayAllCars()
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }

}
