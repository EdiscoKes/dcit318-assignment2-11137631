using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            // Check if output is not redirected before clearing the console
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }

            Console.WriteLine("--- Console Applications ---");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GradeCalculator();
                    break;
                case "2":
                    TicketPriceCalculator();
                    break;
                case "3":
                    TriangleTypeIdentifier();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }
        }
    }

    static void GradeCalculator()
    {
        if (!Console.IsOutputRedirected)
        {
            Console.Clear();
        }
        Console.WriteLine("--- Grade Calculator ---");
        Console.Write("Enter a numerical grade (0-100): ");
        int grade;
        if (int.TryParse(Console.ReadLine(), out grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else
            {
                Console.WriteLine("Letter Grade: F");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void TicketPriceCalculator()
    {
        if (!Console.IsOutputRedirected)
        {
            Console.Clear();
        }
        Console.WriteLine("--- Ticket Price Calculator ---");
        Console.Write("Enter your age: ");
        int age;
        if (int.TryParse(Console.ReadLine(), out age))
        {
            double ticketPrice;
            if (age >= 65 || age <= 12)
            {
                ticketPrice = 7.00;
            }
            else
            {
                ticketPrice = 10.00;
            }
            Console.WriteLine($"Ticket price: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void TriangleTypeIdentifier()
    {
        if (!Console.IsOutputRedirected)
        {
            Console.Clear();
        }
        Console.WriteLine("--- Triangle Type Identifier ---");
        Console.Write("Enter the length of side 1: ");
        double side1;
        if (!double.TryParse(Console.ReadLine(), out side1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.Write("Enter the length of side 2: ");
        double side2;
        if (!double.TryParse(Console.ReadLine(), out side2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.Write("Enter the length of side 3: ");
        double side3;
        if (!double.TryParse(Console.ReadLine(), out side3))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Triangle Type: Equilateral");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Triangle Type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
        }
    }
}