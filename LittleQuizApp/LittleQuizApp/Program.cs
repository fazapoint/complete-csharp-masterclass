int points = 0;
Console.WriteLine("What is the capital of Indonesia?");
string answer1 = "jakarta";

string answer = Console.ReadLine();
if (answer?.ToLower() == answer1)
{
    points += 1;
}

Console.WriteLine("5 + 2 equals to?");
int answer2 = 7;
answer = Console.ReadLine();

if (Convert.ToInt16(answer) == answer2)
{
    points += 1;
}

Console.WriteLine($"Your point is {points}");
