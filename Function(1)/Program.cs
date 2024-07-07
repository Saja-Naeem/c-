using System.Text.Json.Serialization;

internal class Program
{
    public static int convertToSecond(int minuites)
    {
    return Convert.ToInt32(minuites*60); 
    }
    public static double increment(double num)
    {
        return (double)num+1;
    }
    public static double returnFirstIndex(int[] arr)
    {
        return arr[0];
    }
    public static double traiangleAria(double Base , double height)
    {
        return Base*height*0.5;
    }
    public static int[] evenNumberEvenIndex(int[] arr)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++) { 
            if(arr[i]%2 == 0 && i%2 ==0) 
                list.Add(arr[i]);
        }
        return list.ToArray();
    }
    public static string[] evenIndexOddLength(string[] arr)
    {
        List<string> list = new List<string>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length%2 !=0 && i % 2 == 0)
                list.Add(arr[i]);
        }
        return list.ToArray();
    }
    public static int multi2(int a, int b)
    {
        int result = 1;
        for (int i = a; i <= b; i++)
        {
            result *= i;
        }
        return result;
    }
    public static double multiplication(double num1, double num2)
    {
        return num1 * num2;
    }
    public static double aveArray(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }
    public static int[] powerElementIndex(int[] arr) 
    {
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            
            list.Add((int)Math.Pow(arr[i],i));
        }
        return list.ToArray();
    }
    private static void Main(string[] args)
    {
        /************************** Q1 ***************************/
        Console.WriteLine("Q1");
        Console.WriteLine("Enter minuites : ");
        int minuites = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{minuites} minuites = {convertToSecond(minuites)} seconds.");
        /************************** Q2 ***************************/
        Console.WriteLine("Q2");
        Console.WriteLine("Enter number to incriment : ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{num} after incriment = {increment(num)}");
        /************************** Q3 ***************************/
        Console.WriteLine("Q3");
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, };
        Console.WriteLine($"the first index of array is : {returnFirstIndex(numbers)}");
        /************************** Q4 ***************************/
        Console.WriteLine("Q4");
        Console.Write("Enter the base :");
        double Base = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height :");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Aria of triangle is : {traiangleAria(Base, height)}");
        /************************** Q5 ***************************/
        Console.WriteLine("Q5");
        int[] nums = new int[] { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
        int[] nums2 = evenNumberEvenIndex(nums);
        for (int i = 0; i < nums2.Length; i++)
        {
            Console.Write($"{nums2[i]},");
        }
        Console.WriteLine();
        /************************** Q6 ***************************/
        Console.WriteLine("Q6");
        string[] strings = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
        string[] strings2 = evenIndexOddLength(strings);
        for (int i = 0; i < strings2.Length; i++)
        {
            Console.Write($"{strings2[i]},");
        }
        Console.WriteLine();
        /************************** Q7 ***************************/
        Console.WriteLine("Q7");
        int[] arrNum = {44, 5, 4, 3, 2, 10};
        int[] arrNum2 = powerElementIndex(arrNum);
        for (int i = 0;i < arrNum2.Length; i++)
        {
            Console.Write($"{nums2[i]},");
        }
        /************************** Q8 ***************************/
        Console.WriteLine("Q8");
        Console.Write("Enter first number :");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number :");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"muti2({num1}, {num2}) is : {multiplication(num1, num2)}");

        /************************** Q9 ***************************/
        Console.WriteLine("Q9");
        Console.Write("Enter first number :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number :");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"muti2({a}, {b}); =>{multi2(a, b)}");
        /************************** Q10 ***************************/
        Console.WriteLine("Q10");
        int[] arr = { 1, 2, 3, 8, 9 };
        Console.WriteLine($"avarage of array : {aveArray(arr)}");

    }
}