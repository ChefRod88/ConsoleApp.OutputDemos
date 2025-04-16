using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;
public partial class Person
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

    
    //Properties/Data Members
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateOnly DateOfBirth { get; set; }

    // Field member
    private string _taxNumber;
    protected string _idNumber = "N/A";

    public void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var firstIntial = FirstName[0];
        var secondIntial = LastName[0];
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

    public string GetIdNumber()
    {
        return _idNumber;
    }

    

    protected string GetRandomNumber()
    {
        return RandomNumberGenerator
                .GetInt32(100000, 9999999)
                .ToString();
    }
}


