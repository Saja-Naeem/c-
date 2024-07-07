using System;
using System.ComponentModel;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static void printForLoop(string[]arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
        Console.WriteLine();
    }
    public static void printForeachLoop(string[] arr)
    {
        foreach (string item in arr)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine();
    }
    public static void PrintOddNumber()
    {
        int sum = 0;
        Console.WriteLine("The odd numbers are1: ");
        for(int i=1; i <= 100; i++)
        {
            if(i%2 != 0)
            {
                Console.Write($"{i}, ");
                sum += i;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"The Sum of odd Numbers is: {sum}");

    }
    public static void PrintAsterisk()
    {
        int rows = 3; 
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" "); 
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write("*"); 
            }

            Console.WriteLine(); 
        }
    }
    public static void printNumbers()
    {
        int rows = 4; 
        int num = 1; 
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" "); 
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(num + " "); 
                num++; 
            }

            Console.WriteLine(); 
        }
    }
    private static void Main(string[] args)
    {
        /************************************** Q1 ******************************************/
        //1 - Correct the syntax error:

        //•	string[] ARR = [1, 7  9  45,] --> correct : string[] ARR = { "1", "7", "9", "45" }; or int[] ARR = [1, 7  9  45];
        //•	int arr2 = ["Str" "alex","moh" --> correct : string[] arr2 = {"Str" "alex","moh"}
        //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ] --> correct : string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
        /************************************** Q2 ******************************************/
        Console.WriteLine($"Q2 : ");
        //2 - What the index of "Banana","Tomato" ?
        //string[ ]  fruits = ["Tomato", "Banana", "Watermelon"] -->answer: index of Banana:1 , Tomato: 0
        string[] fruits = ["Tomato", "Banana", "Watermelon"];
        for (int i = 0; i < fruits.Length; i++)
        {
            if (fruits[i] == "Banana")
                Console.WriteLine($"index of Banana : {i} ");
            if (fruits[i] == "Tomato")
                Console.WriteLine($"index of Tomato : {i} ");
        }

        /************************************** Q3 ******************************************/
        Console.WriteLine($"Q3 : ");

        //3 - Create an multiple arrays that represents your:
        //•	Favorite Food(5 item)
        //•	Favorite Sport(3 item)
        //•	Favorite Movie(4 item)
        //Then, print each array using foreach, and Loop Through an Array
        string[] Food = ["Tomato", "Banana", "Watermelon", "Apple", "Graps"];
        string[] Sport = ["Football", "Tiniss", "bascketball"];
        string[] Movie = ["movie1", "movie2", "movie3", "movie4"];

        Console.WriteLine("print Food with for loop : ");
        printForLoop(Food);
        Console.WriteLine("print Food with foreach loop : ");
        printForeachLoop(Food);

        Console.WriteLine("print Sport with for loop : ");
        printForLoop(Sport);
        Console.WriteLine("print Sport with foreach loop : ");
        printForeachLoop(Sport);

        Console.WriteLine("print Movie with for loop : ");
        printForLoop(Movie);
        Console.WriteLine("print Movie with foreach loop : ");
        printForeachLoop(Movie);

        /************************************** Q4 ******************************************/
        Console.WriteLine($"Q4 : ");

        // 4 - Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
        //•	Expected Output:
        //•	Input three numbers separated by comma: 5,10,15
        //•	The sum of three numbers: 30.

        int num1, num2, num3, sum = 0;
        Console.Write("Input three numbers separated by comma: ");
        string str = Console.ReadLine();
        string[] num = str.Split(',');
        num1 = int.Parse(num[0].Trim());
        num2 = int.Parse(num[1].Trim());
        num3 = int.Parse(num[2].Trim());

        sum = num1 + num2 + num3;
        Console.WriteLine($"The sum of three numbers: {sum}");

        /************************************** Q5 ******************************************/
        Console.WriteLine($"Q5 : ");

        /* 5 - Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
       •	Test Data
       •	The odd numbers are1 3 5 7 9 11 13 15 17 19……
       •	The Sum of odd Numbers is: …...*/

        PrintOddNumber();

        /************************************** Q6 ******************************************/
        Console.WriteLine($"Q6 : ");

        //6-	Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
        //The pattern like:
        //   *
        //  **
        // ***
        PrintAsterisk();

        /************************************** Q7 ******************************************/
        Console.WriteLine($"Q7 : ");

        /*7 - Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
        The pattern like :

             1
           2 3
          4 5 6
        7 8 9 10
        */

        printNumbers();


    }
}