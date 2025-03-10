string[] names = new string[] { "Ana", "Ivica", "Dimitar", "Bojana" };


Console.WriteLine("Enter the name you want to add!");
string name = Console.ReadLine();

Array.Resize(ref names, names.Length + 1);
names[names.Length - 1] = name;

while (true)
{
    Console.WriteLine("Do you want to enter another name (Y/N)?");
    string answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("Enter the name!");
        string newName = Console.ReadLine();

        Array.Resize(ref names, names.Length + 1);
        names[names.Length - 1] = newName;
    }
    else if (answer == "N")
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        return 0;
    }
}
