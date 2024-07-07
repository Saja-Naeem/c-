using Task_5__C_;

internal class Program
{
    private static void Main(string[] args)
    {
        /************************** Q1 ******************************/
        Console.WriteLine("Q1 : ");
        Class1 class1 = new Class1();
        class1.print1("MyClass class has initialized!");
        /************************** Q2 ******************************/
        Console.WriteLine("Q2 : ");
        string name = "scott";
        class1.print2(name);
        /************************** Q3 ******************************/
        Console.WriteLine("Q3 : ");
        Console.WriteLine("Enter number : ");
        int number = Convert.ToInt32(Console.Read());
        Console.WriteLine($"factorial number of {number} is {class1.factorial(number)}");
        /************************** Q4 ******************************/
        Console.WriteLine("Q4 : ");
        int[] arr = { 11, -2, 4, 35, 0, 8, -9 };
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} , ");
        }
        Console.WriteLine();
        /************************** Q5 ******************************/
        Console.WriteLine("Q5 : ");
        DateTime date1 = new DateTime(1981, 11, 03);
        DateTime date2 = new DateTime(2013, 09, 04);
        var date3 = date2 - date1;
        int year = date3.Days / 365;
        int month = (date3.Days % 365) / 30;
        int day = (date3.Days % 365) % 30;
        Console.WriteLine($"year : {year}, month : {month}, days : {day}");
        /************************** Q6 ******************************/
        Console.WriteLine("Q6 : ");
        string dateString = "12-08-2004";

        int day2 = int.Parse(dateString.Substring(0, 2));   
        int month2 = int.Parse(dateString.Substring(3, 2)); 
        int year2 = int.Parse(dateString.Substring(6, 4));    

        DateTime date = new DateTime(year2, month2, day2);
        Console.WriteLine($"Converted Date: {date:yyyy/MM/dd}");

    }
}