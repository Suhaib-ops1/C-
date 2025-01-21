
/* 1.	Create a Student Class:
o	Create a class named Student with the following:
	A property named Name of type string to represent the student's name.
	A property named Age of type int to represent the student's age.
	A property named StudentID of type int to represent the student's ID.
	Add an auto property named Email to represent the student’s email.
2.	Add Constants:
o	Add a constant named MinAge to represent the minimum allowed age for a student (18 years).
o	Add a constant named MaxAge to represent the maximum allowed age for a student (40 years).
3.	Add a Method:
o	Add a method named GetDetails that displays a message containing the student’s name, age, and ID.
4.	Create Objects:
o	Create an object from the Student class with the following values:
	Name: "Ahmad"
	Age: 22
	Student ID: 1001
o	Call the GetDetails method for the object.
________________________________________
 Add these Concepts
1.	Add a Constructor:
o	Add a constructor to the Student class that:
	Accepts the name, age, and student ID as parameters.
	Updates the class fields with the given values.
2.	Add a Destructor:
o	Add a destructor to the Student class that prints a message when the object is deleted.
3.	Implement Encapsulation:
o	Make all fields in the Student class private. (if we have field )
o	Add Getters and Setters to control access to these fields.
4.	The Four OOP Principles:
o	Demonstrate Encapsulation by making student data private and using Getters and Setters.
________________________________________
Additional Instructions:
1.	Examples:
o	Create two new objects of the Student class.
o	Display their details using the GetDetails method.
2.	Code Comments:
o	Add comments to the code to explain each step.
*/
using System;

namespace task4
{
    internal class Program
    {

        class Student  // created a new class 
        {
            public const int MinAge = 18; // created a constant to hold the value of the minimum age of the students 
            public const int MaxAge = 40; // created a constant to hold the value of the maximum age of the students 
            public string Name { get; set; } // created auto property using set and get which resmbels the encapsulation. 

            private int age;
            public int Age
            {
                get
                {
                    return age;

                }
                set
                {
                    if (value < 18 || value > 40)
                    {
                        age = 18;
                    }
                    else
                    {
                        age = value;
                    }
                }
            }// created auto property using set and get which resmbels the encapsulation. 
            public int studentId { get; set; } // created auto property using set and get which resmbels the encapsulation. 
            public string Email { get; set; } // created auto property using set and get which resmbels the encapsulation. 

            public Student() // created a default constructor to give intial values to the proparties 
            {
                Name = string.Empty; // gave intial value for Name property
                Age = 0; // gave intial value for Age property
                studentId = 0; // gave intial value for studentId property
            }
            public void GetDetails() // created a method 
            {
                Console.WriteLine($"student’s name: {Name}\n age: {Age}\n ID: {studentId}"); // printed the vlaues of the propties using interpolation inside the method
            }
            public Student(string Name, int _Age, int studentId) // created a constructor that accepts 3 parameters 
            {
                this.Name = Name; // set the value of each property to equal the value that i will send in the parameters of the created objects that has parameters
                this.Age = Age; // same as above 

                if (_Age < 18 || _Age > 40)
                {
                    this.Age = 18;
                }
                else
                {
                    this.Age = _Age;
                }
                this.studentId = studentId; // same as above 

            }
            ~Student() { Console.WriteLine("You are done!"); } // created a destructor to delete all the cached data that were used in the objects
        }

        static void Main(string[] args)
        {
            Student student = new Student(); // created an obj of the class Student that is named student 
            student.Name = "Ahmad"; // updated the intial value of the student(obj) name 
            student.Age = 22; // updated the intial value of the student(obj) Age
            student.studentId = 1001; // updated the intial value of the student(obj) studentId
            student.GetDetails();
            Student student1 = new Student("suhaib", 27, 9); // created an obj and sent values with it 
            student1.GetDetails(); // called the method 
            Student student2 = new Student("Adnan", 13, 8); // created an obj and sent values with it 
            student2.GetDetails();

        }
    }
}
