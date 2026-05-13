namespace Day2_Activity2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the student's score (0-100): ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score < 0 || score > 100)
            {
                Console.WriteLine("Invalid score. Please enter a value between 0 and 100.");
            }
            else if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            Console.ReadKey();
        }
    }
}
