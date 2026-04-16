namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateAverage(2,3,4);
            Task2();
            Task3();

            Task4();
        }

        static void Task4()
        {
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };

            var result = numbers.Where(n => n > 15);
            foreach (int num in numbers)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
            var evenNumbers=numbers.Where(n => n %2==0);
            foreach (int num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            var asendSorted=numbers.OrderBy(n => n);
            var desSorted=numbers.OrderByDescending(n=>n);

            var startWithA=names.Where(n=>n.StartsWith("A"));
            foreach(string name in names)
            {
                Console.Write(name+" ");
            }

        }

        static void Task3()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Ahmed");
            dict.Add(2, "Ali");
            dict.Add(3, "Abd");

            foreach (var item in dict)
            {

                Console.WriteLine("id : "+item.Key + " -  name : " + item.Value);

            }
        }

        static void Task2()
        {
            List<string> list = new List<string>();
            list.Add("Ahmed");
            list.Add("sanad");
            list.Add("Husaam");
            list.Add("Abd");
            list.Add("Saeed");



            foreach (string item in list)
            {
                Console.WriteLine(item);

            }

            list.Remove("Ahmed");

        }

        static double CalculateAverage(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }
    }
}
