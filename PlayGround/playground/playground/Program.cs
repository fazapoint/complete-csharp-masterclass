//Console.WriteLine("Enter your age: ");
//int age = Convert.ToInt16(Console.ReadLine());

//if (age >= 18)
//{
//    Console.WriteLine("go party to the club!");
//}
//else if (age >= 13)
//{
//    Console.WriteLine("Are you with your parent? y/n");
//    string strIsWithParent = Console.ReadLine();

//    if (strIsWithParent == "y")
//    {
//        Console.WriteLine("Go to the party with your parent!");
//    }
//    else
//    {
//        Console.WriteLine("no party for you");
//    }
//}
//else
//{
//    Console.WriteLine("go party to the kindergardeen!");
//}

//string guessName = "Jack";
//string result = guessName == "jack" ? "youre jack" : "youre not jack";

//Console.WriteLine(result);

Console.WriteLine("insert a number: ");
string number = Console.ReadLine();
if (int.TryParse(number, out int numInt))
{
    Console.WriteLine(numInt);
}
else
{
    Console.WriteLine("Not a number!");
}