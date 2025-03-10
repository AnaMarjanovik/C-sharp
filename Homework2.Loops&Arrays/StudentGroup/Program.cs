
string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Ana", "Simona", "Sandra", "Angel", "Marija" };

Console.WriteLine("Enter student group: (there are 1 or 2)");
bool parseSuccessful = int.TryParse(Console.ReadLine(), out int group);
//int group = int.Parse(Console.ReadLine());

if (group == 1)
{
    Console.WriteLine("The students in G1 are: ");
    for (int i = 0; i < studentsG1.Length; i++)
    {
        Console.WriteLine(studentsG1[i]);
    }
}
else
{
    Console.WriteLine("The students in G2 are: ");
    for (int i = 0; i < studentsG2.Length; i++)
    {
        Console.WriteLine(studentsG2[i]);
    }
}

