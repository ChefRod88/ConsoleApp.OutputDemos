using System.Security.Cryptography;

public class Person
{
    public Person()
    {

    }

    public Person(string firstname, string lastname, DateOnly dob )
    {
        FirstName = firstname;
        LastName = lastname;
        DateOfBirth = dob;

    }

    public Person(string firstname, string lastname, string taxNumber)
    {
        FirstName=firstname;
        LastName=lastname;
        _taxNumber = taxNumber;
    }
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

   public void GenerateTaxNumber()
    {
        if ( string.IsNullOrEmpty(_taxNumber ))
        {
            _taxNumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
        }
        else
        {
            Console.WriteLine("Tax number already exists");
        }
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public int GetAge()
    {
        var age = DateTime.Now.Year - DateOfBirth.Year;
        return age;

    }

    public int GetAge(int year)
    {
        var age = year - DateOfBirth.Year;
        return age;

    }
}


