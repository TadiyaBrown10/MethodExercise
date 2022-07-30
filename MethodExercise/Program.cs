using System;

namespace MethodExercise
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;


        }

        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;

        }


        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }


        public static int Divide( int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;

        }


        public static int Modulus(int num1, int num2)
        {
            var answer = num1 % num2;


        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hi - What is your first name?' ");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hey there {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($" {color} is very nice! What about your favorite animal? ");
            var animal = Console.ReadLine();

            Console.WriteLine($" {animal} are awesome! what is your favorite band? ");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName} !");
            
        }
    }
}

