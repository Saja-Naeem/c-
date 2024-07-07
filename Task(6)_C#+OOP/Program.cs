using Task_6__C__OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car("Toyota", 2024, "SUV", 30000, "RAV4", "P1234", "Blue");
        Console.WriteLine(car.carInfo());


    }
}