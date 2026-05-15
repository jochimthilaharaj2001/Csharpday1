namespace Day3_Activity5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Say Goodbye");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;
                    case 2:
                        Console.WriteLine("Goodbye!");
                        break;
                    case 3:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            } while (choice != 3);

            Console.ReadKey();

        }
    }
}
