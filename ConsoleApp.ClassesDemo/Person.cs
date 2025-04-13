public class Person
{
    //Properties/Data Members
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateOnly DateOfBirth { get; set; }

    // Field member
    private string _taxNumber;

    public void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var firstIntial = FirstName[0];
        var secondIntial = FirstName[0];
        Console.WriteLine($"{firstIntial} {secondIntial}");
    }

   
}


