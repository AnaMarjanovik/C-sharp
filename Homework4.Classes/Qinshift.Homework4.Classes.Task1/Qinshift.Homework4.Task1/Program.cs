

using Qinshift.Homework4.Task1.Models;

Car carOne = new Car("Hyndai", 110);
Car carTwo = new Car("Mazda", 220);
Car carThree = new Car("Ferrari", 230);
Car carFour = new Car("Porsche", 220);



Driver driverOne = new Driver("Bob", 1);
Driver driverTwo = new Driver("Greg", 2);
Driver driverThree = new Driver("Jill", 3);
Driver driverFour = new Driver("Anne", 4);


Console.WriteLine("Choose a car number 1: (Hyndai, Mazda, Ferrari, Porsche)");
string carNumberOne = Console.ReadLine();
Car car1;
switch (carNumberOne)
{
    case "Hyndai":
        car1 = carOne;
        break;
    case "Mazda":
        car1 = carTwo;
        break;
    case "Ferrari":
        car1 = carThree;
        break;
    default:
        car1 = carFour;
        break;
}


Console.WriteLine("Choose a driver for car number 1: (Bob,Greg,Jill,Anne)");
string driverNumberOne = Console.ReadLine();
Driver driver1;
switch (driverNumberOne)
{
    case "Bob":
        driver1 = driverOne;
        break;
    case "Greg":
        driver1 = driverTwo;
        break;
    case "Jill":
        driver1 = driverThree;
        break;
    default:
        driver1 = driverFour;
        break;
}

Console.WriteLine("Choose a car number 2: (Hyndai, Mazda, Ferrari, Porsche)");
string carNumberTwo = Console.ReadLine();
Car car2;
switch (carNumberTwo)
{
    case "Hyndai":
        car2 = carOne;
        break;
    case "Mazda":
        car2 = carTwo;
        break;
    case "Ferrari":
        car2 = carThree;
        break;
    default:
        car2 = carFour;
        break;
}



Console.WriteLine("Choose a driver for car number 2: (Bob,Greg,Jill,Anne)");
string driverNumberTwo = Console.ReadLine();
Driver driver2;
switch (driverNumberTwo)
{
    case "Bob":
        driver2 = driverOne;
        break;
    case "Greg":
        driver2 = driverTwo;
        break;
    case "Jill":
        driver2 = driverThree;
        break;
    default:
        driver2 = driverFour;
        break;
}


car1.Driver = driver1;
car2.Driver = driver2;

car1.RaceCars(car1, car2);


