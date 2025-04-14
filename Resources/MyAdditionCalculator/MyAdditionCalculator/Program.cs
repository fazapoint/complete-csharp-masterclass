// See https://aka.ms/new-console-template for more information



// datatype variableName = initial value;
using System.Globalization;

double myNumber1 = 0.0;
double myNumber2 = 0.0;

// Prints out whatever is in side of ()
Console.WriteLine("Enter a number!");

// takes the user input and stores it
// Variable with the name "userInput" and the data type "string"
// strings are used for text 
string userInput = Console.ReadLine();
//myNumber = int.Parse(Console.ReadLine());
myNumber1 = double.Parse(userInput, CultureInfo.InvariantCulture);

Console.WriteLine("Enter a number!");
userInput = Console.ReadLine();
myNumber2 = double.Parse(userInput, CultureInfo.InvariantCulture);



double sum = myNumber1 + myNumber2;
sum = Math.Round(sum, 2);


// we are adding to strings together and writing them onto the console
// string concatination
//Console.WriteLine("The result of " + myNumber + " and " + myNumber2 + " is " + sum);

// string interpolation
Console.WriteLine($"The result of {myNumber1.ToString(CultureInfo.InvariantCulture)} " +
    $"and {myNumber2.ToString(CultureInfo.InvariantCulture)} is {sum.ToString(CultureInfo.InvariantCulture)}");

Console.ReadKey();
