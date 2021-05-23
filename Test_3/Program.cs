using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment
{
    class Program
    {
        //1.--------------------
        static void DivisibleBySeven()
        {
            List<int> num = new List<int>();
            Console.WriteLine("PLEASE ENTER THE NUMBERS");
            for (int i = 0; i < 10; i++)
            {
                num.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("THE NUMBERS DIVISIBLE BY 7 ARE:\n");
            foreach (int i in num)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
            }
        }
        //2.---------------------
        static void PrimeNumbers()
        {
            int ctr;
            Console.WriteLine("PLEASE ENTER A MINIMUM VALUE:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PLEASE ENTER A MAXIMUM VALUE");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Write("THE PRIME NUMBERS BETWEEN {0} AND {1} ARE : \n", min, max);
            if (max < min)
            {
                Console.WriteLine("INVALID ENTRY");
            }
            else
            {
                for (int num = min; num <= max; num++)
                {
                    ctr = 0;

                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            ctr++;
                            break;
                        }
                    }
                    if (ctr == 0 && num != 1)
                    {
                        Console.WriteLine("{0} ", num);
                    }
                }
                Console.Write("\n");
            }
        }
        //3.---------------------------
        static void RepeatingNumbers()
        {
            Console.WriteLine("PLEASE ENTER POSTIVE NUMBERS TO CONTINUE OR ENTER A NEGATIVE NUMBER TO EXIT:");
            List<int> numbers = new List<int>();
            bool value = true;
            while (value)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                numbers.Add(n);
                if (n < 0)
                    value = false;
            }
            IEnumerable<int> duplicates =numbers.GroupBy(x => x)
                                       .Where(g => g.Count() > 1)
                                       .Select(x => x.Key);
            Console.WriteLine("REPEATING NUMBERS ARE:\n " + String.Join("\n",duplicates));
        }
        //4.------------------------------
        static void AscendingOrder()
        {
            Console.WriteLine("PLEASE ENTER POSTIVE NUMBERS TO CONTINUE OR ENTER 0 TO EXIT:");
            List<int> numbers = new List<int>();
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                    break;
                else
                    numbers.Add(i);
            }
            var num = (from i in numbers
                       select i).OrderBy(i => i).ToList();
            Console.WriteLine("THE NUMBERS AFTER SORTNG ARE:\n" + String.Join("\n",num));
        }
        //5.--------------------------------
        static void UserCredentials()
        {
            for (int i = 0; i < 3;)
            {
                Console.WriteLine("PLEASE ENTER THE USERNAME");
                String username = Console.ReadLine();
                Console.WriteLine("PLEASE ENTER THE PASSWORD");
                String password = Console.ReadLine();
                if ((username == "Admin") & (password == "admin"))
                {
                    Console.WriteLine("WELCOME");
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID USERNAME OR PASSWORD\nTRY AGAIN\n");
                    i++;
                }
                if (i == 3)
                    Console.WriteLine("SORRY,YOU HAVE TRIED ALREADY 3 TIMES..!");
            }
        }
        static void Main(string[] args)
        {
<<<<<<< HEAD
            console.writeline("--------divisible by 7--------\n");
            divisiblebyseven();
            console.writeline("--------prime numbers--------\n");
            primenumbers();
            console.writeline("--------repeating numbers--------\n");
            repeatingnumbers();
            console.writeline("--------printing the numbers in ascending--------\n");
            ascendingorder();
            console.writeline("--------checking the user credentials--------\n");
            usercredentials();
=======
            Console.WriteLine("--------DIVISIBLE BY 7--------\n");
            DivisibleBySeven();
            Console.WriteLine("--------PRIME NUMBERS--------\n");
            PrimeNumbers();
            Console.WriteLine("--------REPEATING NUMBERS--------\n");
            RepeatingNumbers();
            Console.WriteLine("--------PRINTING THE NUMBERS IN ASCENDING--------\n");
            AscendingOrder();
            Console.WriteLine("--------CHECKING THE USER CREDENTIALS--------\n");
            UserCredentials();
>>>>>>> 60390a0119f9bd2a7af2bfb8b5eccbab53216154
        }
    }
}
