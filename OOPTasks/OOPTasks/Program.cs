namespace OOPTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Name = "Abd";
            p1.Age = 21;
            Console.WriteLine(p1.Name+" "+p1.Age);

            Student s1= new Student();
            s1.Name = "saeed";
            s1.Age = 22;
            s1.Gpa = 3.3;

            Console.WriteLine($"student name is {s1.Name} and age is {s1.Age} and gpa is {s1.Gpa}");


            Car car = new Car("Toyota", 2022, "SUV", 25000, "RAV4", "P123", "Black");


            Console.WriteLine(car.GetCarInfo());
        }
    }
}
