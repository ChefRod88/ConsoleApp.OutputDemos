Console.WriteLine("********** - Classes and Objects - **********");

// Define an object of type Person.
Person person; // this will be null by default

Person baby = new Person();
baby.LastName = "Thomas";
baby.FirstName = "Theresa";
baby.DateOfBirth = new DateOnly(2023, 10,16);

baby.PrintFullName();
baby.PrintInitials();
