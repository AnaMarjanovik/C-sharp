
Console.WriteLine("Enter a  number.");
bool parseSuccessful1 = int.TryParse(Console.ReadLine(), out int number1);
//int number1 = int.Parse(Console.ReadLine());

for (int i = 1; i <= number1; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("Enter a  number.");
bool parseSuccessful2 = int.TryParse(Console.ReadLine(), out int number2);
//int number2 = int.Parse(Console.ReadLine());

for (int i = number2; i >= 1; i--)
{
    Console.WriteLine(i);
}