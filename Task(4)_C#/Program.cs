using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static double Sum(double[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++) 
        { 
            sum += arr[i];
        }
        return sum;
    }
    public static int cube( int i)
    {
        return i*i*i;

    }
    public static int yearsToDayes(int year)
    {
        Console.WriteLine();
        return year * 356;
    }
    public static int animals(int a, int b, int c)
    {
        return a*2 + b*4 + c*4;
    }
    public static int Power(int num)
    {
        return num * num;
    }
    public static List<int> leapYear()
    {
        List<int> list = new List<int>();
        for (int i = 1900; i <= 2024; i++)
        {
            if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
            {
                list.Add(i); 
            }
        }
        return list;
    }
    public static int numberOfWords(string sentence)
    {
        string[] word = sentence.Split(" ");
        return word.Length;
    }
    public static void primeNumber(int n)
    {
        int  flag = 0, m = 0;
        m = n / 2;
        for (int i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                Console.Write("Number is not Prime.");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("Number is Prime.");
    }
    public static List<int> getYears(int[] arr)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 1950) 
            {
                list.Add(arr[i]);
            }
        }
        return list;
    }
    private static void Main(string[] args)
    {


        /**************************** Q1 **********************/
        /*1-	 Write a function in C# that accept 10 numbers and return sum and average.
        •	Test Data :
        •	Input the 10 numbers :
        •	Number-1 :2
        •	Number-10 :2
        •	Expected Output :
        •	The sum of 10 no is : 55
        •	The Average is : 5.500000
        */
        Console.WriteLine("Q1 :");
        double[] arr = new double[10];
        Console.WriteLine("Input the 10 numbers :");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Number -{i + 1}:");
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"The sum of 10 no is : {Sum(arr)}");
        Console.WriteLine($"The Average is :  {Sum(arr) / 10.0}");

        /**************************** Q2 **********************/
        /*2-	Write a program in C to display the cube of the number up to given an integer.
        •	Test Data:
        •	Input number of terms : 5
        •	Expected Output :
        •	Number is : 1 and cube of the 1 is :1
        •	Number is : 2 and cube of the 2 is :8
        •	Number is : 3 and cube of the 3 is :27
        •	Number is : 4 and cube of the 4 is :64
        •	Number is : 5 and cube of the 5 is :125
        */
        Console.WriteLine("Q2 :");
        Console.WriteLine("Input number of terms : ");
        int terms = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= terms; i++)
        {
            Console.WriteLine($"Number is : {i} and cube of the 1 is :{cube(i)}");
        }

        /**************************** Q3 **********************/
        /*3-	Write a program in C# return only numbers in the years array greater than 1950.

        const years = [1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020]

        function getYears(years)
         {

        }
        */
        Console.WriteLine("Q3 :");
        int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
        List<int> list = getYears(years);
        Console.WriteLine("Years greater than 1950:");
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
        /**************************** Q4 **********************/
        /*4-	Create a function that takes the age in years and returns the age in days.*/
        Console.WriteLine("Q4 :");
        Console.WriteLine($"enter your age in year : ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"your age in days : {yearsToDayes(year)}");
        /**************************** Q5 **********************/
        /*5-	a farmer is asking you to tell him how many legs can be counted among all his animals. The farmer breeds three species:
        a.	chickens = 2 legs
        b.	cows = 4 legs
        c.	pigs = 4 legs
        */
        Console.WriteLine("Q5 :");
        Console.Write("Enter number chicken : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Cows : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Pigs : ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write($"number of all legs : {animals(a, b, c)}");


        /**************************** Q6 **********************/
        /*6-	create function login, that accept two parameters and return pass or failed for success login. 
        •	You must predefine some users in to be pass in array inside the function
        */
        Console.WriteLine("Q6 :");

        /**************************** Q7 **********************/
        /*7-	Create function that calc the power of numbers.*/
        Console.WriteLine("Q7 :");
        Console.WriteLine("Enter number to find the power : ");
        int num = Convert.ToInt32(Console.Read());
        Console.WriteLine($"The power of number {num} is : {Power(num)}");
        /**************************** Q8 **********************/
        /*8-	Create function that accept year from range 1900-2024 and return the leap year.*/
        Console.WriteLine("Q8 :");

        List<int> lista = leapYear();
        foreach (int item in lista)
        {
            Console.WriteLine(item);
        }
        /**************************** Q9 **********************/
        /*9-	Create function that accept number to check the prime numbers.*/
        Console.WriteLine("Q9 :");
        Console.Write("Enter the Number to check Prime: ");
        int n = Convert.ToInt32(Console.ReadLine());
        primeNumber(n);
        /**************************** Q10 **********************/
        /*10-	Create function that accept a sentence, and return the number of words without using the extended method(count)*/
        Console.WriteLine("Q10 :");
        Console.WriteLine("enter sentecnce : ");
        string sentence = Console.ReadLine();
        Console.WriteLine($"number of words : {numberOfWords(sentence)}");

    }
}