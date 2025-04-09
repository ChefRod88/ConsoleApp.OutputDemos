// Initialize with a regular string litral.

string s1 = "This is an literal string";
String s2 = "This is an literal string";

// Declare without intializing. (possible null exception)

string s3; // default value is null

// Intialize to null. (possible null exception)

string? s4 = null;

// Intialize as an empty string.

string s5 = string.Empty; // "" 
string s6 = "";
// Escape sequences and characters

string sentence = "She said, \"I have your phone\" \r\n This is the next line ";


// Verbatim string literal.

string oldPath = "C: \\program files\\programfolder\\";
string newPath = @"C: \program files\programfolder\";


// Use a const string to prevent modification to a string 

const string path = "C: \\program files\\programfolder\\";
//path = "new value"; Illegal operation against an constant


// Raw string literals

string rawLiteral = """ "This is a raw literal strong" """;
string rawLiteral1 = """
     "This is a raw literal strong"
     This is the next line 
     And another one
     Path = C: \program files\programfolder\
    """;


// Review concatenation and interpolation

s1 = s1 + s2;
s1 += s2;
string newString = $"{s1} {s2} ghghggggjhgjhg";
string newString2 = s1 + $"{s1} {s2} ghghggggjhgjhg";
string newString3 = s1 + String.Format("Literal string {0}{1}", s1, s2);

/* String manipulation methods and properties. Sometimes its just assesment */

// Null or empty checks 
// find the length of the string

Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");


// if (string.IsNullOrEmpty(s4) == false)

if ( !string.IsNullOrEmpty( s4 ))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
   
}

if (!string.IsNullOrEmpty(s5))
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");

}
// Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)} : {subString}");
subString = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)} : {subString}");

// Splitting string

var splitStrings = s2.Split(' ');
for (int i = 0; i < splitStrings.Length; i++) 
{
    Console.WriteLine(splitStrings[i]);
}
// Replace

string replacements = s1.Replace('s', 'V');
Console.WriteLine($"{nameof(replacements)} : {replacements}");

string replacements2 = s1.Replace("string","chicken");
Console.WriteLine($"{nameof(replacements2)} : {replacements2}");

// Convert to string
string salary = 100000.00.ToString();
int value = 100000;

// Changing Formatting

Console.WriteLine($"{nameof(salary)} : {salary:C}");
Console.WriteLine(nameof(salary)+ ": " +  value.ToString("C"));







