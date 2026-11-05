namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, output;

            Console.Write("Insert the first number!");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the second number!");
            number2 = Convert.ToInt32(Console.ReadLine());
            output = number1 + number2;
            Console.WriteLine($"{number1}  + {number2}  = {output}");


    }
}
}