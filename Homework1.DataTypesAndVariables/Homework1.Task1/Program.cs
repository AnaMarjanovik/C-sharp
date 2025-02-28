Console.WriteLine("============ TASK1 ============");

Console.WriteLine("Please enter the first number!");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the second number!");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the operator!");
string opeartion = Console.ReadLine();

if (opeartion == "+")
{
    Console.WriteLine(num1+num2);
}else if(opeartion == "-")
{
    Console.WriteLine(num1-num2);
}else if(opeartion == "*")
{
    Console.WriteLine(num1*num2);
}
else if (opeartion == "/")
{
    if (num2 != 0)
    {
        Console.WriteLine(num1/num2);
    }
    else
    {
        Console.WriteLine("You can't devide with 0.");
    }
}
else
{
    Console.WriteLine("You have entered an unappropriate operator, please try again !");
}

