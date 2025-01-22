/* 
 * 22_1_2025
Base Class: Vehicle
•	Properties:
o	Brand (string): The brand of the vehicle.
o	Model (string): The model of the vehicle.
•	Method:
o	Start(): A  method that prints "Vehicle is starting."
 Derived Class: Car
•	Additional Property:
o	NumberOfDoors (int): The number of doors in the car.
 
1-	In the main 
-	Create object from car and Vehicle in the main 
-	Convert the Vehicle class to sealed , see the result 

What is constructor: it has the same name as the class and we create it to give inital values for the proparties
What are the basic concepts of OOPs? inhertince -- encaspulation -- polymorphism -- abstract 
What is the Encapsulation? practice of hiding the internal details of a class and only exposing necessary parts through methods or properties. It protects the data by restricting direct access and allows controlled interaction.What is the sealed class
What is the Inheritance concept? it is all about creating 2 classes where we have a parent class and child class (super class, sub class || base class , derived class) where we can use the comon proparties that are in the parent in the child to minimze our code and for error handling it is better
*/

using System;

   /* sealed */ class Vehicle
{
   public string brand {  get; set; }
    public string model { get; set; }

    public void start()
    {
        Console.WriteLine($"Vehicle is starting. \n {brand} \n {model} ");

    }
}

   class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        Vehicle v = new Vehicle();
        Car car = new Car();
        car.brand = "BMW";
        car.model = "latest model";
        car.NumberOfDoors = 10;
        car.start();
    
    }
}