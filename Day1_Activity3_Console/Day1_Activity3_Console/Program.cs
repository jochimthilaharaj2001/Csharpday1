namespace Day1_Activity3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Temperature in Celsius: ");
            String temp = Console.ReadLine();
            double celcius = double.Parse(temp);

            double fahrenheit = (celcius * 9 / 5) + 32;

            Console.WriteLine(celcius + "°C is equal to " + fahrenheit + "°F");
        }
    }
}
