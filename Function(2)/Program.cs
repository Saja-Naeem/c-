using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    public static string[] stringNumber(string[] str)
    {
        List<string> list = new List<string>();
        
            for (int i = 0; i < str.Length; i++)
            {
                if (Regex.IsMatch(str[i], @"\d"))
                    list.Add(str[i]);
            }
        
        return list.ToArray();
    }
    public static string reverse_all_the_words(string str)
    {
        string[] arrString = str.Split(' ');
        for (int i = 0; i < arrString.Length; i++)
        {
            if (arrString[i].Length%2 != 0)
            {
                char[] charArray = arrString[i].ToCharArray();
                Array.Reverse(charArray);
                arrString[i] = new string(charArray);
            }
        }
        string newString = string.Join(" ", arrString);
        return newString;
        
    }
    public static int getDays(DateTime date1, DateTime date2)
    {
        var date3 = date2 - date1;
        return (int)date3.Days;
    }
    public static List<string> NumberArray(string[] str)
    {
        List<string> list = new List<string>();
        for (int i = 0; i < str.Length; i++)
        {
            bool flag = false;
            for (int j = 0; j < str[i].Length; j++)
            {
                if(str[i][j]>=48 && str[i][j] <= 57)
                {
                    flag = true;
                    break;
                }
                    
            }
            if (flag)
            {
                list.Add(str[i]);
            }
        }
        return list;
    }
    private static void Main(string[] args)
    {
        /********************** Q1 ***********************/
        Console.WriteLine("Q1 : ");
        DateTime date1 = new DateTime(2019, 6, 14);
        DateTime date2 = new DateTime(2019, 6, 20);
        Console.WriteLine($"Different between to date in days : {getDays(date1, date2)}");
        /********************** Q2 ***********************/
        Console.WriteLine("Q2 : ");
        string[] numInStr = { "1a", "a", "2b", "b" };
        string[] numInStr2 = stringNumber(numInStr);
        Console.WriteLine($"array contain number are :");
        for (int i = 0; i < numInStr2.Length; i++)
        {
            Console.Write($"{numInStr2[i]}, ");
        }
        Console.WriteLine();
        /********************** Q3 ***********************/
        Console.WriteLine("Q3 : ");
        Console.Write("Enter string : ");
        string str = Console.ReadLine();
        Console.WriteLine(reverse_all_the_words(str));
        /********************** Q4 ***********************/
        Console.WriteLine("Q4 : ");
        string[] arr = {"1a", "a", "2b", "b"};
        List<string> list = NumberArray(arr);
        Console.Write("strings has number : ");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write($"{list[i]}, ");
        }
        
    }
}