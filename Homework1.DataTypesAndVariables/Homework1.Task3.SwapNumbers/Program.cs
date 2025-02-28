

Console.WriteLine("================== TASK3 ==================");

Console.WriteLine("Input the first number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number");
int number2 = int.Parse(Console.ReadLine());
int temp = 0;

temp = number1;
number1 = number2;
number2 = temp;

Console.WriteLine("After swapping:");
Console.WriteLine("First number: " + number1);
Console.WriteLine("Second number: " + number2);

