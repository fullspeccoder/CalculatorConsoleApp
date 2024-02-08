// See https://aka.ms/new-console-template for more 
bool enabled = false;
Console.WriteLine($"bool: {enabled}");
enabled = true;
Console.WriteLine($"bool: {enabled}");

char c1 = 'a';
Console.WriteLine($"char: {c1}");

//int
int a = 0;
int b = 5;
int c = -7;
Console.WriteLine($"a: {a}\nb: {b}\nc: {c}");

//floats
float f = 3.5f; // float - single precision (32-bit)
double g = 7.8d; // double = double precision (64-bit)
decimal dec = 7.15m; // decimal - high precision (128-bit)

//Nullable value types
int? i1 = null;
bool? b1 = null;

//? at the end of data types show that it can be nullable.