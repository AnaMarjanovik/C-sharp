

#region Exercise5
Console.WriteLine("Enter number of apples on each branch.");
int numberOfApplesOnBrench = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number of apples in one basket.");
int numberApplesBasket = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number of trees.");
int trees = int.Parse(Console.ReadLine());

int final = trees * ((12 * numberOfApplesOnBrench) / numberApplesBasket);
Console.WriteLine(final);
#endregion



#region Exercise6


int variable1 = 7;
int variable2 = 666;

if(variable1 > variable2)
{
    Console.WriteLine("The larger number from the two is " + variable1);
    if (variable1 % 2 == 0)
    {
        Console.WriteLine("And the number is even.");
    }
    else
    {
        Console.WriteLine("And the number is odd.");
    }
}
else if(variable2 > variable1)
{
    Console.WriteLine("The larger number from the two is " + variable2);
    if (variable2 % 2 == 0)
    {
        Console.WriteLine("And the number is even.");
    }
    else
    {
        Console.WriteLine("And the number is odd.");
    }
}
else
{
    Console.WriteLine("Variables are equal.");
}







#endregion

#region Exercise7

Console.WriteLine("Enter a number from 1 to 3.");
int number = int.Parse(Console.ReadLine());

// if-else

//if(number == 1)
//{
//    Console.WriteLine("You got a new car!");
//}
//else if(number == 2)
//{
//    Console.WriteLine("You got a new plane!");
//}
//else if(number == 3)
//{
//    Console.WriteLine("You got a new bike!");
//}
//else
//{
//    Console.WriteLine("ERROR: You entered a wrong number!");
//}


// switch case
switch (number)
{
    case 1:
        Console.WriteLine("You got a new car!");
        break;
    case 2:
        Console.WriteLine("You got a new plane!");
        break;
    case 3:
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("ERROR: You entered a wrong number!");
        break;
}





#endregion

