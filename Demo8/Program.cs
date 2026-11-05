namespace Demo8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 550.55, AmountToDeposit;
            string name = "Vitor";
            char key = 'V';

            Console.WriteLine("Whats your name? ");
            name = Console.ReadLine();
            Console.Write($"How much would you like to deposit?");
            AmountToDeposit = Convert.ToDouble(Console.ReadLine());

            balance = balance + AmountToDeposit;

            //Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Your current balance is {Math.Round(balance, 2)}");
            Console.WriteLine($"{name}");
        }
    }
}
