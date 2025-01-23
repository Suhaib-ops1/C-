using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Overloading:  
•	Create a Calculator class with methods to add:
o	Two integers.
o	Three integers.
o	Two double values.
•	Write a program to demonstrate method overloading.
-----------------------------------------------------------------------------------------------------------------------------------------
Overriding:
 Create a Shape class with a method draw(). Create two child classes:
•	Circle that overrides draw() to print "Drawing a Circle."
•	Rectangle that overrides draw() to print "Drawing a Rectangle."
  Write a program to demonstrate method overriding and invoke methods polymorphically using a base class reference.
----------------------------------------------------------------------------------------------------------------------------------------
Abstract Class
1.	Create an abstract class Animal with:
o	An abstract method makeSound().
o	A concrete method sleep() that prints "Animal is sleeping."
o	Create two concrete classes:
	Dog that implements makeSound() as "Dog barks."
	Cat that implements makeSound() as "Cat meows."
o	Write a program to demonstrate the use of abstract classes.
-----------------------------------------------------------------------------------------------------------------------------------------
Interface
1.	Create an interface Playable with:
o	A method play().
o	Implement this interface in two classes:
	Guitar that implements play() as "Playing the guitar."
	Piano that implements play() as "Playing the piano."
o	Write a program to demonstrate the use of interfaces and polymorphism by calling play().
*/

namespace Task_6
{
    internal class Program
    {
        interface Playable
        {
            void Play();
        }
        class Guitar : Playable
        {
            public void Play() {
                Console.WriteLine("Playing the guitar.");
            }
        }

        class Piano : Playable 
        {
            public void Play() {
                Console.WriteLine("Playing the piano.");
            }
        }














        abstract class Animal
        {
            public abstract void Makesound();
            public void sleep()
            {
                Console.WriteLine("Animal is Sleeping");
            }

            class Dog : Animal
            {
                public override void Makesound()
                {
                    Console.WriteLine("Dog is barking");
                }
            }
            class Cat : Animal
            {
                public override void Makesound()
                {
                    Console.WriteLine("Cat meows. ");
                }
            }
            class Calculator
            {
                public void add(int num1, int num2)
                {
                    Console.WriteLine(num1 + num2);
                }
                public void add(int num1, int num2, int num3)
                {
                    Console.WriteLine(num1 + num2 + num3);
                }
                public void add(double num1, double num2)
                {
                    Console.WriteLine(num1 + num2);
                }
            }

            class shape
            {
                public virtual void draw()
                {
                    Console.WriteLine("Let's start drawing");
                }
            }
            class Circle : shape
            {

                public override void draw()
                {
                    Console.WriteLine("Let's draw a circle");
                }
            }

            class Rectangle : shape
            {
                public override void draw()
                {
                    Console.WriteLine("Let's draw a Rectangle");
                }
            }
            static void Main(string[] args)
            {
                Calculator calc = new Calculator();
                calc.add(2, 3);
                calc.add(3, 4, 7);
                calc.add(3.4, 3.5);
                shape circle = new Circle();
                circle.draw();
                shape Rectangle = new Rectangle();
                Rectangle.draw();
                Animal Dog = new Dog();
                Dog.Makesound();
                Dog.sleep();
                Animal Cat= new Cat();
                Cat.Makesound();
                Guitar guitar = new Guitar();
                guitar.Play();
                Piano piano = new Piano();  
                piano.Play();
            }
        }
    }
}
