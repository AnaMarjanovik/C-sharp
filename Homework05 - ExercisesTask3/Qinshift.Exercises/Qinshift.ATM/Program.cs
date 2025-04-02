

// ATM APP

using Qinshift.ATM.Models;

Customer customer1 = new Customer("Ana", "Marjanovik", "1234-1234-1234-1234", "1234", 600);
Customer customer2 = new Customer("Ivica", "Rodikj", "5678-5678-5678-5678", "5678", 700);
Customer customer3 = new Customer("Dimitar", "Stojkov", "9101-9101-9101-9101", "9101", 800);

Console.WriteLine("Welcome to the ATM app !");

Console.WriteLine("Please enter yor card number. (xxx-xxx-xxx-xxx)");
string cardNumber = Console.ReadLine();

Console.WriteLine("Enter Pin:");
string pin = Console.ReadLine();


Customer authenticatedCustomer = null;

if (customer1.checkIfExist(cardNumber, pin))
{
    authenticatedCustomer = customer1;
}
else if (customer2.checkIfExist(cardNumber, pin))
{
    authenticatedCustomer = customer2;
}
else if (customer3.checkIfExist(cardNumber, pin))
{
    authenticatedCustomer = customer3;
}


Console.WriteLine("What would you like to do:");
Console.WriteLine("1.Check Balance \n2.Cash Withdrawal \n3.Cash Deposit");

int choice;
if (int.TryParse(Console.ReadLine(), out choice))
{
    authenticatedCustomer.customerChoice(choice); 
}
else
{
    Console.WriteLine("Invalid input.");
}

Console.WriteLine("Thank you for using the ATM app.");











