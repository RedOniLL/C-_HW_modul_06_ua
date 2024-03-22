

namespace C__HW_modul_06_ua;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 0:
                    Task1.MoneyBase money = new Task1.MoneyBase(10, 50);
                    money.PrintAmount();
              
                    Task1.Product product = new Task1.Product(20, 75);
                    product.PrintAmount();

                    product.DecreasePrice(5, 25);
                    break;
                case 1:
                    Task2.Kettle kettle = new Task2.Kettle("Electric Kettle", "Boils water quickly");
                    kettle.Show();
                    kettle.Desc();
                    kettle.Sound();

                    Task2.Microwave microwave = new Task2.Microwave("Microwave Oven", "Heats food using microwaves");
                    microwave.Show();
                    microwave.Desc();
                    microwave.Sound();

                    Task2.Car car = new Task2.Car("Toyota Camry", "Sedan car with good fuel efficiency");
                    car.Show();
                    car.Desc();
                    car.Sound();

                    Task2.Steamboat steamboat = new Task2.Steamboat("Steamboat", "Powered by steam engine");
                    steamboat.Show();
                    steamboat.Desc();
                    steamboat.Sound();
                    break;
                case 2:
                    Task3.Violin violin = new Task3.Violin("Violin", "Four-stringed bowed instrument");
                    violin.Show();
                    violin.Desc();
                    violin.Sound();
                    violin.History();

                    Task3.Trombone trombone = new Task3.Trombone("Trombone", "Brass instrument with a slide");
                    trombone.Show();
                    trombone.Desc();
                    trombone.Sound();
                    trombone.History();

                    Task3.Ukulele ukulele = new Task3.Ukulele("Ukulele", "Four-stringed instrument, similar to a guitar");
                    ukulele.Show();
                    ukulele.Desc();
                    ukulele.Sound();
                    ukulele.History();

                    Task3.Cello cello = new Task3.Cello("Cello", "Large string instrument, played between the legs");
                    cello.Show();
                    cello.Desc();
                    cello.Sound();
                    cello.History();
                    break;

                case 3:
                    Task4.WorkerBase president = new Task4.President();
                    president.Print();

                    Task4.WorkerBase security = new Task4.Security();
                    security.Print();

                    Task4.WorkerBase manager = new Task4.Manager();
                    manager.Print();

                    Task4.WorkerBase engineer = new Task4.Engineer();
                    engineer.Print();
                    break;
        }
            
        }
    }

