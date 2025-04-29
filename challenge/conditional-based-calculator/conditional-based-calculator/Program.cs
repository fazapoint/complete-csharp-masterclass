Console.WriteLine("Enter the first number:");
string strNum1 = Console.ReadLine();
double num1;
bool isValidinput1 = double.TryParse(strNum1, out num1);

Console.WriteLine("Enter the second number:");
string strNum2 = Console.ReadLine();
double num2;
bool isValidinput2 = double.TryParse(strNum2, out num2);

if (isValidinput1 && isValidinput2)
{
    Console.WriteLine("Choose an operation: +, -, *, /");
    string operation = Console.ReadLine();
    switch (operation)
    {
        case "+":
            Console.WriteLine("result: {0}", (num1 + num2));
            break;
        case "-":
            Console.WriteLine("result: {0}", (num1 - num2));
            break;
        case "*":
            Console.WriteLine("result: {0}", (num1 * num2));
            break;
        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                break;
            }
            Console.WriteLine("result: {0}", (num1 / num2));
            break;
        default:
            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            break;
    }
}
else
{
    Console.WriteLine("Please only input a number!");
}