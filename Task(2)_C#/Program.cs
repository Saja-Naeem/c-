using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        /********************* #1 **************************/
        Console.Write("enter number one : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter number two : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("smaller number is : ");
        if (num1 < num2)
            Console.WriteLine(num1);
        else
            Console.WriteLine(num2);

        /********************* #2 **************************/
        Console.Write("enter number : ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"The sign is : ");
        if (num3 < 0)
            Console.WriteLine("-");
        else
            Console.WriteLine("+");
        /******************** #3 *************************/
        Console.Write("enter number  : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter number : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter number : ");
        int c = Convert.ToInt32(Console.ReadLine());
        int[] arr = { a, b, c };
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        /********************* #4 **************************/
        int[] maxArr = { -5, -2, -6, 0, -1 };
        Console.WriteLine($"max number in array : {maxArr.Max()}");
        /********************* #5 **************************/
        Console.Write("enter number of km : ");
        int km = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{km} km =  {km / 1.609344} miles per hour");


        /********************* #6 **************************/
        Console.Write("Input hours : ");
        int hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input minutes : ");
        int minuits = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Total : {hour * 60 + minuits}");

        /********************* #7 **************************/
        Console.Write("Input minutes : ");
        int minuits2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Total : {minuits2 / 60} Hours, {minuits2 % 60} Minutes");

        /********************* #8 **************************/
        string[] sentence = new string[] {
        "saja naim aldbary","I'm happy", "how are you", "goooooooooooooo", "you can do it"
        };
        int fixedLength = 7;
        for (int i = 0; i < sentence.Length; i++)
        {
            Console.WriteLine(sentence[i].Substring(0, fixedLength));
        }

        /********************* #9 **************************/

        string sentences = Console.ReadLine();
        string[] ss = sentences.Split(' ');
        char temp;
        for (int i = 0; sentences.Length > 0; i++)
        {
            if (ss[i].Length % 2 != 0) //odd
            {
                char[] ch = ss[i].ToCharArray();
                Array.Reverse(ch);
                ss[i] = new string(ch);
                
            }

        }
        foreach (var word in ss)
        {
            Console.WriteLine(word);
        }


    }
}