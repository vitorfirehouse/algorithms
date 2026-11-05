namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.Write("Insert the first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{number1} + {number2} =  {number1 + number2}");


        }
    }
}