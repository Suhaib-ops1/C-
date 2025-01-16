
using System;

namespace firsttask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine($"read value is: {name}");

            double q = 3.45;
            Console.WriteLine(q);


            string w = "suhaib";
            Console.WriteLine(w);

            char e = 'a';
            Console.WriteLine(e);

            bool r = true;
            Console.WriteLine(r);

            int t = 9;
            Console.WriteLine(t);

            const int number = 11;
            Console.WriteLine (number);

            string[] cars = { "BMW", "TOYOTA", "HYNDAI", "MASARATI", "AUDI" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            string first_name = Console.ReadLine();
            Console.WriteLine($"Your first name is: {first_name}");

            string last_name= Console.ReadLine();
            Console.WriteLine($"Your last name is: {last_name}");

            string year_of_birth = Console.ReadLine();
            Console.WriteLine($"Year of birth: {year_of_birth}");

            Console.WriteLine($"{first_name} {last_name} {year_of_birth}");


            string[] numbers= new string[10];
            for (int i = 0; i < numbers.Length; i++) { 
                
                numbers[i] = Console.ReadLine();
            }
            //foreach (string car1 in numbers) 
            //{
            //    Console.WriteLine("the elements in array are: "+car1);
            //}

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("the elements in array {0} are : {1} ",i ,numbers[i]);
            }

        }
    }
}
