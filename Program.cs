using System;

namespace C__Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************** Create a Loop that prints all values from 1-255");
            Print_1_255();
            Console.WriteLine("**********************");
            Console.WriteLine("Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both:");
            Print_1_100_div_3_or_5();
            Console.WriteLine("*********************");
            Console.WriteLine("Modify the previous loop to print Fizz for multiples of 3, Buzz for multiples of 5, and FizzBuzz for numbers that are multiples of both 3 and 5");
            Print_Fizz_Buzz();
            Console.WriteLine("*********************");
            Console.WriteLine("(Optional) If you used for loops for your solution, try doing the same with while loops. Vice-versa if you used while loops!");
            Print_while_Fizz_Buzz();
        }




//1) Create a Loop that prints all values from 1-255:
        static void Print_1_255()
        {
            int start = 1;
            int end = 255;
            for(int i = start; i <= end; i++)
            {
                Console.Write($"{i}-");
            }
        }

//2)Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both:
        static void Print_1_100_div_3_or_5()
        {
            int start = 1;
            int end = 100;
            for(int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                continue;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write($"{i}-");
                }
            }
        }
    // 3) Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
        static void Print_Fizz_Buzz()
        {
            int start = 1;
            int end = 100;
            for(int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz");
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
            }
        }


// 4)(Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!

        static void Print_while_Fizz_Buzz()
        {
            int i = 1;
            while (i < 100)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz");

                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");

                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");

                }
                i = i + 1;

            }
        }


    }
}
