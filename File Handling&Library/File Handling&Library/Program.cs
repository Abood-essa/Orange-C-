namespace File_Handling_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File.WriteAllText("data.txt", "Abd Al Hameed");
                File.AppendAllText("data.txt", "\n21 years old");

                string[] lines = File.ReadAllLines("data.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                File.AppendAllText("data.txt", "\nThis is a new line");

                lines = File.ReadAllLines("data.txt");
                Console.WriteLine("After Appending");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
