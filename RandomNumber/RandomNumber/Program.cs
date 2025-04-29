Random random = new Random();

int num = random.Next(1, 11);

Console.WriteLine("guess the number : ");
string inputString = Console.ReadLine();

bool isNumber = int.TryParse(inputString, out int numInput);

if (isNumber)
{
    if (numInput == num)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("Incorrect!");
    }
}
else
{
    Console.WriteLine("Please input a number!");
}