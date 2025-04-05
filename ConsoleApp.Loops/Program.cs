// Simple For Loop Demo
// Print Hello World 10 times

// 0 1 2 3 4 5 6 7 8 9
using System.Diagnostics.Metrics;

Console.WriteLine("******************* Simple For Loop **************************");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World {i}");
}

Console.WriteLine("Loop Completed ");
// Ask User how many times they wish to print hello world and print accordingly


//Console.WriteLine("How many time do you want to print HELLO WORLD?");
//Console.Write("Enter here:");
//int numberOfTimes = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < numberOfTimes; i++)
//{
//    Console.WriteLine($"Hello, World {i}"); 
//}
Console.WriteLine("******************* Simple For Loop Completed **************************");

// While Loop
Console.WriteLine("******************* Simple  While Loop **************************");

int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello, World {counter}");
    counter++;
}
// Ask the user for a number and find the total for each number that is entered.
// Print final sum when the user enters -1 to exit.

int sum = 0;
Console.WriteLine("Please numbers to be summed up. (-1 to stop or exit)");
while (true)
{

    int input = Convert.ToInt32(Console.ReadLine());

    if(input == -1)
    {
        break;
    }

    sum += input;
}

Console.WriteLine($"Your sum is: {sum}");








Console.WriteLine("While Loop Completed");












Console.WriteLine("******************* Simple  While Loop Completed **************************");
