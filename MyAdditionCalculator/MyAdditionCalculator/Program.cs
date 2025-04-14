// print out whatever is inside of ()
Console.WriteLine("enter first number:");

// takes the user input and stores it
string firstNumber = Console.ReadLine();

Console.WriteLine("enter second number:");
string secondNumber = Console.ReadLine();

int result = int.Parse(firstNumber) + int.Parse(secondNumber);

// string interpolation
Console.WriteLine($"{firstNumber} + {secondNumber} is {result}");

// keep console running (waiting a key to be pressed)
Console.ReadKey();