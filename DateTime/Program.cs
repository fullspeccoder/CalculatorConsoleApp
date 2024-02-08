// See https://aka.ms/new-console-template for more information
using System.Globalization;

DateTime dateOfBirth = new DateTime(1996, 3, 4);
Console.WriteLine(dateOfBirth);

// computed values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;

// DateTime Parsing
DateTime localDate = DateTime.Parse("04.03.1996");
DateTime usDate = DateTime.Parse("03/04/1996", new CultureInfo("en-US"));

Console.WriteLine($"localDate: {localDate} usDate: {usDate}");

// DateTime formatting
Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
Console.WriteLine(dateOfBirth.ToString("yyyy-MM-dd"));

