// See https://aka.ms/new-console-template for more information

int age = 31;
float weight = 78.7f;

Console.WriteLine(age);
Console.WriteLine(weight);

//implicit conversions
long myAge = age;

//explicit conversions
int lessWeight = (int) weight; // precision loss
int notMyAge = (int)myAge; // no precision loss

long bigNumber = 11111111111111111;

int smallerType = (int)bigNumber;
