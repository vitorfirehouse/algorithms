namespace Demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input;

            Console.Write("Type a character");
            input = Console.ReadKey().KeyChar;
            Console.Clear();
            Console.WriteLine($"The entered character was {input}");
        }
    }
}
