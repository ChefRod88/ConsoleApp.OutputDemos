// Welcome Message
Console.WriteLine("******************** Welcome To The Sample Calculator ************************");

// Variable Declarations
int choice = 0;

while (choice != -1)
{
    Console.WriteLine("Please select an operation. (-1 to exit)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci Sequence");
    Console.Write("Choice: ");
    try
    {
        choice = Convert.ToInt32(Console.ReadLine());

    }
    catch (Exception )
    {
        Console.WriteLine("Invalid Input");
        Console.ReadLine();
        Console.Clear();
        continue;
        
    }

    if (choice == -1)
    {
        break;
    }

    int answer = 0;

    if (choice >= 1 && choice <= 4)
    {
        Console.Write("Please enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                answer = num1 + num2;
                break;
            case 2:
                answer = num1 - num2;
                break;
            case 3:
                answer = num1 * num2;
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    continue;
                }
                answer = num1 / num2;
                continue;
        }

        Console.WriteLine($"The result is: {answer}");
    }
    else if (choice == 5)
    {
        Console.Write("Enter the first number for Fibonacci sequence: ");
        Console.Write("First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number for Fibonacci sequence: ");
        Console.Write("Choice: ");
        int b = Convert.ToInt32(Console.ReadLine());

        
        Console.Write("Fibonacci Sequence: ");
        for (int i = 0; i < 10 ; i++)
        {
            Console.Write($"{a} ");
            int temp = a;
            a = b;
            b += temp;
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Invalid Choice");
    }

    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("************** End Of Program ***************");

   

