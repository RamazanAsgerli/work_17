using System.Text.Json;
using System.Text.Json.Serialization;

namespace task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Name = "BMW",
                Model = "F10",
                Color = "Black",
                Price = 28000
            };
            string carSer = JsonSerializer.Serialize(car);
            Console.WriteLine(carSer);

            string json = "{\"Name\":\"BMW\",\"Model\":\"F10\",\"Color\":\"Black\",\"Price\":28000}";
            Car car1 = JsonSerializer.Deserialize<Car>(json);
            Console.WriteLine($"Name: {car.Name}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Color: {car.Color}");
            Console.WriteLine($"Price: {car.Price}");

        }
    }
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public int Price { get; set; }
    }
}
