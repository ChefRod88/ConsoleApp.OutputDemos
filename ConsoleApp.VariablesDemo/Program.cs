// Diffrent datatypes
/*
 text- string
 integers -int
 decimal - double, float, decimal
 logical - bool
 */
string name = "Rodney";

Console.WriteLine(name);
Console.WriteLine("I am "+ name); // string concatenation
Console.WriteLine($"I am {name}"); // string interpolaton
Console.WriteLine("I was given the name {0}", name); // formatted string

int age = 36;
Console.WriteLine("My age is " + age);
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is when I retire " + retirementAge);

bool isRetired = true;
Console.WriteLine("Am I retired? " + isRetired);
