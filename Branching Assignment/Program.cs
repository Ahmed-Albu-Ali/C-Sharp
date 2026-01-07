using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for the weight of the package
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());  // Convert the input to double

        // Check if weight exceeds the limit of 50
        if (weight > 50)
        {
            // If the weight is too heavy, display an error message and exit the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;  // Exit the program
        }

        // Prompt user for the width of the package
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());  // Convert the input to double

        // Prompt user for the height of the package
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());  // Convert the input to double

        // Prompt user for the length of the package
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());  // Convert the input to double

        // Check if the total dimensions (width + height + length) exceed 50
        if (width + height + length > 50)
        {
            // If the total dimensions are too large, display an error message and exit the program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;  // Exit the program
        }

        // Calculate the quote by multiplying the three dimensions and the weight, then dividing by 100
        double quote = (width * height * length * weight) / 100;

        // Display the calculated shipping quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank the user
        Console.WriteLine("Thank you!");
    }
}
