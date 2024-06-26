internal class Program
{
    private static void Main(string[] args)
    {
        /********************* #1 **********************/
        Console.Write("Enter string : ");
        string str = Console.ReadLine();
        Console.WriteLine($"{str}");

        /******************** #2 *********************/
        double height = 4.3;
        string name = "saja";
        bool isStudent = false;
        char grade = 'A';
        const double pi = 3.14;
        Console.WriteLine($"Name:{name}, heigth:{height}, grade:{grade}, pi:{pi} , is student:{isStudent} ");

        /******************** #3 *********************/
        string[] car = new string[] { "bmw", "ford", "ferrari" };
        Console.Write($"element of array car : ");
        for (int i = 0; i < car.Length; i++)
        {
            Console.Write($"{car[i]} ,");
        }
        Console.WriteLine();
        Console.WriteLine($"length of car array : {car.Length}");

        /******************** #4 *********************/
        Console.Write("Input your firstname: ");
        string firstName = Console.ReadLine();
        Console.Write("Input your lastname: ");
        string surName = Console.ReadLine();
        Console.Write("Input your year of birht: ");
        int yearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{firstName} {surName} {yearOfBirth}");

        /******************** #5 *********************/
        int[] element = new int[10];
        Console.WriteLine("Input 10 element in the array : ");
        for (int i = 0; i < element.Length; i++)
        {
            Console.Write($"element-{i} : ");
            element[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write($"Elements in array are: ");
        for (int i = 0; i < element.Length; i++)
        {
            Console.Write($"{element[i]} ");
        }
        /********************* #6 **********************/
        int[] test = new int[] { 2, 5, 8 };
        int sum = 0;
        for (int i = 0; i < test.Length; i++)
        {
            sum += test[i];
        }
        Console.WriteLine($"Sum of all elements stored in the array is : {sum}");



    }
}