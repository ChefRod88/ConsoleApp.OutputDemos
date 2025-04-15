using ConsoleApp.ClassesDemo;
using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using System.ComponentModel.DataAnnotations;
using static ConsoleApp.ClassesDemo.Classes.ShapeDemo.Polygon;
using static ConsoleApp.ClassesDemo.Polygon;
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

//Polygon polygon = new Polygon();  // compiler error
Rectangle rectangle = new(10,20);
var rectangleArea = rectangle.Area();
Console.WriteLine($"The Triangle Area is: {rectangleArea} square ft");

Square square = new(40);
Console.WriteLine($"The Square Area is: {squareArea} square ft");


Triangle triangle = new(10,20);
var triangleArea = triangle.Area();
Console.WriteLine($"The  Area is: {triangleArea} square ft");


Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidVolume = cuboid.Volume();
var cuboidPerimeter = cuboid.Perimeter();
Console.WriteLine($"Cuboid area is {cuboidArea}");
Console.WriteLine($"Cuboid volume is {cuboidVolume}");
Console.WriteLine($"Cuboid perimeter is {cuboidPerimeter}");

Sphere sphere = new(7);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();
Console.WriteLine($"Cuboid area is {sphereCircumference}");
Console.WriteLine($"Cuboid volume is {sphereVolume}");



