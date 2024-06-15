

namespace ConsoleApp39
{
    public class Car
    {
        public string Brand { get; set; }
        public int YearOfManufacture { get; set; }
        public string Model { get; set; }
        public string AdditionalInfo { get; set; }

        public Car(string brand, int yearOfManufacture, string model, string additionalInfo)
        {
            Brand = brand;
            YearOfManufacture = yearOfManufacture;
            Model = model;
            AdditionalInfo = additionalInfo;
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Year: {YearOfManufacture}, Model: {Model}, Info: {AdditionalInfo}";
        }
    }
}
