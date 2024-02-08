// See https://aka.ms/new-console-template for more information
// Task 1
//int i = 0;
//while (i < 20)
//{
//    Console.WriteLine("i is: " + i);
//    i++;
//}

for(int i = 0; i < 20; i++)
{
    Console.WriteLine("i is: " + i);
}

// Task 2
for(int j = 0; j < 20; j++)
{
    if (j <= 10)
    {
        continue;
    }
    Console.WriteLine("j is: " + j);
}

// Task 3
Console.WriteLine("What's your birthday?");
string? birthday = Console.ReadLine();

Console.WriteLine($"Your birthday is {birthday}?\nWell Happy Birthday!");



