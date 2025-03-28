// See https://aka.ms/new-console-template for more information


Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
/*
 Math Operations and operators
 */
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
Console.WriteLine("****************************** Math Results ***********************************");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("****************************** End Math Results *******************************");


/*
    Logic Operations and Operators
 */

bool isGreaterThan = num1 > num2; 
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("***************************** Logic Results **********************************");
Console.WriteLine($"isGreaterThan:{isGreaterThan} ");
Console.WriteLine($"isLessThan: {isLessThan} ");
Console.WriteLine($"isEqualTo: {isEqualTo} ");
Console.WriteLine($"isGreaterThanOrEqualTo: {isGreaterThanOrEqualTo} ");
Console.WriteLine($"isLessThanOrEqualTo: {isGreaterThanOrEqualTo} ");
Console.WriteLine($"isNotEqual: {isNotEqual} ");
Console.WriteLine("***************************** End Logic Results ******************************");


/*
    Assignment Operations and Operators
 */
//int randomValue = 5;
//int increaseValue = num1 + 5;

//num1 = num1 + 5;



Console.WriteLine("**************************************** Assignment Results ***********************");
Console.WriteLine();
num1 += 5;
Console.WriteLine($"Num 1 increased by 5: {num1}");
num1 -= 3;
Console.WriteLine($"Num 1 reduced by 3: {num1}");
num1 /= 2;
Console.WriteLine($"Num 1 divided by 2: {num1}");
num1 %= 2;
Console.WriteLine($"Num 1 mod by 2: {num1}");
num1 *= 10;
Console.WriteLine($"Num 1 multiply by 3: {num1}");
Console.WriteLine();
Console.WriteLine("**************************************** End Assignments Results ***********************");


