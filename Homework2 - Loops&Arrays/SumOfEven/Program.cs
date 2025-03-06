int[] array = new int[6];

Console.WriteLine("Enter integer no.1:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.2:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.3:");
int number3 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.4:");
int number4 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.5:");
int number5 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.6:");
int number6 = int.Parse(Console.ReadLine());

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
