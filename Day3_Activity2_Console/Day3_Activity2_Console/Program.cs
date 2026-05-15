namespace Day3_Activity2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
                int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            
            }

        }
    }
}
