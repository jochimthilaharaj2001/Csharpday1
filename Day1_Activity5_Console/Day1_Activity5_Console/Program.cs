namespace Day1_Activity5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());

            double rectangleArea = width * height;
            Console.WriteLine("The area of the rectangle is: " + rectangleArea);

           
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + circleArea);
        }
    }
    
}
