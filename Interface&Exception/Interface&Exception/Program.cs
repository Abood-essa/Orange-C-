namespace Interface_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            try
            {
                Console.WriteLine("Enter first number to add");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter secound Number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("the sum is "+c1.Add(a, b));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }

        }
    }

    interface ICalculator
    {
        int Add(int a, int b);
    }

    class Calculator : ICalculator
    {


        public int Add(int a, int b)
        {
            return a + b;
        }
    }

}
