namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task4();
            //Task5();
            //Task6();
            //Task9();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            //Task15();
            //Task16();
            //Task17();
            //Task21();
            //Task26v2();
            //Task29();
            //Task27();

        }

        static void Task9()
        {
            int n = 3;
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
        static void Task27()
        {
            string s = "abc";
            string newS = "";

            for (int i = 0; i < s.Length; i++)
            {
                newS += Convert.ToChar(s[i] + 1);
            }
            Console.WriteLine(newS);
        }

        static void Task29()
        {
            string s = "abca";
            int ans = 0;
            int l = 0;
            int r = 1;
            char ans2 = '\0';

            while (r < s.Length)
            {
                if (s[l] != s[r])
                {
                    r++;
                }
                else
                {
                    ans = Math.Max(ans, (r - l));
                    if (ans == (r - l))
                    {
                        ans2 = s[l];
                    }
                    l = r;
                    r = l + 1;
                    r++;
                }
            }
            Console.WriteLine(ans2 + " => " + ans);

        }

        static void Task26v2()
        {
            string s = "aaabbccccd";
            int l = 0;
            int r = 1;
            int ans = 0;

            while (r < s.Length)
            {
                if (s[l] == s[r])
                {
                    r++;
                }
                else
                {
                    l = r;
                    r = l + 1;
                }
                ans = Math.Max(ans, (r - l));

            }
            Console.WriteLine(ans);

        }

        static void Task26()
        {
            string s = "aaabbccccd";
            int longest = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = i; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;
                    }
                    else
                        break;
                }
                if (count > longest)
                    longest = count;

            }
            Console.WriteLine(longest);
        }

        static void Task21()
        {
            string s = "aAbBcC";
            string newS = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && Math.Abs(s[i] - s[i + 1]) == 32)
                {
                    i++;
                }
                else
                    newS += s[i];
            }
            Console.WriteLine(newS);
        }

        static void Task17()
        {
            int[] arr = [5, 7, 10];
            List<int> list = new List<int>();
            list.Add(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                list.Add(arr[i] - arr[i - 1]);
            }
            Console.WriteLine("[ " + string.Join(",", list) + " ]");


        }
        static void Task16()
        {
            int[] arr = [1, 2, 3, 2, 4];

            int start = 0;
            int end = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                int length = 10000000;
                List<int> list = new List<int>();

                for (int j = i; j < arr.Length; j++)
                {
                    if (!list.Contains(arr[j]))
                    {
                        list.Add(arr[j]);
                    }
                    else
                    {
                        list.Add(arr[j]);
                        if (list.Count < length)
                        {
                            length = list.Count;
                            start = i;
                            end = j;
                            break;
                        }

                    }

                }
            }
            for (int i = start; i <= end; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Task15()
        {
            int[] arr = [1, 2, 2, 3, 1, 2];
            int min = arr[0];
            int max = arr[0];
            int lenArray = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                List<int> list = new List<int>();

                for (int j = i; j < arr.Length; j++)
                {

                    if (arr[j] < min)
                        min = arr[j];
                    if (arr[j] > max)
                        max = arr[j];
                    if ((max - min) <= 1)
                    {
                        list.Add(arr[j]);

                    }
                    else
                        break;
                }
                if (list.Count > lenArray)
                    lenArray = list.Count;
            }
            Console.WriteLine(lenArray);
        }

        static void Task14()
        {
            int[] arr = [1, 3, 2, 4];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + 1) < arr.Length)
                {
                    if ((arr[i + 1] + 1) == arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        count++;
                    }
                }

            }
            if (count <= 1)
            {
                Console.WriteLine(string.Join(",", arr));
            }
        }

        static void Task13()
        {
            int[] arr = [1, 1, 2, 2, 3, 1];
            int x;

            for (int i = 0; i < arr.Length; i = i + x)
            {
                List<int> list = new List<int>();
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        list.Add(arr[j]);
                    }
                    else
                        break;
                }
                x = list.Count;
                Console.Write("[ " + string.Join(" , ", list) + " ]");
            }
        }

        static void Task12()
        {
            int[] arr = [1, 2, 1, 2, 1, 2];
            Dictionary<int, List<int>> positions = new Dictionary<int, List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                if (!positions.ContainsKey(current))
                {
                    positions[current] = new List<int>();
                }
                positions[current].Add(i);
            }


            List<int> result = new List<int>();

            foreach (KeyValuePair<int, List<int>> entry in positions)
            {
                List<int> posList = entry.Value;

                if (posList.Count < 2)
                    continue;

                int firstGap = posList[1] - posList[0];
                bool allEqual = true;

                for (int i = 1; i < posList.Count - 1; i++)
                {
                    int gap = posList[i + 1] - posList[i];

                    if (gap != firstGap)
                    {
                        allEqual = false;
                        break;
                    }
                }

                if (allEqual)
                    result.Add(entry.Key);
            }

            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }


        static void Task11()
        {
            int[] arr = [1, 2, 1, 3, 4];
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (!list.Contains(arr[j]))
                    {
                        list.Add(arr[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (list.Count >= 2)
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(" , ", list));
        }
        static void Task8()
        {
            int n = 5;
        }




        static void Task6()
        {

            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }

        static void Task5()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                int x = (int)Math.Pow(2, i - 1);
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(x);

                }
                Console.WriteLine();
            }

        }

        static void Task4()
        {

            int n = 4;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(2 * j - 1);
                }

                Console.WriteLine();
            }

        }




        static void Task1()
        {
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
