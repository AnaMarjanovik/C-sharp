
Console.WriteLine("Enter the first input number.");
int input1 = int.Parse(Console.ReadLine());

for(int i=2; i<=input1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}


Console.WriteLine("Enter the second input number.");
int input2 = int.Parse(Console.ReadLine());

for (int i = 1; i <= input2; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}