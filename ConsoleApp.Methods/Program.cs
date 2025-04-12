using System.Xml.Linq;

Console.WriteLine("********* - Methods - **********");

// void methods - complete a task without returnng a value
void PrintName()
{
    // Method code
    Console.WriteLine("Rodney Chery");
}


// value returning methods - returns a value after an operation

int GetFiveYearsAgo()
{ 
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}


// methods with parameters - represent data being passed through a method

void PrintNameWithParameters(string name)
{
    // Method code
    Console.WriteLine("Your name is " + name);
}

int GetYearDiffWithParams(int year)
{
    int yearDiff = DateTime.Now.Year - year;
    return yearDiff;
}

// methods with optional parameters

// methods with nullable parameters

/* Function Calls */
PrintName();

int fiveYearsAgo =  GetFiveYearsAgo();
Console.WriteLine("Five Years Ago was : " + fiveYearsAgo);

Console.WriteLine("Enter Your Name");
string name = Console.ReadLine();
PrintNameWithParameters(name);

Console.WriteLine("Enter A Year: ");
int pastYear = Convert.ToInt32(Console.ReadLine());
int yearsAgo = GetYearDiffWithParams(pastYear);
Console.WriteLine("This was:  " + yearsAgo + " years ago.");


