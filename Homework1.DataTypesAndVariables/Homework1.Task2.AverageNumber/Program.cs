
Console.WriteLine("============== TASK2 ============== ");

Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the four number: ");
int fourNumber = int.Parse(Console.ReadLine());

int average = (firstNumber + secondNumber + thirdNumber + fourNumber) / 4;
Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " and " + fourNumber + " is: " + average);
