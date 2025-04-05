int n = 25;
int a = 0;
int b = 1;
int sum = 0;

Console.WriteLine("This is the Fibonacci Sequence and just to let you know I don't like math but it is tolerable.");
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{a}");
    sum += a;

    int temproraryVariable = a; 

    a = b;

    b += temproraryVariable;
}
Console.WriteLine();
Console.WriteLine($"The sum of the Fibonacci sequence is {sum}");
