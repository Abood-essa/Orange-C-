namespace Loops_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task1();
            Console.WriteLine("////////////////////////////");
            Task2();
            Console.WriteLine("////////////////////////////");
            Task3();
            Console.WriteLine("////////////////////////////");
            //Task4();
            Console.WriteLine("////////////////////////////");
            //Task5();
            Console.WriteLine("////////////////////////////");
            Task6();
        }

        static void Task6()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }

        static void Task5()
        {
            Console.WriteLine("Enter your name");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + name + " Your age is " + age);
            Console.WriteLine($"Your name is  {name}  Your age is  {age}");

            Console.WriteLine("First letter of your name is " + name[0]);
            Console.WriteLine("Last letter of your name is " + name[name.Length-1]);
            Console.WriteLine($"Name :\t {name} \nAge :{age}");

        }

        static void Task4()
        {
            Console.WriteLine("Enter Your full name :");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Height (in meters, e.g., 1.75)");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Are you Employed (true / false) ?");
            bool isEmployed = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("--- User Profile ---");
            Console.WriteLine("Name:  " + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Employed: " + isEmployed);
        }

        static void Task3()
        {
            List<int> even = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Even array: [" + string.Join(", ", even) + "]");

        }

        static void Task2()
        {
            int[] numbers = { 12, 7, 25, 3, 18, 42, 9, 30 };
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
        }



        static void Task1()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int countEven = 0;
            int countOdd = 0;
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (numbers[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                    countOdd++;
            }
            double avg = sum / numbers.Length;

            List<int> aboveAvg = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > avg)
                {
                    aboveAvg.Add(numbers[i]);
                }
            }
            Console.WriteLine("Even Count : " + countEven);
            Console.WriteLine("Odd Count : " + countOdd);
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Avareage : " + avg);
            Console.WriteLine("Filtered array: [" + string.Join(", ", aboveAvg) + "]");

        }
    }
}
