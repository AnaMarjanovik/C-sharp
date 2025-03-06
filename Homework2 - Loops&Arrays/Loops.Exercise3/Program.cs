Console.WriteLine("Enter the input!");
int input = int.Parse(Console.ReadLine());

if (input < 100)
{
    for (int i = 1; i <= input; i++)
    { 
        if (i % 3 != 0 && i % 7 != 0)
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("The limit is reached and stop counting");
}
