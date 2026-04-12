namespace Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter your performance rating");
            //int rating=Convert.ToInt32(Console.ReadLine());

            //if (rating >= 90 && rating <= 100)
            //{
            //    Console.WriteLine("“Excellent” + 20% bonus");
            //}else if(rating >=75 &&  rating <= 89)
            //{
            //    Console.WriteLine("“Very Good” + 15% bonus");
            //}else if(rating >=60 &&  rating <= 74)
            //{
            //    Console.WriteLine("“Good” + 10% bonus");
            //}else if (rating < 60)
            //{
            //    Console.WriteLine("“No bonus”");
            //}

            //////////////////////////////////////

            //Console.WriteLine("Enter your GPA");
            //int gpa = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("did you pass your english test (true/false)");
            //bool pass = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("Do you have special recommindation (true/false)");
            //bool spicail = Convert.ToBoolean(Console.ReadLine());

            //if (gpa >= 85 && pass || spicail)
            //{
            //    Console.WriteLine("student is eligible ");
            //}
            //else
            //{
            //    Console.WriteLine("student is not eligible ");
            //}

            ////////////////////////////////////



            //Console.WriteLine("how much is the weight");
            //double weight= Convert.ToDouble(Console.ReadLine());
            //if(weight <= 1)
            //{
            //    Console.WriteLine("you will be charged $5");
            //}else if(weight <=5 &&  weight > 1)
            //{
            //    Console.WriteLine("you will be charged $10");
            //}else if(weight <=10 && weight > 5)
            //{
            //    Console.WriteLine("you will be charged $20");
            //}else if(weight > 10)
            //{
            //    Console.WriteLine("you will be charged $50 + extra warning “Heavy package”");
            //}


            //////////////////////////////////////

            //string coorectUserName = "abd";
            //string correctPassword = "1234";
            //int count = 0;

            //while (true)
            //{

            //    Console.WriteLine("Enter the Username");
            //    string usernameinput = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine("Enter the Password");
            //    string passwordInput = Convert.ToString(Console.ReadLine());



            //    if (coorectUserName == usernameinput && correctPassword == passwordInput)
            //    {
            //        Console.WriteLine("Login successful");
            //        return;
            //    }
            //    else if (coorectUserName == usernameinput || correctPassword == passwordInput)
            //    {
            //        Console.WriteLine("Invalid credentials");
            //    }
            //    else if(count !=2)
            //        Console.WriteLine("try again");

            //    count++;
            //    if (count >= 3)
            //    {
            //        Console.WriteLine("Account locked");
            //        return;
            //    }
            //}
            ///////////////////////////////////
            //*Switch Tasks (1)


            //Console.WriteLine("=== Restaurant Menu ===");
            //Console.WriteLine("1 → Burger ($5)");
            //Console.WriteLine("2 → Pizza ($8)");
            //Console.WriteLine("3 → Pasta ($7)");
            //Console.WriteLine("4 → Salad ($4)");
            //Console.Write("Select an item (1-4): ");

            //int choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("You selected: Burger - $5");
            //        break;

            //    case 2:
            //        Console.WriteLine("You selected: Pizza - $8");
            //        break;

            //    case 3:
            //        Console.WriteLine("You selected: Pasta - $7");
            //        break;

            //    case 4:
            //        Console.WriteLine("You selected: Salad - $4");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid choice. Please select between 1 and 4.");
            //        break;
            //}


            //////////////////////////////////////
            //*Task (2)


            //Console.Write("Enter grade (A, B, C, D, F): ");
            //char grade = char.ToUpper(Console.ReadLine()[0]);

            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;

            //    case 'B':
            //        Console.WriteLine("Very Good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("Good");
            //        break;

            //    case 'D':
            //        Console.WriteLine("Pass");
            //        break;

            //    case 'F':
            //        Console.WriteLine("Fail");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid grade entered.");
            //        break;
            //}

            ///////////////////////////////
            //*Task(3)

            //double balance = 1000; // initial balance
            //int choice;

            //do
            //{
            //    Console.WriteLine("\n=== ATM Menu ===");
            //    Console.WriteLine("1 → Check Balance");
            //    Console.WriteLine("2 → Deposit Money");
            //    Console.WriteLine("3 → Withdraw Money");
            //    Console.WriteLine("4 → Exit");
            //    Console.Write("Choose an option: ");

            //    choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine($"Your balance is: ${balance}");
            //            break;

            //        case 2:
            //            Console.Write("Enter amount to deposit: ");
            //            double deposit = double.Parse(Console.ReadLine());
            //            balance += deposit;
            //            Console.WriteLine("Deposit successful.");
            //            break;

            //        case 3:
            //            Console.Write("Enter amount to withdraw: ");
            //            double withdraw = double.Parse(Console.ReadLine());

            //            if (withdraw <= balance)
            //            {
            //                balance -= withdraw;
            //                Console.WriteLine("Withdrawal successful.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Insufficient balance.");
            //            }
            //            break;

            //        case 4:
            //            Console.WriteLine("Thank you for using the ATM!");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice.");
            //            break;
            //    }

            //} while (choice != 4);

            ///////////////////////////////////////
            //*Task(4)


            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("\nChoose operation:");
            //Console.WriteLine("1 → Addition");
            //Console.WriteLine("2 → Subtraction");
            //Console.WriteLine("3 → Multiplication");
            //Console.WriteLine("4 → Division");
            //Console.Write("Your choice: ");

            //int choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine($"Result: {num1 + num2}");
            //        break;

            //    case 2:
            //        Console.WriteLine($"Result: {num1 - num2}");
            //        break;

            //    case 3:
            //        Console.WriteLine($"Result: {num1 * num2}");
            //        break;

            //    case 4:
            //        if (num2 != 0)
            //            Console.WriteLine($"Result: {num1 / num2}");
            //        else
            //            Console.WriteLine("Error: Cannot divide by zero.");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid choice.");
            //        break;
            //}

        }
    }
}
