int[] array = new int[6];

Console.WriteLine("Enter integer no.1:");
bool parseSuccessful1 = int.TryParse(Console.ReadLine(), out int number1);
//int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.2:");
bool parseSuccessful2 = int.TryParse(Console.ReadLine(), out int number2);
//int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.3:");
bool parseSuccessful3 = int.TryParse(Console.ReadLine(), out int number3);
//int number3 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.4:");
bool parseSuccessful4 = int.TryParse(Console.ReadLine(), out int number4);
//int number4 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.5:");
bool parseSuccessful5 = int.TryParse(Console.ReadLine(), out int number5);
//int number5 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.6:");
bool parseSuccessful6 = int.TryParse(Console.ReadLine(), out int number6);
//int number6 = int.Parse(Console.ReadLine());

array[0] = number1;
array[1] = number2;
array[2] = number3;
array[3] = number4;
array[4] = number5;
array[5] = number6;

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        sum = sum + array[i];
    }
}

Console.WriteLine("The result is: " + sum);