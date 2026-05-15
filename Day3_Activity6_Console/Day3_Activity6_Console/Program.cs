namespace Day3_Activity6_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; 1 < 1000; i++) {

                if (i % num == 0)
                {
                    Console.WriteLine(i);
                    break;
                    
                }


            }

            Console.ReadKey();
        }
    }
}
