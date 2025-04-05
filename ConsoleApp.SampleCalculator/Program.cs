// Welcome Message
using System.ComponentModel;

Console.WriteLine("******************** Welcome To The Sample Calculator  ************************");

// Show calculator options/ Show Menu

Console.WriteLine("Please select an operation. (-1 to exit)");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Fibonacci Sequence"); 
int choice = Convert.ToInt32(Console.ReadLine());

while (choice != -1)
{
    // Prompt for user input 
    Console.WriteLine("Please enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());



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
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;


    }
    // print output
    Console.WriteLine($"The result is: {answer}");
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Please select an operation. (-1 to exit)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci Sequence");
    choice = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("************** End Of Program ***************");