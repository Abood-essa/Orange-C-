using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Methods_list_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //linkedlist();
            //Task30();
            Task36();
        }
        static List<int> Task50(int[] nums, int value)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != value)
                {
                    result.Add(nums[i]);
                }
            }

            return result;
        }


        static bool Task45(int[] nums, int target)
        {
            int left = 0;
            int sum = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum > target && left <= right)
                {
                    sum -= nums[left];
                    left++;
                }

                if (sum == target)
                {
                    return true;
                }
            }

            return false;
        }
        static void Task44()
        {
            int[] arr = { 10, 5, 20, 8, 20 };
            int max = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] != max)
                {
                    secondMax = arr[i];
                }
            }
            Console.WriteLine(secondMax);
        }

        static void Task43()
        {
            int[] arr = { 1, 2, 2, 3, 1, 4, 2 };
            Array.Sort(arr);

            int count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(arr[i - 1] + " -> " + count);
                    count = 1;
                }
            }

            Console.WriteLine(arr[arr.Length - 1] + " -> " + count);
        }

        static void Task42()
        {
            int[] arr1 = [1, 2, 3];
            int[] arr2 = [4, 5, 6];
            List<int> result = new List<int>();

            int i = 0, j = 0;

            while (i < arr1.Length || j < arr2.Length)
            {
                if (i < arr1.Length)
                {
                    result.Add(arr1[i]);
                    i++;
                }

                if (j < arr2.Length)
                {
                    result.Add(arr2[j]);
                    j++;
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }

        static void Task41()
        {
            int[] arr = [0, 1, 0, 3, 12];
            int insertPos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[insertPos] = arr[i];
                    insertPos++;
                }
            }

            for (int i = insertPos; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

        }


        static void Task39()
        {
            int[] arr = [1, 3, 2, 4, 1];
            List<int> list = new List<int>();
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    list.Add(arr[i]);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
        static void Tas38()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    evens.Add(arr[i]);
                else
                    odds.Add(arr[i]);
            }

            evens.AddRange(odds);

            foreach (int num in evens)
            {
                Console.Write(num + " ");
            }
        }

        static void Task37()
        {
            int[] arr = { 1, 2, 3, 1, 4, 2, 1 };

            int minDistance = int.MaxValue;

            for (int l = 0; l < arr.Length; l++)
            {
                for (int r = l + 1; r < arr.Length; r++)
                {
                    if (arr[l] == arr[r])
                    {
                        int distance = r - l;

                        if (distance < minDistance)
                        {
                            minDistance = distance;
                        }

                        break; 
                    }
                }
            }

            Console.WriteLine(minDistance);
        }

        static void Task36()
        {
            int[] arr = { 1, 2, 2, 3, 4, 1, 2, 3 };

            int l = 0;
            int r = 1;
            int maxlen = 1;
            int currentlen = 1;
            List<int> list = new List<int>();
            while (r < arr.Length)
            {
                int[] arr = { 1, 2, 2, 3, 4, 1, 2, 3 };

                int l = 0;
                int r = 1;

                int maxlen = 1;
                int currentlen = 1;

                int bestStart = 0;

                while (r < arr.Length)
                {
                    if (arr[r] == arr[l] + 1)
                    {
                        currentlen++;
                    }
                    else
                    {
                        if (currentlen > maxlen)
                        {
                            maxlen = currentlen;
                            bestStart = l - currentlen + 1;
                        }

                        currentlen = 1;
                    }

                    l++;
                    r++;
                }

                if (currentlen > maxlen)
                {
                    maxlen = currentlen;
                    bestStart = l - currentlen + 1;
                }

                Console.Write("Longest sequence: ");
                for (int i = bestStart; i < bestStart + maxlen; i++)
                {
                    Console.Write(arr[i] + " ");
                }


            }

        static void Task35()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            int totalSum = arr.Sum();
            int leftSum = 0;

            int minDiff = int.MaxValue;
            int splitIndex = -1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                leftSum += arr[i];
                int rightSum = totalSum - leftSum;

                int diff = Math.Abs(leftSum - rightSum);

                if (diff < minDiff)
                {
                    minDiff = diff;
                    splitIndex = i;
                }
            }

            Console.WriteLine($"Best split at index: {splitIndex}");
            Console.WriteLine($"Minimum difference: {minDiff}");
        }

        static void Task32()
        {
            int[] arr = [1, 2, 3, 2, 1];
            int l = 0;
            int r = arr.Length - 1;
            bool isSymmetric = true;


            while (l < r)
            {
                if (arr[l] != arr[r])
                {
                    isSymmetric = false;
                    break;
                }
                l++;
                r--;
            }

            Console.WriteLine(isSymmetric);


        }

        static void Task31()
        {

        }


        static void Task30()
        {
            int[] arr = { 4, 7, 2, 4, 9, 4, 2, 7, 4, 3, 7, 2, 4 };

            int count = 0;
            int mostapperes = 0;
            int pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (mostapperes < count)
                {
                    mostapperes = count;
                    pos = i;
                }
            }
            Console.WriteLine("The  number that appears the most :" + arr[pos]);
        }
        static void Task29()
        {
            List<int> numbers = new List<int> { 10, 50, 30, 20, 40 };

            int largest = 0;
            int secondLargest = 0;

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            Console.WriteLine($"Second Largest: {secondLargest}");

        }


        static void Task28()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > 30)
                {
                    numbers.RemoveAt(i);
                }
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }

        static void Task27()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            int conutEven = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    conutEven++;
                }
            }
            Console.WriteLine("The even count is :" + conutEven);
        }

        static void Task26()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            int num = 30;
            bool found = false;
            foreach (int i in numbers)
            {
                if (i == num)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(found);
        }
        static void Task25()
        {
            Dictionary<string, int> data = new Dictionary<string, int>
        {
            { "A", 50 },
            { "B", 120 },
            { "C", 200 },
            { "D", 80 }
        };

            var filtered = data
                .Where(x => x.Value > 100)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Filtered Dictionary:");
            foreach (var item in filtered)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
        static void Task24()
        {
            Dictionary<string, int> scores = new Dictionary<string, int>
        {
            { "Ali", 90 },
            { "Sara", 85 },
            { "Omar", 78 }
        };

            List<int> list = scores.Values.ToList();

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        static void Task23()
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            var unique = numbers.Distinct();

            foreach (int i in unique)
            {
                Console.WriteLine(i);
            }
        }

        static void Task22()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

            var merged = list1.Concat(list2).ToList();

            foreach (var item in merged)
            {
                Console.WriteLine(item);
            }
        }



        static void Task21()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

            var common = list1.Intersect(list2);

            Console.WriteLine("Common elements:");
            foreach (var num in common)
            {
                Console.WriteLine(num);
            }
        }

        static void linq()
        {
            List<int> numbers = new List<int> { 42, 7, 19, 88, 3, 56, 23, 91, 14, 67 };

            var oddNumbers = numbers.Where(n => n % 2 != 0);

            var doubled = numbers.Select(x => x * 2).ToList();

            var sortdesc = numbers.OrderByDescending(x => x).ToList();

            var x = numbers.FirstOrDefault(n => n > 100);

            double average = numbers.Average();

        }

        static void linkedlist()
        {
            LinkedList<string> nav = new LinkedList<string>();
            nav.AddFirst("Home");
            nav.AddLast("Contact");
            nav.AddLast("About");
            nav.AddLast("Login");

            var node = nav.Find("About");
            nav.Remove(node);

            var contact = nav.Find("Contact");

            nav.AddAfter(contact, "after contact");
            nav.AddBefore(contact, "before contact");

            foreach (var item in nav)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(nav.First());
            Console.WriteLine(nav.Last());
        }

        static void Task10()
        {
            Dictionary<string, int> students = new Dictionary<string, int>
            {
              { "Ali", 75 },
              { "Sara", 90 },
              { "Omar", 82 },
              { "Lina", 68 },
              { "Ahmad", 95 }
            };

            var highest = students.OrderByDescending(s => s.Value).First();

            Console.WriteLine($"Top Student: {highest.Key} - {highest.Value}");
        }


        static void Task9()
        {
            Dictionary<string, int> students = new Dictionary<string, int>
            {
              { "Ali", 75 },
              { "Sara", 90 },
              { "Omar", 82 },
              { "Lina", 68 },
              { "Ahmad", 95 }
             };

            var toRemove = new List<string>();

            foreach (var student in students)
            {
                if (student.Value < 50)
                {
                    toRemove.Add(student.Key);
                }
            }

            foreach (var key in toRemove)
            {
                students.Remove(key);
            }


        }

        static void Task8()
        {
            Dictionary<string, int> students = new Dictionary<string, int>
            {
              { "Ali", 75 },
              { "Sara", 90 },
              { "Omar", 82 },
              { "Lina", 68 },
              { "Ahmad", 95 }
             };

            int total = students.Values.Sum();

            Console.WriteLine("total scores : " + total);
        }

        static void Task7()
        {
            Dictionary<string, int> students = new Dictionary<string, int>
            {
              { "Ali", 75 },
              { "Sara", 90 },
              { "Omar", 82 },
              { "Lina", 68 },
              { "Ahmad", 95 }
             };

            Console.WriteLine("Enter a student name");
            string name = Convert.ToString(Console.ReadLine());


            if (students.ContainsKey(name))
            {
                Console.WriteLine($"Score: {students[name]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        static void Task6()
        {
            Dictionary<string, int> students = new Dictionary<string, int>
    {
              { "Ali", 75 },
              { "Sara", 90 },
              { "Omar", 82 },
              { "Lina", 68 },
              { "Ahmad", 95 }
    };

            foreach (var student in students)
            {
                if (student.Value > 80)
                {
                    Console.WriteLine($"{student.Key} - {student.Value}");
                }
            }
        }

        static void Task5()
        {
            List<int> numbers = new List<int> { 42, 7, 19, 88, 3, 56, 23, 91, 14, 67 };

            var count = numbers.Count(n => n > 50);
            Console.WriteLine(count);

        }

        static void Task4()
        {
            List<int> numbers = new List<int> { 42, 7, 19, 88, 3, 56, 23, 91, 14, 67 };

            numbers.Reverse();
            Console.WriteLine(string.Join(", ", numbers));


        }

        static void Task3()
        {
            List<int> numbers = new List<int> { 42, 7, 19, 88, 3, 56, 23, 91, 14, 67 };

            var maximum = numbers.Max();
            Console.WriteLine(maximum);

        }

        static void Task2()
        {
            List<int> numbers = new List<int> { 5, 3, 8, 5, 2, 3, 9, 1, 8, 7, 2 };

            var list = numbers.Distinct().ToList();

            Console.WriteLine(string.Join(", ", list));

        }

        static void Task1()
        {
            List<int> numbers = new List<int> { 42, 7, 19, 88, 3, 56, 23, 91, 14, 67 };

            var numbers2 = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine(string.Join(", ", numbers2));
        }
    }
}
