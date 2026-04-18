using System;
using System.Globalization;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiscordTasks


{

    class DateConverter
    {
        public void Convert(string dateString)
        {
            DateTime date = DateTime.ParseExact(
                dateString,
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture
            );

            Console.WriteLine("Converted Date: " + date.ToString("yyyy-MM-dd"));
        }
    }

    class DateDifference
    {
        public void Calculate(DateTime d1, DateTime d2)
        {
            if (d1 > d2)
            {
                var temp = d1;
                d1 = d2;
                d2 = temp;
            }

            int years = d2.Year - d1.Year;
            int months = d2.Month - d1.Month;
            int days = d2.Day - d1.Day;

            if (days < 0)
            {
                months--;
                DateTime prevMonth = d2.AddMonths(-1);
                days += DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Difference: {years} years, {months} months, {days} days.");
        }
    }

    class SortClass
    {
        public void SortArray(int[] array)
        {
            Array.Sort(array);

            Console.Write("Sorted array: { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" }");
        }
    }
    class FactorialClass
    {
        public int Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    class MyClass2
    {
        public void Introduce(string name)
        {
            Console.WriteLine($"Hello All, I am {name}");
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass class has initialized!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isRepdigit(0));

        }




        ///////////////////////////////////////////////////File six Discord

        static void countWords(string sentece)
        {
            var arr = sentece.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(arr.Length);
        }

        static bool IsPrime(int n)
        {

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static bool IsLeapYear(int year)
        {
            return year >= 1900 && year <= 2024 &&
                   (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        }

        static int Power(int baseNum, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        static string Login(string username, string password)
        {
            string[] users = { "admin:1234", "ali:1111", "sara:2222" };

            foreach (string user in users)
            {
                string[] parts = user.Split(':');

                string storedUsername = parts[0];
                string storedPassword = parts[1];

                if (storedUsername == username && storedPassword == password)
                {
                    return "pass";
                }
            }

            return "failed";
        }

        static int animals(int chickens, int cows, int pigs)
        {
            if (chickens < 0 || cows < 0 || pigs < 0)
                return -1;

            return (chickens * 2) + (cows * 4) + (pigs * 4);
        }

        static int ageInDays(int age)
        {
            return age * 365;
        }

        static int[] getYears(int[] years)
        {
            List<int> list = new List<int>();

            foreach (int year in years)
            {
                if (year > 1950)
                {
                    list.Add(year);
                }
            }

            return list.ToArray();
        }

        static void cubeToNum(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("The cube of the num " + i + " is " + (i * i * i));
            }
        }

        static void Task1()
        {
            List<int> list = new List<int>();
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
                sum += num;
            }
            Console.WriteLine("The sum is " + sum + " the avareage is " + (sum / 10));

        }


        /////////////////////////////////////////////File Five Discord
        static void Task7()
        {
            int rows = 4;
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }

                Console.WriteLine();
            }
        }
        static void Task6()
        {
            int rows = 3;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void Task5()
        {
            int sum = 0;

            Console.WriteLine("The odd numbers are:");

            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine("The Sum of odd Numbers is: " + sum);
        }

        static void Task4()
        {
            Console.Write("Input three numbers separated by comma: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(',');

            int num1 = int.Parse(parts[0]);
            int num2 = int.Parse(parts[1]);
            int num3 = int.Parse(parts[2]);

            int sum = num1 + num2 + num3;

            Console.WriteLine("The sum of three numbers: " + sum);
        }

        static void task3()
        {
            string[] food = { "molokia", "mansaf", "makshi", "shawerma", "burger" };
            string[] sports = { "football", "basketball", "volyball" };
            string[] movies = { "spiderman", "intersteller", "se7en", "fight club" };

            foreach (string s in food)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            foreach (string s in sports)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();
            foreach (string s in movies)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }

        //        2-	What the index of "Banana","Tomato"?
        //String[] fruits = ["Tomato", "Banana", "Watermelon"]

        //tomato =0 banana=1


        //        1-	Correct the syntax error:

        //•	string[] ARR = [1, 7 , 9 , 45,]
        //•	int[] arr2 = ["Str" "alex","moh"]
        //•	string arr3= ["the","fox", "over" ,"lazy", "dog"  ]



        ////////////////////////////////////////////////////File Four Discord

        static string ReverseOdd(string text)
        {
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] chars = words[i].ToCharArray();
                    Array.Reverse(chars);
                    words[i] = new string(chars);
                }
            }

            return string.Join(" ", words);
        }
        static void fixedStrings(string[] arr)
        {
            int fixedLength = 30;

            foreach (string s in arr)
            {
                Console.WriteLine(s.PadRight(fixedLength));
            }
        }
        static void minutesToHours(int totalMinutes)
        {
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;

            Console.WriteLine($"{hours} Hours, {minutes} Minutes");
        }

        static void hoursToMinits(int hours, int minits)
        {
            int totalmin = (hours * 60) + minits;
            Console.WriteLine(totalmin);
        }

        static void kiloToMiles(int kilos)
        {
            Console.WriteLine(kilos * 0.62 + " miles");
        }

        static void max(int[] arr)
        {
            int max = 0;
            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("the max is " + max);
        }
        static void sortUsingConditions(int a, int b, int c)
        {
            int temp;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            if (a > c)
            {
                temp = a;
                a = c;
                c = temp;
            }

            if (b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }

            Console.WriteLine($"{a}, {b}, {c}");
        }

        static void getSign(int n)
        {
            if (n < 0)
                Console.WriteLine("The sign is - ");
            else
                Console.WriteLine("The sign is + ");
        }

        static int getSmaller(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;

        }






        ///////////////////////////////////////////////////////File Three Discord

        static int sumOfCubes(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += (int)Math.Pow(num, 3);
            }
            return sum;
        }

        static string removeLastVowel(string s)
        {
            string vowels = "aeiouAEIOU";
            var words = s.Split(' ');

            for (int w = 0; w < words.Length; w++)
            {
                string word = words[w];

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    if (vowels.Contains(word[i]))
                    {
                        word = word.Remove(i, 1);
                        break;
                    }
                }

                words[w] = word;
            }

            return string.Join(" ", words);


        }

        static string convertTime(string time12)
        {
            string period = time12.Substring(time12.Length - 2);
            string[] parts = time12.Substring(0, 8).Split(':');

            int hour = int.Parse(parts[0]);

            if (period == "AM")
            {
                if (hour == 12)
                    hour = 0;
            }
            else
            {
                if (hour != 12)
                    hour += 12;
            }

            return $"{hour:D2}:{parts[1]}:{parts[2]}";
        }

        static int[] removeDups(int[] nums)
        {
            return nums.Distinct().ToArray();
        }
        static int findNaN(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (double.IsNaN(arr[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        static bool matchLastItem(object[] arr)
        {
            if (arr.Length == 0) return false;

            string last = arr[arr.Length - 1].ToString();
            string combined = "";

            for (int i = 0; i < arr.Length - 1; i++)
            {
                combined += arr[i].ToString();
            }

            return combined == last;
        }

        static string capToFront(string s)
        {
            string upper = "";
            string lower = "";

            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                    upper += c;
                else
                    lower += c;

            }
            return upper + lower;
        }

        static int countTrue(bool[] arr)
        {
            return arr.Count(x => x == true);
        }

        static string insertWhitespace(string text)
        {

            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                result += text[i];
                if (i < text.Length - 1 && Char.IsLower(text[i]) && Char.IsUpper(text[i + 1]))
                {
                    result += " ";
                }
            }
            return result;

        }

        static string sevenBoom(int[] arr)
        {
            foreach (int i in arr)
            {
                if (i.ToString().Contains('7'))
                {
                    return i + " has a 7 in it";
                }
            }
            return "None of the items contain 7 within them.";
        }
        static string reverseStringWords(string s)
        {
            var arr = s.Split(' ');
            arr.Reverse();
            return string.Join(" ", arr);
        }

        static bool isRepdigit(int x)
        {
            if (x >= 0)
            {
                string s = x.ToString();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != s[0])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        static int secondLargest(int[] arr)
        {
            return arr.Distinct().OrderByDescending(x => x).Skip(1).First();
        }

        static string removeLeadingTrailing(string text)
        {
            text = text.TrimStart('0');

            if (string.IsNullOrEmpty(text) || text == ".")
                return "0";

            if (text.Contains('.'))
            {
                text = text.TrimEnd('0');

                if (text.EndsWith("."))
                    text = text.TrimEnd('.');
            }
            return text;
        }

        static Func<int, int> Add(int n)
        {
            return AddTo;

            int AddTo(int x)
            {
                return n + x;
            }
        }

        ////////////////////////////////////////////File Two Discord

        static bool isPandigital(long number)
        {
            string s = number.ToString();

            for (char digit = '0'; digit <= '9'; digit++)
            {
                if (!s.Contains(digit))
                    return false;
            }

            return true;
        }


        static string reversOddStrings(string s)
        {
            var arr = s.Split(' ');
            List<string> list = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length % 2 != 0)
                {
                    list.Add(new string(arr[i].Reverse().ToArray()));
                }
                else
                {
                    list.Add(arr[i]);
                }
            }
            return string.Join(" ", list.ToArray());
        }

        static string[] getStringWithNumbers(string[] strings)
        {

            List<string> list = new List<string>();

            foreach (string str in strings)
            {
                foreach (char c in str)
                {
                    if (char.IsDigit(c))
                    {
                        list.Add(str);
                        break;
                    }
                }
            }
            return list.ToArray();
        }

        static int getDate(DateTime date1, DateTime date2)
        {
            TimeSpan difference = date2 - date1;
            return Math.Abs(difference.Days);
        }
        static double aveArray(double[] x)
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum / x.Length;
        }
        ///////////////////////////////////////File One Discord
        static int muti2(int a, int b)
        {
            int result = 1;
            for (int i = a; i <= b; i++)
            {
                result *= i;
            }
            return result;
        }

        static int multiplication2(int a, int b)
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
            }
            return sum;
        }

        static int[] powerElementIndex(int[] powerElement)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < powerElement.Length; i++)
            {
                result.Add((int)Math.Pow(powerElement[i], i));
            }
            return result.ToArray();
        }

        static string[] evenIndexOddLength(string[] array)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length % 2 != 0 && i % 2 == 0)
                {
                    list.Add(array[i]);
                }
            }
            return list.ToArray();
        }

        static int[] evenNumberEvenIndex(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && i % 2 == 0)
                {
                    list.Add(arr[i]);
                }
            }
            return list.ToArray();
        }

        static double calculateArea(double baselen, double height)
        {
            return baselen * height;
        }
        static int firstElement(int[] arr)
        {
            return arr[0];
        }

        static int incrementOne(int x)
        {
            return x + 1;
        }
        static double toSeconds(int minutes)
        {
            return minutes * 60;
        }
    }
}
