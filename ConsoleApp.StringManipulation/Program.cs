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


