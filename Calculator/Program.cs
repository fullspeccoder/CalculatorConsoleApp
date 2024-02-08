// See https://aka.ms/new-console-template for more information
// Task 1 - Ask the user for two numbers and a calculation method.
// Task 2 - Valid calculation methods are addition, subtraction, multiplication, and division.
// Task 3 - Calculate the result and print it on the console.
// Task 4 - Ask the user for another calculation. The program should only end if the user decides that he does not want to calculate another result.

// Create a loop that prompts the user for input.
bool running = true;
int firstNum = 0;
int secondNum = 0;
while (running)
{
    // reading input
    Console.Write("Enter first number:");
    string? firstNumInput = Console.ReadLine();
    Console.Write("Enter calculation method:");
    string? calcMethodInput = Console.ReadLine();
    Console.Write("Enter second number:");
    string? secondNumInput = Console.ReadLine();

    // checking input if null otherwise parses
    if (firstNumInput == null || secondNumInput == null || calcMethodInput == null)
    {
        continue;
    }
    firstNum = int.Parse(firstNumInput);
    secondNum = int.Parse(secondNumInput);

    // calculates input
    switch(calcMethodInput)
    {
        case "+":
            Console.WriteLine(firstNum + secondNum);
            break;
        case "-":
            Console.WriteLine(firstNum - secondNum);
            break;
        case "*":
            Console.WriteLine(firstNum * secondNum);
            break;
        case "/":
            Console.WriteLine(firstNum / secondNum);
            break;
        case "%":
            Console.WriteLine(firstNum % secondNum);
            break;
        default:
            throw new Exception("Error, operator not recognized");
    }

    // asks user if they want to continue
    Console.WriteLine("Do you have another calculation?");
    string? continueRunning = Console.ReadLine();

    // calculates whether the program continues to run
    if (continueRunning != "Yes" || continueRunning == null)
    {
        running = false;
    }
}