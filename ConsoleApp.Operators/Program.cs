// See https://aka.ms/new-console-template for more information


Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
Console.Write("Please enter the second number: ");
string? numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

// Add numbers
int sum = num1 + num2;

// multiply
int product = num1 * num2;

//division

int quotient = num1 / num2;

// subtraction

int difference = num1 - num2;

// modulus

int mod = num1 % num2; // returns a remainder of a operation

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");

