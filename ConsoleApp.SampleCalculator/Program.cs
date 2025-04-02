// Welcome Message
using System.ComponentModel;

Console.WriteLine("******************** Welcome To The Sample Calculator  ************************");

// Prompt for user input 
Console.WriteLine("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculator options/ Show Menu

Console.WriteLine("Please select an operation.");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int choice = Convert.ToInt32(Console.ReadLine());

/* Decide which operation is needed based on selected option
// if statements 
if (choice == 1 )
{
    // addition
}
else if (choice == 2 )
{
    // subraction
}
else if (choice == 3 )
{
    // multiplication
}
else if (choice == 4 )
{
    // division
}
else
{
    Console.WriteLine("Invalid Choice");

}*/
int answer = 0;
switch (choice)
{
    case 1: 
        // addition
        answer = num1 + num2;
        break;
    case 2:
        // subtraction
        answer = num1 - num2;
        break;
    case 3:
        // multiplication
        answer = num1 * num2;
        break;
    case 4:
        // division
        answer = num1 / num2;
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;

}
// print output
Console.WriteLine($"The result is: {answer}");