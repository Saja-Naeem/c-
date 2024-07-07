using System.ComponentModel;
using System.Data;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static string trailing_and_leading_zeros(string num)
    {
        num = num.TrimStart('0');
        num = num.TrimEnd('0');
        return num;
    }
    public static int second_largest_number(int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Length-2];
    }
    public static bool isRepdigit(int num)
    {
        bool flag = true;
        string newNum = num.ToString();
        if (num % 2 != 0)
        {
            return false;
        }
        else
        {
            char a = newNum[0];
            for (int i = 0; i < newNum.Length; i++)
            {
                if (a != newNum[i])
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
    public static string reverse_word(string str)
    {
        string[] parts = str.Trim().Split(' ');
        Array.Reverse(parts);
        string reversedString = string.Join(" ", parts);
        return reversedString;


    }
    static string FindSeven(int[] numbers)
    {
        foreach (int num in numbers)
        {
            if (ContainsDigit(num, 7))
            {
                return "Boom!";
            }
        }
        return "there is no 7 in the array";
    }
    public static bool ContainsDigit(int number, int digit)
    {
        while (number != 0)
        {
            int remainder = number % 10;
            if (remainder == digit)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
   /* public static string white_space(string str)
    {
        List<string> words = new List<string>();
        for (int i = 1;i < str.Length; i++)
        {
            if (str[i] == str.ToUpper()[i])
            {
                str = str + " ";
            }
        }
        return str;
    }*/
    public static int countTrue(bool[] bools)
    {
        int count = 0;
        for (int i = 0; i< bools.Length; i++)
        {
            if (bools[i])
                count++;
        }
        return count;
    }
    public static string capToFront(string capStr)
    {
        List<char> list = new List<char>();
        for (int i = 0; i < capStr.Length; i++)
        {
            if(capStr[i] == capStr.ToUpper()[i])
            {
                list.Add(capStr[i]);
            }
        }
        for (int i = 0; i < capStr.Length; i++)
        {
            if (capStr[i] == capStr.ToLower()[i])
            {
                list.Add(capStr[i]);
            }
        }
        string s1 = string.Join("", list);
        return s1;
    }
    public static bool matchLastItem(string[] match)
    {
        string last = match[match.Length - 1];
        string newString = "";
        for (int i = 0; i < match.Length-1; i++)
        {
            newString += match[i];
        }
        if(newString ==  last)
            return true;
        return false;

    }
    public static int FindNaN(double[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (Double.IsNaN(numbers[i]))
            {
                return i;
            }
        }
        return -1;
    }
    public static void removeDups(string[] duplicate)
    {
        string[] unique = duplicate.Distinct().ToArray();
        for (int i = 0; i < unique.Length; i++)
        {
            Console.Write($"{unique[i]}, ");
        }
        Console.WriteLine();
    }
    



    public static double sumOfCubes(double[] cube)
    {
        double sum = 0;
        for (int i = 0; i < cube.Length; i++)
        {
            sum += Math.Pow(cube[i],3);
        }
        return sum;
    }
    public static string removeLastVowel(string str)
    {
        string[] words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            words[i]=words[i].TrimEnd(words[i].Last());
        }
        string newString = string.Join(" ", words);
        return newString;
    }
    private static void Main(string[] args)
    {
        /********************* Q1 ************************/
        Console.WriteLine("Q1 : ");
        Console.Write("Enter first number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Add({a},{b}) = {Add(a, b)}");
        /********************* Q2 ************************/
        Console.WriteLine("Q2 : ");
        string num = "001122300";
        Console.WriteLine($"string before trailing and leading zeros : {num} , after : {trailing_and_leading_zeros(num)}");
        /********************* Q3 ************************/
        Console.WriteLine("Q3 : ");
        int[] arr = [10, 40, 30, 20, 50];
        Console.WriteLine($"Second largest number in array is : {second_largest_number(arr)}");
        /********************* Q4 ************************/
        Console.WriteLine("Q4 : ");
        int number = 4444;
        Console.WriteLine($"is {number} Repdigit number ? {isRepdigit(number)}");
        /********************* Q5 ************************/
        Console.WriteLine("Q5 : ");
        string str = "the sky is blue";
        Console.WriteLine($"reverse string ({str}) is : {reverse_word(str)}");

        /********************* Q6 ************************/
        Console.WriteLine("Q6 : ");
        int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
        int[] numbers2 = { 7, 9, 5, 4, 5, 6 };
        int[] numbers3 = { 11, 12, 13, 14, 45, 26, 74 };

        Console.WriteLine($"(1, 2, 3, 4, 5, 6) is {FindSeven(numbers1)}");
        Console.WriteLine($"(7, 9, 5, 4, 5, 6) is {FindSeven(numbers2)}");
        Console.WriteLine($"(11, 12, 13, 14, 45, 26, 74) is {FindSeven(numbers3)}");

        /********************* Q7 ************************/
        Console.WriteLine("Q7 : ");
        /********************* Q8 ************************/
        Console.WriteLine("Q8 : ");
        bool[] bools = { true, false, false, true, false };
        Console.WriteLine($"number of true values : {countTrue(bools)}");
        /******************** Q9 ************************/
        Console.WriteLine("Q9 : ");
        string capStr = "hApPy";
        Console.WriteLine($"capToFront(hApPy) --> {capToFront(capStr)}");
        /********************* Q10 ************************/
        Console.WriteLine("Q10 : ");
        string[] match = { "rsq", "6hi", "g", "rsq6hig" };
        Console.WriteLine(matchLastItem(match));
        /********************* Q11 ***********************/
        Console.WriteLine("Q11 : ");
        double[] array = [1, 2, double.NaN];
        Console.WriteLine($"index of NAN element is : {FindNaN(array)}");
        /********************* Q12 ************************/
        Console.WriteLine("Q12 : ");
        string[] duplicate = { "The", "big", "cat", "The" };
        removeDups(duplicate);
        /********************* Q14 ************************/
        Console.WriteLine("Q14 : ");
        string removeStr = "Those who dare to fail miserably can achieve greatly";
        Console.WriteLine(removeLastVowel(removeStr));
        /********************* Q15 ************************/
        Console.WriteLine("Q15 : ");
        double[] cube = { 1, 5, 9 };
        Console.WriteLine($"sum of cube [1,5,9] is : {sumOfCubes(cube)}");

    }
}