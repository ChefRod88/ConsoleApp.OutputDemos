
// Prompt for input
Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Decide to print pas or fail on input
Console.WriteLine("****************** Simple IF Results *****************");
if(grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Student will need to speak with professor for a retake plan");
}

Console.WriteLine("Thank you for using this program");
Console.WriteLine("****************** Simple IF Results End *****************");

// Complex If...Else if...statement - Decide to print letter based on grade value
Console.WriteLine("****************** Complex Simple IF...ELSE Results *****************");
/*
A: 86-100 X
B: 75-84 X
C: 65-74 X
C: 50-64 X
F: less than 50 X
 */

if (grade < 0 || grade > 100)
{
    Console.WriteLine("INVALID");
}
else if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade >= 50 && grade <= 64 )
{
    Console.WriteLine("C-");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good job");
}
else
{
    Console.WriteLine("This is an invald value");
}

    Console.WriteLine("****************** Complex Simple IF...ELSE Results End *****************");

// Tenary operator - Used to assign a value to a variable based on a condition 
Console.WriteLine("****************** Tenary Operator Result *****************");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student status is: {passStatus}");


Console.WriteLine("****************** Tenary Operator Result *****************");

// The rest of the applicatiom
Console.WriteLine("Thank you for using this program");
