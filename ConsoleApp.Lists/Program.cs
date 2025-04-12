Console.WriteLine("********** - LISTS - **********");

// Declare a List
List<int> grades = new List<int>();
int grade = 0;
//var grades = new List<int>();
//List<int> grades = new();

// Add valuest to a list

//grades.Add(45);
//grades.Add(95);

//Console.WriteLine(grades[0]);
//Console.WriteLine(grades[1]);

do
{
    Console.WriteLine("Enter Grade: ");
    grade = Convert.ToInt32(Console.ReadLine());

    if (grade != -1)
    {
        grades.Add(grade);
    }


} while (grade != -1); // exit condition

// Print values in list - for

Console.WriteLine("Printing names via for loop");
for (int i = 0; i < grades.Count; i++)
{
    Console.WriteLine(grades[i]);
}

// Print values in list - foreach
Console.WriteLine("Printing names via foreach loop");
foreach (int g in grades)
{
    Console.WriteLine(g);

}