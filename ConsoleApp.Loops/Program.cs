﻿// Simple For Loop Demo
// Print Hello World 10 times

// 0 1 2 3 4 5 6 7 8 9
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World {i}");
}

Console.WriteLine("Loop Completed ");
// Ask User how many times they wish to print hello world and print accordingly


Console.WriteLine("How many time do you want to print HELLO WORLD?");
Console.Write("Enter here:");
int numberOfTimes = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numberOfTimes; i++)
{
    Console.WriteLine($"Hello, World {i}"); 
}