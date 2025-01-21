using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task_20_1
{
    internal class Program
    {
        static string isOdd(int x)
        {
            if (x % 2 == 0)
                return ($"{x} is even");

            else
            {
                return ($" {x} is odd");
            }
        }

        static int secSmall(int[] num)
        {
            Array.Sort(num);
            return num[1];
        }

        static int factorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            int f = 1;
            for (int i = 1; i <= x; i++)
            {
                f *= i;
            }
            return f;
        }

        static void Prims(int n1, int n2)
        {

            for (int i = n1; i <= n2; i++)
            {
                if (i == 2 || i == 3 || i == 5)
                {
                    Console.WriteLine(i);
                }
                if ((i % 2) == 0 || (i % 5 == 0) || (i % 3 == 0))
                {
                    continue;
                }

                int counter = 0;
                for (int j = 2; j <= i; j++)
                {
                    if ((i % j) == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 1)
                {
                    Console.WriteLine(i);

                }

            }
        }

        static int MaxValue(int[] numbers)
        {
            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            return max;
        }

        static string calcSum(int[] num)
        {
            int sumE = 0, sumO = 0;

            foreach (int n in num)
            {
                if (n % 2 == 0)
                {
                    sumE += n;
                }
                else
                {
                    sumO += n;
                }

            }
            return ($"sum of even: {sumE} , sum of odd: {sumO}");
        }

        static void findCommon(int[] arr1, int[] arr2)
        {
            string common = "";
            foreach (int n in arr1)
            {
                foreach (int n2 in arr2)
                {
                    if (n == n2)
                    {
                        common += n + ", ";
                    }
                }
            }
            Console.WriteLine(common);
        }

        class room
        {
            public int roomNum;
            public string type;
            public double price;
            public bool isBooked;
            public const string HotelName = "Grand Stay Hotel";
        }
        static void Main(string[] args)
        {
            //1-	Write a C# program that accepts an integer and determines if the number is even or odd. Display the result.

            Console.WriteLine("enter number to check if it odd or even:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(isOdd(num));

            ////2-	Write a C# program that accepts five numbers and displays the  2nd smallest of the five.

            int[] arr = new int[5];
            Console.WriteLine("enter five number to displays the  2nd smallest of the five :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            arr[0] = num1;
            arr[1] = num2;
            arr[2] = num3;
            arr[3] = num4;
            arr[4] = num5;
            Console.WriteLine("2nd smallest of the five: " + secSmall(arr));



            //3-	Write a program that calculates the factorial of a given number using a for loop.

            Console.WriteLine("enter number to calculates the factorial:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(number));

            //4-	Write a program that takes two integers as input and prints all the prime numbers between them using nested loops.

            Console.WriteLine("enter two integers as input and prints all the prime numbers between them using nested loops:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Prims(number1, number2);


            //5-	Create a program that initializes an integer array and finds the largest number in it using a foreach loop.

            int[] numbers = { 1, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("the largest number :" + MaxValue(numbers));

            //6-	Write a program that prints the following number pattern using nested loops:
            // For n = 5, the output should be:
            int s = 0;

            for (int i = 0; i <= 5; i++)
            {
                string Line = "";
                for (int j = 1; j <= i; j++)
                {
                    s++;
                    Line += Convert.ToString(s) + " ";
                }
                Console.WriteLine(Line);
            }

            //7-	Write a program that prints a pyramid pattern using stars (*) based on the input height. Use nested loops. (optional)

            int c = 1;
            for (int i = 0; i < 4; i++)
            {
                string line = "";
                for (int j = 0; j < i + c; j++)
                {
                    line += "* ";
                }

                Console.WriteLine(line);
                c++;
            }

            // 8 - Write a program that takes an array of integers and calculates the sum of even numbers and odd numbers separately using loops.  (optional)

            Console.WriteLine("calculate the sum of odd and even");
            int[] arr1 = { 12, 4, 6, 8, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            Console.WriteLine(calcSum(arr1));

            //Write a program that compares two arrays and prints their common elements using loops. (optional)

            int[] a1 = { 1, 2, 3, 4 };
            int[] a2 = { 3, 4, 5, 6 };

            findCommon(a1, a2);

            //----------------------------------------------------------
            Console.WriteLine("enter two room number");
            int roomid1 = int.Parse(Console.ReadLine());
            int roomid2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter two room types");
            string roomType1 = Console.ReadLine();
            string roomType2 = Console.ReadLine();

            Console.WriteLine("enter two room price");
            double roomprice1 = double.Parse(Console.ReadLine());
            double roomprice2 = double.Parse(Console.ReadLine());

            Console.WriteLine("enter two room avilability T/F");
            bool roombool1 = Convert.ToBoolean(Console.ReadLine());
            bool roombool2 = Convert.ToBoolean(Console.ReadLine());

            room room1 = new room();
            room1.roomNum = roomid1;
            room1.type = roomType1;
            room1.price = roomprice1;
            room1.isBooked = roombool1;

            room room2 = new room();
            room2.roomNum = roomid2;
            room2.type = roomType2;
            room2.price = roomprice2;
            room2.isBooked = roombool2;

            Console.WriteLine($"room1 : {room1.roomNum}, {room1.type}, {room1.price}, {room1.isBooked}, {room.HotelName}");
            Console.WriteLine($"room2 : {room2.roomNum}, {room2.type}, {room2.price}, {room2.isBooked}, {room.HotelName}");

        }
    }
}
