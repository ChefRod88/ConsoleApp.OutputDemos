
// Prompt for input
Console.Write("Please enter student's grade: ");
//Global variable/ global scope
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
int gradeAfterBonus = grade >= 0 && grade <= 100 ? grade += 10 : 0 ; // tenary operator
Console.WriteLine($"Grade after bonus: {gradeAfterBonus}");

Console.WriteLine("****************** Complex Simple IF...ELSE Results End *****************");

// Tenary operator - Used to assign a value to a variable based on a condition 
Console.WriteLine("****************** Tenary Operator Result *****************");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student status is: {passStatus}");


Console.WriteLine("****************** Tenary Operator Result *****************");

// The rest of the applicatiom
Console.WriteLine("Thank you for using this program");

//Switch statements - used to evaluate a value and take action 
Console.WriteLine("****************** Switch Statement Result *****************");
/*
 Write a program to accept an integer as the day of the week and prnt the approiate message as outlined below.
1 - Sunday
2 - Monday
3 - Tuesday
4 - Wednesday (Hump Day)
5 - Thursday
6 - Friday (TGIF !!!)
7 - Saturday (Beach Day!!!)
 */
Console.WriteLine("Please enter the day of the week");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;

    case 2:
        Console.WriteLine("Monday");
        break;

    case 3:
        Console.WriteLine("Tuesday");
        break;

    case 4:
        Console.WriteLine("Wednesday (Hump Day)");
        break;

    case 5:
        Console.WriteLine("Thursday");
        break;

    case 6:
        Console.WriteLine("Friday (TGIF !!!)");
        break;

    case 7:
        Console.WriteLine("Saturday (Beach day !!!)");
        break;
    default:
        
        Console.WriteLine("invalid day number entered");
        break;
        
        


}



Console.WriteLine("****************** Switch Statement Result End *****************");


// The rest of the application 
Console.WriteLine("Thank you for using this program");