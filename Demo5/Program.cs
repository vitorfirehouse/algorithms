namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, average;

            Console.Write("Whats the first value? ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Whats the second value? ");
            n2 = Convert.ToDouble(Console.ReadLine());
            average = (n1 + n2) / 2;
            Console.WriteLine($"The average of the input values is {Math.Round(average,2)}");

            
        }
    }
}
