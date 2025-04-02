using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.ATM.Models
{
    public class Customer
    {
        public Customer()
        {
            
        }

        public Customer(string firstName,string lastName,string cardNumber, string pin, int money)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Money = money;
            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        public string Pin { get; set; }
        public int Money { get; set; }


        public bool checkIfExist(string inputCardNumber, string inputPin)
        {
            if(CardNumber == inputCardNumber && Pin == inputPin)
            {
              
                    Console.WriteLine($"Welcome {FirstName} {LastName}!");
                    return true;
            }
            return false;
        }

        public void customerChoice(int inputChoice)
        {
            switch (inputChoice)
            {
                case 1:
                    Console.WriteLine($"Current balance of money on your account is {Money}$.");
                    break;
                case 2:
                    Console.WriteLine("Enter how much money you want to withdraw?");
                    int withdraw = int.Parse(Console.ReadLine());
                    if(Money > withdraw)
                    {
                        Console.WriteLine($"You withdrew {withdraw}$. You have {Money - withdraw}$ left on your account.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money to withdraw.");
                    }
                        break;
                case 3:
                    Console.WriteLine("Enter how much money you want to deposit.");
                    int deposit = int.Parse(Console.ReadLine());
                    Console.WriteLine($"You deposit {deposit}$. You have {Money + deposit}$ on your account.");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        
    }
}
