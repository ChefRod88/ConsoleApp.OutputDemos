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

// methods with optional parameters - parameter is not required...also has a default value

int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

// methods with nullable parameters

void PrintNameNullableParam(string? name, int? count)
{

    //if (string.IsNullOrEmpty(name))
    //{

    //    name = " Default Name";

    //}

    //if (!count.HasValue)
    //{
    //    count = 1;  
    //}

    name ??= "Default Name";
    count ??= 1;

    for (int i = 0; i < count ; i++)
    {
        Console.WriteLine(name);
    }
}

/* Function Calls */
//PrintName();

//int fiveYearsAgo =  GetFiveYearsAgo();
//Console.WriteLine("Five Years Ago was : " + fiveYearsAgo);

//Console.WriteLine("Enter Your Name");
//string name = Console.ReadLine();
//PrintNameWithParameters(name);

//Console.WriteLine("Enter A Year: ");
//int pastYear = Convert.ToInt32(Console.ReadLine());
//int yearsAgo = GetYearDiffWithParams(pastYear);
//Console.WriteLine("This was:  " + yearsAgo + " years ago.");

//Console.WriteLine("Enter number of years in the future or past");
//int numberOfYears = Convert.ToInt32(Console.ReadLine());

//var pastYear1 = GetFutureOrPastYear();
//Console.WriteLine("The year is: " + pastYear1);

//var pastYear2 = GetFutureOrPastYear(numberOfYears);
//Console.WriteLine("The year is: " + pastYear2);

PrintNameNullableParam(null, null);
PrintNameNullableParam("Chester", 5);

