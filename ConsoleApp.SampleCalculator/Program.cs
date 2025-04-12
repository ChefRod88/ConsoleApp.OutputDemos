using System.Security.Cryptography;

// Variable Declarations


int choice = 0;
int num1, num2 = 0;

// Show calculator options / Show menu
while (choice != -1)
{
    try
    {
        // Welcome Message
        PrintMenu();

        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        
        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = AddNumbers(num1, num2);
                break;
            case 2:
                answer = SubNumbers(num1, num2);
                break;
            case 3:
                answer = ProductNumbers(num1, num2);
                break;
            case 4:
                answer = QuotientNumbers(num1, num2);
                break;
            case 5:
                FibonacciSequence();
                break;
        }

        // print output 
        Console.WriteLine($"The result is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }
}



Console.WriteLine("******** - Thank you for using the sample calculator! - ********");


// Method Definintions 
void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("******** - Welcome to the sample calculator! - ********");
    Console.WriteLine("Please select an operation (-1 to exit program) ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
}

int QuotientNumbers(int num1, int num2)
{
    return num2 / num1;
}

int ProductNumbers(int num1, int num2)
{
    return num1 * num2;
}

int SubNumbers(int num1, int num2)
{
    return num2 - num1;
}

int AddNumbers(int num1, int num2)
{
    return num1 += num2;
}

void FibonacciSequence()
{
    Console.WriteLine("Welcome to the Fibonacci Sequence.");

    Console.WriteLine("Please enter first number:");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter second number:");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Fibonacci Sequence (first {num2} terms):");



    int a = num1, b = num2;

    for (int i = 0; i < num2; i++)
    {
        Console.Write($"{a} ");
        int temp = a;
        a = b;
        b = temp + b;
    }

    
}

