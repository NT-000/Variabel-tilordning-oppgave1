using System.Diagnostics.CodeAnalysis;

namespace variabler_num_num
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Put in a number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Put in another number");
            string input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            int sum = numbers(num1, num2);
       Console.WriteLine($"num1+num2: {num1} + {num2} = {sum}");
            int numbers(int number1, int number2)
            {
                return number1 + number2;
            }


    }
}
}
