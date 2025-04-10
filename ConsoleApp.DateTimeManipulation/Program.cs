Console.WriteLine("********** - DateTime manipulation - **********");

// Empty DateTime

DateTime dateTime = new DateTime();

// Create a DateTime from date and time

var dateOfBirth = new DateTime(1988,8,16);
Console.WriteLine($"My DOB is {dateOfBirth}");

var exactDateOfBirth = new DateTime(1988, 8, 16, 14, 45, 45);
Console.WriteLine($"My DOB is {exactDateOfBirth}");

Console.WriteLine($"Day of the week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of the year {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of day {exactDateOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {exactDateOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateOfBirth.Kind}");



// Create a DateTime drom current timestamp

DateTime now = DateTime.Now;
Console.WriteLine("The time now is: " + now);

// Create a DateTime from a string
Console.WriteLine("What is you DOB (dd/MM/yyyy): ");
string dob = Console.ReadLine();

var userDob = DateTime.Parse( dob );
Console.WriteLine($"Day of the week: {userDob.DayOfWeek}");
Console.WriteLine($"Day of the year {userDob.DayOfYear}");
Console.WriteLine($"Time of day {userDob.TimeOfDay}");
Console.WriteLine($"Tick: {userDob.Ticks}");
Console.WriteLine($"Kind: {userDob.Kind}");


// Change Format DateTime 
Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("MMM, dd-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("dddd-MMMM-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob:dddd-MMMM-yyyy}");



// Add Additional DateTime

// Ticks from DateTime
Console.WriteLine("********** - DateTime Offset manipulation - **********");
// UTC

// DateTimeOffset and TimeZone Info

Console.WriteLine("********** - Date only and Time only manipulation - **********");

// DateOnly

// TimeOnly

