using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("********** - Classes and Objects - **********");

// Define an object of type Person.
Person person; // this will be null by default

Person baby = new Person();
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


