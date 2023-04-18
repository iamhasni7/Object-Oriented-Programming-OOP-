using System;

namespace ObjectOrientedProgramming
{

    // 1. Classes and Objects
    /*class MyClass
    {
        public string name;
        public int age;
    }

    class ExecuteMyClass
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.name = "Test";
            obj.age = 5;

            Console.WriteLine($"My name is {obj.name} and my age is {obj.age}.");            
        }
    }*/

    // 2. Encapsulation
    /*class Person
    {
        private string Name;
        private int Age;

        public void setName(string Name) // setter method
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is Must..");
            }
            else
            {
                this.Name = Name;
            }
        }

        public void getName() // getter method
        {
            if (string.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your name is: " + this.Name);
            }
        }

        public void setAge(int Age) // setter method
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("Age cannot be zero or negative");
            }
        }

        public void getAge() // getter method
        {
            if (Age > 0)
            {
                Console.WriteLine("Your age is: " + this.Age);
            }
            else
            {

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.setName("");
            obj.setAge(2);

            obj.getName();
            obj.getAge();
            Console.ReadLine();
        }
    }*/

    // 3. Abstraction
    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Circle();
            IShape shape2 = new Rectangle();
            shape1.Draw();
            shape2.Draw();
        }
    }
}