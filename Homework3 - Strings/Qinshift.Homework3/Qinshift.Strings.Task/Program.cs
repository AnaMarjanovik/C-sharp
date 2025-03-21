static void AgeCalculator()
{
    Console.WriteLine("Enter your birthday using the following format (dd/mm/yyy)");

    string birthday = Console.ReadLine();

    DateTime convertedBirthday = DateTime.Parse(birthday);

    DateTime currentDate = DateTime.Today;

    int age;
    Console.WriteLine("Has your birthday passed?");
    string answer = Console.ReadLine();
    if (answer.ToUpper() == "YES")
    {
        age = currentDate.Year - convertedBirthday.Year;
        Console.WriteLine($"You are {age} years old!");
    }
    else if (answer.ToUpper() == "NO")
    {
        age = currentDate.Year - convertedBirthday.Year;
        Console.WriteLine($"You are currently {age - 1} years old but after a few months, you will be {age} years old!");
    }
    else
    {
        Console.WriteLine("You enter an invalid answer !!!");
    }



}

AgeCalculator();