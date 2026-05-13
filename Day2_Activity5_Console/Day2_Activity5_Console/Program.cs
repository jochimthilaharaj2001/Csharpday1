namespace Day2_Activity5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basePrice = 12.50;

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Are you a student? (yes/no): ");
            string studentInput = Console.ReadLine().ToLower();

            double finalPrice = basePrice;

            if (age <= 12 || age >= 65) 
            {
                finalPrice = basePrice * 0.5;
            }
            else if (studentInput == "yes") 
            {
                finalPrice = basePrice * 0.75;
            }

            Console.WriteLine($"Final ticket price: Rs.{finalPrice:F2}");
        }
    }
}
