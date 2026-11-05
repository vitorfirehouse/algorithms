namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ways to name variable 
            // First - CAMEL CASE  
            // Second - CAMEL CASE 
            // Third - UNDERSCORE

            // Coments - you can use this to let this area as a coment ( // )________ ( /*    */ )

            // First step, Define the variable 
            string firstName, lastName;

            // Data Input 
            Console.Write("Whats your first name:")
            firstName = Console.ReadLine();
            Console.WriteLine("What about your last name");
            lastName = Console.ReadLine();


            // Data Output

            Console.WriteLine($"Hello, {firstName} { lastName}, How are  U?.");


        }
    }
}
