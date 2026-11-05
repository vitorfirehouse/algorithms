namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, output, output2;

            Console.Write("Insert the fisrt number:  ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the second number:  ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the third number:  ");
            number3 = Convert.ToInt32(Console.ReadLine());
            output = number1 + number2 + number3;
            Console.WriteLine($"{number1} + {number2} + {number3}");


        }
    }
}
