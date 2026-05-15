namespace Day3_Activity4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Positive Number : ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            int i = 1;
            while (i <= num)
            {
                sum += i;
                i++;
            }


            Console.WriteLine($"The sum of numbers from 1 to {num} is {sum}");
            Console.ReadKey();




        }
        
    }
}
