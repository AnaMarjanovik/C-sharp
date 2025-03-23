
namespace Qinshift.Homework4.Task1.Models
{
    public class Car {

        public Car()
        {

        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        
        public string Model { get; set; }
        public int Speed { get; set; }

        public Driver Driver { get; set; }


        public int CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }

        public void RaceCars(Car car1,Car car2)
        {
            int car1Speed = car1.CalculateSpeed();
            int car2Speed = car2.CalculateSpeed();

            if (car1Speed > car2Speed)
            {
                Console.WriteLine("Car no.1 is faster.");
            }
            else if(car2Speed > car1Speed)
            {
                Console.WriteLine("Car no.2 is faster.");
            }
            else
            {
                Console.WriteLine("It's a tie !");
            }
        }
    }
}
