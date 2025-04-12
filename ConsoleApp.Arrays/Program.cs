using System;

Console.WriteLine("********** - ARRAYS - **********");

// Tell me how many students and grades are to be entered
Console.Write("Please indicate the number of grades to be entered:  ");
int numOfGrades = Convert.ToInt32(Console.ReadLine());


// Declare Fixed Size Array

int[] grades = new int[numOfGrades];
string[] students = new string [numOfGrades];

// 5 spaces addresses/indexes - 0, 1, 2, 3, 4
// If n is the size of the array, then your array has addresses between 0 to n-1

// Add values to Fixed Sized Array
//grades[0] = 45;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 53;
//grades[4] = 32;

for (int i = 0; i < numOfGrades; i++)
{
    Console.WriteLine("Enter a student name: ");
    students[i] = Console.ReadLine();

    Console.WriteLine("Enter a grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in Fixed Size Array
Console.WriteLine("The Grades you have entered are: ");
for (int i = 0; i < numOfGrades;i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
    
}


// Declare Variable Sized Array

//string[] studentName = new string[] {"Newton", "Joshua", "etc..."};
//string[] studentNames = { "Newton", "Joshua", "etc..." };

//// Add values to Variable Sized Array

//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine("Enter a name: ");
//    studentNames[i] = Console.ReadLine();
//}


//// Print values in Variable Sized Array 

//Console.WriteLine("The names you have entered are: ");
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine(studentNames[i]);
//}