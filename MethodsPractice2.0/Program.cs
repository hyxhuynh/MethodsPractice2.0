using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MethodsPractice2._0
{
    internal class Program
    {
        public static void MicrobeDescription()
        {
            // Declaration of variables
            string microbeName;
            string microbeType;
            string microbeShape;
            string microbeHabitat;
            string microbeEffect;

            // User input:
            Console.WriteLine("What is the type of the micro-organism? (bacteria, virus, or fungi)");
            microbeType = Console.ReadLine();
            Console.WriteLine("What is the name of the micro-organism?");
            microbeName = Console.ReadLine();
            Console.WriteLine("What is its shape? (rod-shaped, grape-like cluster, etc.)");
            microbeShape = Console.ReadLine();
            Console.WriteLine("Where is it commonly found? (which animal or plant)");
            microbeHabitat = Console.ReadLine();
            Console.WriteLine("What harmful effect does it have on animal or plant? (food poisoning, infection, etc.)");
            microbeEffect = Console.ReadLine();

            // String interpolation
            // Output example
            // E.coli is a type of bacteria, rod-shaped, and is commonly found in human. E.coli can cause food poisoning to its host.
            Console.WriteLine($"{microbeName} is a type of {microbeType}, {microbeShape}, and is commonly found in {microbeHabitat}. {microbeName} can cause {microbeEffect} to its host.");
        }

        public static void Add(params int[] numbers) 
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        public static void Subtract (int num1, int num2) 
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }

        public static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        public static void Divide (int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }

        public static void Mod(int num1, int num2)
        {
            int result = num1 % num2;
            Console.WriteLine(result);
        }


        static void Main(string[] args)
        {
            MicrobeDescription();

            // User Input
            Console.WriteLine("\nEnter first number:");
            int firstNum = int.Parse(Console.ReadLine());   
            Console.WriteLine("Enter second number:");
            int secondNum = int.Parse(Console.ReadLine());

            // Math Operators
            Console.Write($"{firstNum} + {secondNum} = ");
            Add(firstNum, secondNum);
            Console.WriteLine();
             
            Console.Write($"{firstNum} - {secondNum} = ");
            Subtract(firstNum, secondNum);
            Console.WriteLine();

            Console.Write($"{firstNum} * {secondNum} = ");
            Multiply(firstNum, secondNum);
            Console.WriteLine();

            Console.Write($"{firstNum} / {secondNum} = ");
            Divide(firstNum, secondNum);
            Console.WriteLine();

            Console.Write($"{firstNum} % {secondNum} = ");
            Mod(firstNum, secondNum);

        }
    }
}
