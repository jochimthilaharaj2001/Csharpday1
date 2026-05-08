namespace Day1_Activity4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Number:");
            string numInput1 = Console.ReadLine();
            int num1 = int.Parse(numInput1);

            Console.WriteLine("Please enter another Number:");
            string numInput2 = Console.ReadLine();
            int num2 = int.Parse(numInput2);

            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            double div = num1 / num2;

            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + sum+ "."+ 
                "\r\nDifference between "+num1+" and "+num2+ " is " +sub+ "."+ "\r\nProduct: "+mul+"."+ "\r\nQuotient: "+div+".");

            

            

        }
    }
}
