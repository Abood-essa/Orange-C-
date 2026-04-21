namespace AdvanceOOPTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //task1
            int max = MathUtilities.getMax(4, 7);


            //task2
            double fahrenheit = Converter.CelsiusToFahrenheit(25);
            double miles = Converter.KilometersToMiles(10);

            Console.WriteLine("Celsius to Fahrenheit: " + fahrenheit);
            Console.WriteLine("Kilometers to Miles: " + miles);

            //task3
            VisitorCounter v1 = new VisitorCounter();
            VisitorCounter v2 = new VisitorCounter();
            VisitorCounter v3 = new VisitorCounter();
            Console.WriteLine(VisitorCounter.counter);

            //task4
            Company.CompanyName = "Tech Corp";

            Company emp1 = new Company { EmployeeName = "Ali" };
            Company emp2 = new Company { EmployeeName = "Sara" };
            Company emp3 = new Company { EmployeeName = "Omar" };

            emp1.PrintInfo();
            emp2.PrintInfo();
            emp3.PrintInfo();

            //Calculator task

            int twonumbers = Calculator.add(1, 2);
            int threeNumbers = Calculator.add(1, 2, 3);
            int decimalNumbers = Calculator.add(1, 2, 3);


            //📝 Task Description: Polymorphism(Method Overriding)

            Animal a1 = new Dog();
            Animal a2 = new Cat();

            a1.makeSound();
            a2.makeSound();



            //Task Description: Abstraction task
            WashingMachine wm = new WashingMachine();
            wm.Brand = "LG";

            AirConditioner ac = new AirConditioner();
            ac.Brand = "Samsung";

            wm.TurnOn();
            wm.TurnOff();

            Console.WriteLine();

            ac.TurnOn();
            ac.TurnOff();


            //📝 Task Description: Encapsulation
            BankAccount account = new BankAccount();

            account.Deposit(1000);
            account.Withdraw(300);
            account.Withdraw(800);

            Console.WriteLine($"Current Balance: {account.Balance}");



            //Task Description: Abstract Class task

            FullTimeEmployee full = new FullTimeEmployee
            {
                Name = "Ahmad",
                MonthlySalary = 3000
            };

            PartTimeEmployee part = new PartTimeEmployee
            {
                Name = "Ali",
                HourRate = 20,
                HoursWorked = 80
            };

            Console.WriteLine($"{full.Name} Salary: {full.CalculateSalary()}");
            Console.WriteLine($"{part.Name} Salary: {part.CalculateSalary()}");

        }
    }


    class PartTimeEmployee : Employee
    {
        public double HourRate { get; set; }
        public int HoursWorked { get; set; }

        public override double CalculateSalary()
        {
            return HourRate * HoursWorked; 
        }
    }

    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    abstract class Employee
    {
        public string Name { get; set; }

        public abstract double CalculateSalary();
    }

    class BankAccount
    {
        private double balance;




        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            else if (amount > balance)
            {
                Console.WriteLine(" Insufficient balance. Withdrawal denied.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
        }
    }

    class AirConditioner : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($"{Brand} Air Conditioner: Cooling mode activated.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Brand} Air Conditioner: Shutting down.");
        }
    }

    class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($" {Brand} Washing Machine: Starting wash cycle...");
        }

        public override void TurnOff()
        {
            Console.WriteLine($" {Brand} Washing Machine: Stopping wash cycle.");
        }
    }


    abstract class Appliance
    {

        public string Brand { get; set; }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }


    class Cat : Animal
    {

        public override void makeSound()
        {
            Console.WriteLine("this is a cat sound");
        }

    }
    class Dog : Animal
    {

        public override void makeSound()
        {
            Console.WriteLine("this is a dog sound");
        }

    }

    class Animal
    {

        public virtual void makeSound()
        {
            Console.WriteLine("this a animal sound");
        }
    }

    class Calculator
    {


        public static int add(int x, int z)
        {
            return x + z;

        }
        public static int add(int x, int z, int c)
        {
            return x + z + c;
        }

        public static int add(decimal x, decimal z, decimal c)
        {
            return (int)(x + z + c);
        }
    }
    class Company
    {
        public static string CompanyName { get; set; }

        public string EmployeeName { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Employee: {EmployeeName}, Company: {CompanyName}");
        }
    }

    class VisitorCounter
    {
        public static int counter = 0;


        public VisitorCounter()
        {
            counter++;
        }
    }



    class Converter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371;
        }
    }
    static class MathUtilities
    {


        public static int calculateSquare(int x)
        {

            return x * x;
        }

        static double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        public static int getMax(int x, int z)
        {
            return Math.Max(x, z);
        }
    }
}
