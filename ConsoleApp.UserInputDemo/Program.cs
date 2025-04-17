// Declare variables
using System.Globalization;


string? firstName = string.Empty;
string? lastName = string.Empty;
int age;
DateOnly dob = new DateOnly();
decimal salary;
char gender;
bool working;

// Prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your date of birth (dd/mm/yyyy) : ");
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy",
    CultureInfo.InvariantCulture);


Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

Person person = new(dob) 
{ 
    FirstName = firstName,
    LastName = lastName,
    Gender = gender,
    IsWorking = working,
    Salary = salary
};

// Process the data 
int workingYearsRemaining = person.GetNumberOfWorkingYearsRemaining();
var estimatedRetirementDate = person.GetEstimatedRetirementDate();



// Output the result
Console.WriteLine($"Full name: {person.ToString()}");
Console.WriteLine($"Age: {person.GetAge()}");
Console.WriteLine($"Your Salary is: {person.Salary.ToString("C")}");
Console.WriteLine($"Your Gender is: {person.Gender}");
Console.WriteLine($"You are employed: {person.IsWorking}");
Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");
Console.WriteLine($"Estimated Retirement Year: {estimatedRetirementDate}");
