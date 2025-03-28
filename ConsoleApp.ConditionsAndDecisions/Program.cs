
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

if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade == 65)
{
    Console.WriteLine("C+");

}
else if (grade == 75)
{
    Console.WriteLine("B");
}
else if (grade == 85)
{
    Console.WriteLine("B+");
}
else
{
    Console.WriteLine("A - Good job");
}


Console.WriteLine("****************** Complex Simple IF...ELSE Results End *****************");

