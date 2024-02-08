// See https://aka.ms/new-console-template for more information
string message = "Hello World";
Console.WriteLine(message);

//empty string
string emptyMessage = string.Empty;

string filePath2 = @"C:/temp";
Console.WriteLine(filePath2);

// string length
Console.WriteLine(emptyMessage.Length);

string firstName = "Claudio";
string lastName = "Wilson";

// interpolation
string fullName = $"{firstName} {lastName}";
Console.WriteLine(fullName);

// substrings
string firt5characters = firstName.Substring(0, 5);

