using System;
namespace ConsoleApp39
{
    class Program
    {
        static void Main()
        {

            AvtoSvit avtoSvit = new AvtoSvit();

            Console.WriteLine("Бажаєте додати інформацію про автомобіль? (так/ні)");
            string addCarInput = Console.ReadLine();

            while (addCarInput.Equals("так", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("введіть марку автомобіля: ");
                string brand = Console.ReadLine();

                Console.Write("введіть рік випуску: ");
                int yearOfManufacture = int.Parse(Console.ReadLine());

                Console.Write("введіть модель автомобіля: ");
                string model = Console.ReadLine();

                Console.Write("введіть додаткову інформацію: ");
                string additionalInfo = Console.ReadLine();

                Car newCar = new Car(brand, yearOfManufacture, model, additionalInfo);
                avtoSvit.AddCar(newCar);

                Console.WriteLine("чи бажаєте ви добавити інший автомобіль? (так/ні)");
                addCarInput = Console.ReadLine();
            }

            Console.WriteLine("\nусі машини в базі даних:");
            avtoSvit.DisplayAllCars();

            Console.WriteLine("\nчи бажаєте ви зберегти усі машини у текстовий файл? (так/ні)");
            string saveInput = Console.ReadLine();

            if (saveInput.Equals("так", StringComparison.OrdinalIgnoreCase))
            {
                string filePath = "car_data.txt";
                avtoSvit.SaveToTextFile(filePath);
                Console.WriteLine($"уся інформація збереженна у {filePath}");
            }
            else
            {
                Console.WriteLine("Уся інформація про автомобілей не була збережена.");
            }


            Console.WriteLine("Program ended.");
        }
    }
}
