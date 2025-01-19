using System;

class Program
{
    static void Main(string[] args)
    {
        //1 - Write a C# program that accepts a double input and converts it into an int. Display both values.
        //double a= Convert.ToDouble(Console.ReadLine()) ; 
        //Console.WriteLine(a);
        //int a1= Convert.ToInt32(a) ;
        //Console.WriteLine(a1);

        //2-	Write a program that uses a Convert.ToString() method to convert a number into a string and concatenate it with a sentence.
        //int a2= Convert.ToInt32(Console.ReadLine());
        //string a3= Convert.ToString(a2) ;
        //Console.WriteLine($"Your number is: {a3}");

        //3-	Create a string with a sentence. Use ToUpper() and ToLower() to display the uppercase and lowercase versions of the string.
        //string a4= Console.ReadLine() ;
        //string a5= a4.ToUpper() ;
        //Console.WriteLine(a5);

        //4-	Write a program that takes a user's full name as input and prints
        //string fname= Console.ReadLine() ;
        //Console.WriteLine($"First name is: {fname}");
        //string lname= Console.ReadLine() ;
        //Console.WriteLine($"Last name is: {lname}");
        //string total= fname + " " + lname ;
        //Console.WriteLine($"Total Characters: {total.Length}");

        // 5-	Write a program that accepts two integers and prints the smaller of the two.
        //int s= Convert.ToInt32(Console.ReadLine()) ;
        //int s1= Convert.ToInt32(Console.ReadLine());
        //if (s < s1)
        //{
        //    Console.WriteLine($"smaller number: {s}");
        //}
        //else
        //{
        //    Console.WriteLine($"smaller number: {s1}");
        //}

        // Write a method that converts kilometers per hour to miles per hour. Use this method in a program to convert and display the result.
        //double k= Convert.ToDouble(Console.ReadLine()) ;
        //double result = k / 1.6093446;
        //Console.WriteLine(result);

        // 7-	Write a method that takes hours and minutes as input and returns the total number of minutes.
        //double h = Convert.ToDouble(Console.ReadLine());
        //double h1 = h * 60;
        //double h2 = Convert.ToDouble(Console.ReadLine());
        //double h3 = h1 + h2;
        //Console.WriteLine(h3);

        // 8-	Write a method that accepts minutes as input and calculates the total number of hours and minutes.
        //int m1= Convert.ToInt32(Console.ReadLine());
        //int m2 = m1 / 60;
        //int m3 = m1 % 60;
        //Console.WriteLine($"{m2} Hours, {m3} minutes");

        // 9-	Compare Two Numbers 
        //int f1= Convert.ToInt32(Console.ReadLine());
        //int f2= Convert.ToInt32(Console.ReadLine());
        //string result = (f1 == f2) ? "Equal" :
        //               (f1 > f2) ? "Greater" :
        //               (f1 <f2) ? "Smaller" : $"{f2}";
        //Console.WriteLine(result);

        // Write a program that calculates the sum of the digits of a number using arithmetic 

        //string new1 = Console.ReadLine();
        //int sum = 0;
        //for (int i = 0; i < new1.Length; i++)
        //{
        //    int v = Convert.ToInt32(new1[i].ToString());
        //    sum += v;


        //}
        //Console.WriteLine(sum);

        //10-	Reverse a Number
        //string straight= Console.ReadLine();
        //string reverse="";
        //for (int i = straight.Length - 1; i >= 0; i--)
        //{
        //    reverse+= straight[i].ToString();
        //}
        //Console.WriteLine(reverse);


        // Check Divisibility  
        //string j1= Console.ReadLine();
        //string j2= Console.ReadLine();  
        //int l1= Convert.ToInt32(j1);
        //int l2= Convert.ToInt32(j2);
        //if (l1 % l2 == 0)
        //{
        //    Console.WriteLine("Divisable");
        //}
        //else {
        //    Console.WriteLine("Not Divisable");
        //}

        // 12-	Find the Middle Value

        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        // Variable to store the middle value
        int middle;

        // Logic to find the middle value
        if ((num1 > num2 && num1 < num3) || (num1 > num3 && num1 < num2))
        {
            middle = num1;
        }
        else if ((num2 > num1 && num2 < num3) || (num2 > num3 && num2 < num1))
        {
            middle = num2;
        }
        else
        {
            middle = num3;
        }

       
        Console.WriteLine($"The middle value is: {middle}");






    }
}