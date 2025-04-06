﻿// See https://aka.ms/new-console-template for more information

// Write a program that takes a users's age as input and prints it to the screen.
// Display an error message if an invalid input is recieved.

try
{
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old.");
}
catch (Exception)
{
    Console.WriteLine("Your age value was incorrect, please try again ");
    throw;
}
finally
{
    Console.WriteLine("************** Thank you for using this program *******************");
}




