namespace Day2_Activity3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);
            Console.WriteLine($"Your BMI is: {bmi:F2}");

            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Normal weight");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obesity");
            }


        }
    }
}
