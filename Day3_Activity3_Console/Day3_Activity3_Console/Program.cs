namespace Day3_Activity3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String secret = "CSharp";

            String guess = "";
            
            while (guess!=secret)
            {
                Console.WriteLine("Guess the Secret Word : ");
                guess = Console.ReadLine();
            }

            Console.WriteLine("You find the Word. Well Done!!!!!");
            Console.ReadKey();
        }

        
    }
}
