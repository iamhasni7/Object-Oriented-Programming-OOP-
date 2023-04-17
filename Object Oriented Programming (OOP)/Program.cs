using System;

namespace ObjectOrientedProgramming
{

    // 1. Classes and Objects
    class MyClass
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
    }
}