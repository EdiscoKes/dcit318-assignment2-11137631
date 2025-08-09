using System;
using dcit318_assignment2_11137631.Inheritance;
using dcit318_assignment2_11137631.AbstractClasses;
using dcit318_assignment2_11137631.Interfaces;

namespace dcit318_assignment2_11137631
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding ===");
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            Console.WriteLine("\n=== Abstract Classes and Methods ===");
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");

            Console.WriteLine("\n=== Interfaces ===");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}
