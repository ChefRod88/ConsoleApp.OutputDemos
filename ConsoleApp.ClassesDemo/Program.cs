using ConsoleApp.ClassesDemo;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("********** - Classes and Objects - **********");

// Define an object of type Person.
Person person; // this will be null by default //**1

Person baby = new Person();// **2
baby.LastName = "Thomas";
baby.FirstName = "Theresa";
baby.DateOfBirth = new DateOnly(2023, 10,16);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine(taxNumber);

var person1 = new Person("Developer", "One", new DateOnly(2000,10,31));
person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "7755522");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();

var teacher = new Teacher(); //**3
teacher.LastName = "Shawn";
teacher.FirstName = "Walsh";
teacher.DateOfBirth = new DateOnly(2023, 10, 16);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
var teachertaxNumber = teacher.GetTaxNumber();
Console.WriteLine(teachertaxNumber);
teacher.GenerateTeacherIdNumber();

var teacherIdNumber = teacher.GenerateTeacherIdNumber;
Console.WriteLine(teacherIdNumber);


Student student = new (); //**4
student.LastName = "Thomas";
student.FirstName = "Ramj";
student.DateOfBirth = new DateOnly(2023, 10, 16);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();
var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);

