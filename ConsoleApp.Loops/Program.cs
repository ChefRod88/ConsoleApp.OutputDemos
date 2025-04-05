//// Simple For Loop Demo
//// Print Hello World 10 times

//// 0 1 2 3 4 5 6 7 8 9
//using System.Diagnostics.Metrics;

//Console.WriteLine("******************* Simple For Loop **************************");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Hello, World {i}");
//}

//Console.WriteLine("Loop Completed ");
//// Ask User how many times they wish to print hello world and print accordingly


////Console.WriteLine("How many time do you want to print HELLO WORLD?");
////Console.Write("Enter here:");
////int numberOfTimes = Convert.ToInt32(Console.ReadLine());

////for (int i = 0; i < numberOfTimes; i++)
////{
////    Console.WriteLine($"Hello, World {i}"); 
////}
//Console.WriteLine("******************* Simple For Loop Completed **************************");

//// While Loop
//Console.WriteLine("******************* Simple  While Loop **************************");

//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine($"Hello, World {counter}");
//    counter++;
//}
//// Ask the user for a number and find the total for each number that is entered.
//// Print final sum when the user enters -1 to exit.


//Console.WriteLine("Please numbers to be summed up. (-1 to stop or exit)");
//while (true)
//{

//    int input = Convert.ToInt32(Console.ReadLine());

//    if(input == -1)
//    {
//        break;
//    }

//    sum += input;
//}

//Console.WriteLine($"Your sum is: {sum}");



Console.WriteLine("************************************ Do While Loop **************************************************************");
int sum = 0;
int num = 0;
//Console.WriteLine("Please number to be summed. (-1 to stop or exit)");
do
{
    Console.WriteLine("Please number to be summed. (-1 to stop or exit)"); // in or out of the scope of the loop (personal preference)
    num = Convert.ToInt32(Console.ReadLine());
    // nested if statement
    if (num != -1)
    {
        sum += num;
    }
} while (num != -1);
Console.WriteLine($"Sum = {sum}");



Console.WriteLine("************************************ Do While Loop Completed ****************************************************");
